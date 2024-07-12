using CarFlow.DomainServices.IService;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers
{
    public class FuelTypeController(IFuelTypeService fuelTypeService) : Controller
    {
        private const string AdminPolicy = "AdminPolicy";

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Index(int currentPage = 1, int pageSize = 20)
        {
            var pageViewModel = (await fuelTypeService.GetPageAsync(currentPage, pageSize)).ToViewModel();

            return View(pageViewModel);
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public IActionResult Create() => View();

        [HttpPost]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Create(FuelTypeViewModel fuelType)
        {
            await fuelTypeService.AddAsync(fuelType.ToDomainModel());

            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Delete(int id)
        {
            await fuelTypeService.DeleteAsync(id);

            return Json(new { success = true, message = "DeleteAsync successful." });
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Update(int id)
        {
            var fuelTypeViewModel = (await fuelTypeService.GetAsync(id)).ToViewModel();

            return View(fuelTypeViewModel);
        }

        [HttpPost]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Update(FuelTypeViewModel fuelType)
        {
            await fuelTypeService.UpdateAsync(fuelType.ToDomainModel());

            return RedirectToAction(nameof(Update));
        }
    }
}
