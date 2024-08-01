using CarFlow.DomainServices.Interfaces;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers;

public class EngineAspirationsController(IEngineAspirationService engineAspirationService) : Controller
{
    private const string AdminPolicy = "AdminPolicy";

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Index(int currentPage = 1, int pageSize = 20)
    {
        var pageViewModel = (await engineAspirationService.GetPageAsync(currentPage, pageSize)).ToViewModel();

        return View(pageViewModel);
    }

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public IActionResult Create()
        => View();

    [HttpPost]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Create(EngineAspirationViewModel engineAspiration)
    {
        await engineAspirationService.AddAsync(engineAspiration.ToDomainModel());

        return RedirectToAction(nameof(Index));
    }

    [HttpDelete]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Delete(int id)
    {
        await engineAspirationService.DeleteAsync(id);

        return Json(new { success = true, message = "DeleteAsync successful." });
    }

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Update(int id)
    {
        var engineAspirationViewModel = (await engineAspirationService.GetAsync(id)).ToViewModel();

        return View(engineAspirationViewModel);
    }

    [HttpPost]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Update(EngineAspirationViewModel engineAspiration)
    {
        await engineAspirationService.UpdateAsync(engineAspiration.ToDomainModel());

        return RedirectToAction(nameof(Update));
    }
}