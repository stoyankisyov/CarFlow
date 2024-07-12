using CarFlow.DomainServices.IService;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.UI.Controllers
{
    public class MakeController(IMakeService makeService) : Controller
    {
        private const string AdminPolicy = "AdminPolicy";

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Index(int currentPage = 1, int pageSize = 20)
        {
            var pageViewModel = (await makeService.GetPageAsync(currentPage, pageSize)).ToViewModel();

            return View(pageViewModel);
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Details(int id)
        {
            var makeViewModel = (await makeService.GetAsync(id)).ToViewModel();

            return View(makeViewModel);
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public IActionResult Create() => View();

        [HttpPost]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Create(MakeViewModel make)
        {
            await makeService.AddAsync(make.ToDomainModel());

            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Delete(int id)
        {
            await makeService.DeleteAsync(id);

            return Json(new { success = true, message = "DeleteAsync successful." });
        }

        [HttpGet]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Update(int id)
        {
            var makeViewModel = (await makeService.GetAsync(id)).ToViewModel();

            return View(makeViewModel);
        }

        [HttpPost]
        [Authorize(Policy = AdminPolicy)]
        public async Task<IActionResult> Update(MakeViewModel make)
        {
            await makeService.UpdateAsync(make.ToDomainModel());

            return RedirectToAction(nameof(Update));
        }
    }
}
