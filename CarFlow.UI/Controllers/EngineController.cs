using CarFlow.DomainServices.IService;
using CarFlow.UI.Interfaces;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers
{
    public class EngineController(
        IEngineService engineService,
        IEngineOptionsManager engineOptionsManager)
        : Controller
    {
        private const string AdminPolicy = "AdminPolicy";

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Index(int currentPage = 1, int pageSize = 20)
        {
            var pageViewModel = (await engineService.GetPageAsync(currentPage, pageSize)).ToViewModel();

            return View(pageViewModel);
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Details(int id)
        {
            var engineViewModel = (await engineService.GetAsync(id)).ToViewModel();

            return View(engineViewModel);
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Create()
            => View(new EngineManagementViewModel()
            {
                Options = await engineOptionsManager.GetEngineOptionsAsync()
            });

        [HttpPost]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Create(EngineViewModel engine)
        {
            await engineService.AddAsync(engine.ToDomainModel());

            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Delete(int id)
        {
            await engineService.DeleteAsync(id);

            return Json(new { success = true, message = "DeleteAsync successful." });
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Update(int id)
        {
            var engineManagementViewModel = (await engineService.GetAsync(id)).ToEngineManagementViewModel();
            engineManagementViewModel.Options = await engineOptionsManager.GetEngineOptionsAsync();

            return View(engineManagementViewModel);
        }

        [HttpPost]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Update(EngineViewModel engine)
        {
            await engineService.UpdateAsync(engine.ToDomainModel());

            return RedirectToAction(nameof(Update));
        }
    }
}
