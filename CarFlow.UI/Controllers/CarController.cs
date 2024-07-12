using CarFlow.DomainServices.IService;
using CarFlow.UI.Interfaces;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers
{
    public class CarController(
        ICarService carService,
        IMakeService makeService,
        ITransmissionService transmissionService,
        IEngineService engineService,
        ICarOptionsManager optionsManager)
        : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(int currentPage = 1, int pageSize = 20)
        {
            var pageViewModel = (await carService.GetPageAsync(currentPage, pageSize)).ToViewModel();

            return View(pageViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var car = (await carService.GetAsync(id)).ToViewModel();

            return View(car);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
            => View(new CarManagementViewModel
            {
                Options = new CarManagementOptionsViewModel()
                {
                    BaseOptions = await optionsManager.GetCarBaseOptionsAsync(),
                    CombustionEngineCarOptions = await optionsManager.GetCombustionEngineCarOptionsAsync()
                }
            });

        [HttpPost]
        public async Task<IActionResult> Create(CarViewModel viewViewModel)
        {
            // TODO: This is going to be improved in Task CF-352. To avoid having logic in the controller
            viewViewModel.Make = (await makeService.GetAsync(viewViewModel.Make.Id)).ToViewModel();
            viewViewModel.Transmission = (await transmissionService.GetAsync(viewViewModel.Transmission.Id)).ToViewModel();
            viewViewModel.Body = new BodyViewModel()
            {
                Id = viewViewModel.BodyVariant.BodyId,
                Name = "Sedan",
                Variants = [viewViewModel.BodyVariant]
            };

            // TODO: This is going to be improved in Task CF-352. To avoid having logic in the controller
            if (viewViewModel is not CombustionEngineCarViewViewModel combustionEngineCar)
            {
                await carService.AddAsync(viewViewModel.ToDomainModel());
                return RedirectToAction(nameof(Index));
            }

            // TODO: This is going to be improved in Task CF-352. To avoid having logic in the controller
            combustionEngineCar.Engine = (await engineService.GetAsync(combustionEngineCar.Engine.Id)).ToViewModel();
            await carService.AddAsync(viewViewModel.ToDomainModel());

            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await carService.DeleteAsync(id);

            return Json(new { success = true, message = "DeleteAsync successful." });
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var car = (await carService.GetAsync(id)).ToViewModel();

            return View(new CarManagementViewModel
            {
                Options = new CarManagementOptionsViewModel()
                {
                    BaseOptions = await optionsManager.GetCarBaseOptionsAsync(),
                    CombustionEngineCarOptions = await optionsManager.GetCombustionEngineCarOptionsAsync()
                },
                Car = car
            });
        }

        [HttpPost]
        public async Task<IActionResult> Update(CarViewModel viewViewModel)
        {
            // TODO: This is going to be improved in Task CF-352. To avoid having logic in the controller
            viewViewModel.Make = (await makeService.GetAsync(viewViewModel.Make.Id)).ToViewModel();
            viewViewModel.Transmission = (await transmissionService.GetAsync(viewViewModel.Transmission.Id)).ToViewModel();
            viewViewModel.Body = new BodyViewModel()
            {
                Id = viewViewModel.BodyVariant.BodyId,
                Name = "Sedan",
                Variants = [viewViewModel.BodyVariant]
            };

            if (viewViewModel is not CombustionEngineCarViewViewModel combustionEngineCar)
            {
                await carService.UpdateAsync(viewViewModel.ToDomainModel());

                return RedirectToAction(nameof(Update));
            }

            combustionEngineCar.Engine = (await engineService.GetAsync(combustionEngineCar.Engine.Id)).ToViewModel();
            await carService.UpdateAsync(viewViewModel.ToDomainModel());

            return RedirectToAction(nameof(Update));
        }
    }
}
