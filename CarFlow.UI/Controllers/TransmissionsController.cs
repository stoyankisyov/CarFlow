using CarFlow.DomainServices.Interfaces;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers;

public class TransmissionsController(ITransmissionService transmissionService) : Controller
{
    private const string AdminPolicy = "AdminPolicy";

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Index(int currentPage = 1, int pageSize = 20)
    {
        var pageViewModel = (await transmissionService.GetPageAsync(currentPage, pageSize)).ToViewModel();

        return View(pageViewModel);
    }

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Details(int id)
    {
        var transmissionViewModel = (await transmissionService.GetAsync(id)).ToViewModel();

        return View(transmissionViewModel);
    }

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public IActionResult Create()
        => View();

    [HttpPost]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Create(TransmissionViewModel transmission)
    {
        await transmissionService.AddAsync(transmission.ToDomainModel());

        return RedirectToAction(nameof(Index));
    }

    [HttpDelete]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Delete(int id)
    {
        await transmissionService.DeleteAsync(id);

        return Json(new { success = true, message = "DeleteAsync successful." });
    }

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Update(int id)
    {
        var transmissionViewModel = (await transmissionService.GetAsync(id)).ToViewModel();

        return View(transmissionViewModel);
    }

    [HttpPost]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Update(TransmissionViewModel transmission)
    {
        await transmissionService.UpdateAsync(transmission.ToDomainModel());

        return RedirectToAction(nameof(Update));
    }
}