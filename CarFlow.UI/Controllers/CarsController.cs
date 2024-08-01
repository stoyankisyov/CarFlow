using CarFlow.DomainServices.Interfaces;
using CarFlow.UI.Interfaces;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers;

public class CarsController(
    ICarService carService,
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
            Options = new CarManagementOptionsViewModel
            {
                BaseOptions = await optionsManager.GetCarBaseOptionsAsync(),
                CombustionEngineCarOptions = await optionsManager.GetCombustionEngineCarOptionsAsync()
            }
        });

    [HttpPost]
    public async Task<IActionResult> Create(CarViewModel viewViewModel)
    {
        await carService.AddAsync(viewViewModel.ToCreateCommand());

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
            Options = new CarManagementOptionsViewModel
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
        await carService.UpdateAsync(viewViewModel.ToUpdateCommand());

        return RedirectToAction(nameof(Update));
    }
}