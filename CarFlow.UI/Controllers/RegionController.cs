using CarFlow.DomainServices.IService;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers
{
    public class RegionController(IRegionService regionService) : Controller
    {
        private const string AdminPolicy = "AdminPolicy";

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Index(int currentPage = 1, int pageSize = 20)
        {
            var pageViewModel = (await regionService.GetPageAsync(currentPage, pageSize)).ToViewModel();

            return View(pageViewModel);
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Details(int id)
        {
            var regionViewModel = (await regionService.GetAsync(id)).ToViewModel();

            return View(regionViewModel);
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public IActionResult Create() => View();

        [HttpPost]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Create(RegionViewModel region)
        {
            await regionService.AddAsync(region.ToDomainModel());

            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Delete(int id)
        {
            await regionService.DeleteAsync(id);

            return Json(new { success = true, message = "DeleteAsync successful." });
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Update(int id)
        {
            var regionViewModel = (await regionService.GetAsync(id)).ToViewModel();

            return View(regionViewModel);
        }

        [HttpPost]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Update(RegionViewModel region)
        {
            await regionService.UpdateAsync(region.ToDomainModel());

            return RedirectToAction(nameof(Update));
        }
    }
}
