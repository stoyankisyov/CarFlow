using CarFlow.DomainServices.Interfaces;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers;

public class BrandsController(IBrandService brandService) : Controller
{
    private const string AdminPolicy = "AdminPolicy";

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Index(int currentPage = 1, int pageSize = 20)
    {
        var pageViewModel = (await brandService.GetPageAsync(currentPage, pageSize)).ToViewModel();

        return View(pageViewModel);
    }

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Details(int id)
    {
        var brandViewModel = (await brandService.GetAsync(id)).ToViewModel();

        return View(brandViewModel);
    }

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public IActionResult Create()
        => View();

    [HttpPost]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Create(BrandViewModel brand)
    {
        await brandService.AddAsync(brand.ToDomainModel());

        return RedirectToAction(nameof(Index));
    }

    [HttpDelete]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Delete(int id)
    {
        await brandService.DeleteAsync(id);

        return Json(new { success = true, message = "DeleteAsync successful." });
    }

    [HttpGet]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Update(int id)
    {
        var brandViewModel = (await brandService.GetAsync(id)).ToViewModel();

        return View(brandViewModel);
    }

    [HttpPost]
    [Authorize(Policy = AdminPolicy)]
    public async Task<IActionResult> Update(BrandViewModel brand)
    {
        await brandService.UpdateAsync(brand.ToDomainModel());

        return RedirectToAction(nameof(Update));
    }
}