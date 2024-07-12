using CarFlow.DomainServices.IService;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers
{
    public class EngineConfigurationController(IEngineConfigurationService engineConfigurationService) : Controller
    {
        private const string AdminPolicy = "AdminPolicy";

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Index(int currentPage = 1, int pageSize = 20)
        {
            var pageViewModel = (await engineConfigurationService.GetPageAsync(currentPage, pageSize)).ToViewModel();

            return View(pageViewModel);
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public IActionResult Create() => View();

        [HttpPost]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Create(EngineConfigurationViewModel engineConfiguration)
        {
            await engineConfigurationService.AddAsync(engineConfiguration.ToDomainModel());

            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Delete(int id)
        {
            await engineConfigurationService.DeleteAsync(id);

            return Json(new { success = true, message = "DeleteAsync successful." });
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Update(int id)
        {
            var engineConfigurationViewModel = (await engineConfigurationService.Get(id)).ToViewModel();

            return View(engineConfigurationViewModel);
        }

        [HttpPost]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Update(EngineConfigurationViewModel engineConfiguration)
        {
            await engineConfigurationService.UpdateAsync(engineConfiguration.ToDomainModel());

            return RedirectToAction(nameof(Update));
        }
    }
}
