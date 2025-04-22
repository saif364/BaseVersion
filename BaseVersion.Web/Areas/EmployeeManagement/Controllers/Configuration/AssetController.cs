using BaseVersion.Models.Entities.EmployeeManagement.Configuraiton;
using BaseVersion.Service.Interface.EmployeeManagement.Configuraiton;
using BaseVersion.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BaseVersion.Web.Areas.EmployeeManagement.Controllers.Configuration
{
    [Area("EmployeeManagement")]
    [Route("EmployeeManagement/[controller]/[action]")]
    public class AssetController : BaseController
    {
        private readonly IAssetService _AssetService;
        private readonly ILogger<AssetController> _logger;

        public AssetController(ILogger<AssetController> logger, IAssetService AssetService)
        {

            _AssetService = AssetService;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _AssetService.GetAllAsync();
            return View(list.ToList());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Asset Asset)
        {
            try
            {
                await _AssetService.AddAsync(Asset); //db related
                return JsonSuccess("Data Saved successfully", "Index");
            }
            catch (Exception ex)
            {
                return JsonInternalServerError(ex.InnerException?.Message ?? ex.Message);
            }

        }

        public async Task<IActionResult> Edit(string id)
        {
            var Asset = await _AssetService.GetByIdAsync(id);
            return View(Asset);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Asset Asset)
        {
            try
            {
                await _AssetService.UpdateAsync(Asset);
                return JsonSuccess("Data Updated successfully", "Index");

            }
            catch (Exception ex)
            {
                return JsonInternalServerError(ex.InnerException?.Message ?? ex.Message);
            }


        }

        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                await _AssetService.DeleteAsync(id);
                return JsonSuccess("Data Deleted successfully", "Index");
            }
            catch (Exception ex)
            {
                return JsonInternalServerError(ex.InnerException?.Message ?? ex.Message);
            }

        }
        public async Task<IActionResult> Details(string id)
        {
            var Asset = await _AssetService.GetByIdAsync(id);
            return View(Asset);
        }


    }
}
