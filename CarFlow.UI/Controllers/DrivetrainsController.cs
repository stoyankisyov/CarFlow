using CarFlow.DomainServices.Interfaces;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers;

public class DrivetrainsController(IDrivetrainService drivetrainService) : Controller
{
    private const string AdminPolicy = "AdminPolicy";

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Index(int currentPage = 1, int pageSize = 20)
    {
        var pageViewModel = (await drivetrainService.GetPageAsync(currentPage, pageSize)).ToViewModel();

        return View(pageViewModel);
    }

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public IActionResult Create()
        => View();

    [HttpPost]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Create(DrivetrainViewModel drivetrain)
    {
        await drivetrainService.AddAsync(drivetrain.ToDomainModel());

        return RedirectToAction(nameof(Index));
    }

    [HttpDelete]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Delete(int id)
    {
        await drivetrainService.DeleteAsync(id);

        return Json(new { success = true, message = "DeleteAsync successful." });
    }

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Update(int id)
    {
        var drivetrainViewModel = (await drivetrainService.GetAsync(id)).ToViewModel();

        return View(drivetrainViewModel);
    }

    [HttpPost]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Update(DrivetrainViewModel drivetrain)
    {
        await drivetrainService.UpdateAsync(drivetrain.ToDomainModel());

        return RedirectToAction(nameof(Update));
    }
}