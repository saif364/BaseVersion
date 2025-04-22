using BaseVersion.Models.Entities.EmployeeManagement.Configuraiton;
using BaseVersion.Service.Interface.EmployeeManagement.Configuraiton;
using BaseVersion.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BaseVersion.Web.Areas.EmployeeManagement.Controllers.Configuration
{
    [Area("EmployeeManagement")]
    [Route("EmployeeManagement/[controller]/[action]")]
    public class AddressController : BaseController
    {
        private readonly IAddressService _AddressService;
        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger, IAddressService AddressService)
        {

            _AddressService = AddressService;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _AddressService.GetAllAsync();
            return View(list.ToList());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Address Address)
        {
            try
            {
                await _AddressService.AddAsync(Address); //db related
                return JsonSuccess("Data Saved successfully", "Index");
            }
            catch (Exception ex)
            {
                return JsonInternalServerError(ex.InnerException?.Message ?? ex.Message);
            }

        }

        public async Task<IActionResult> Edit(string id)
        {
            var Address = await _AddressService.GetByIdAsync(id);
            return View(Address);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Address Address)
        {
            try
            {
                await _AddressService.UpdateAsync(Address);
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
                await _AddressService.DeleteAsync(id);
                return JsonSuccess("Data Deleted successfully", "Index");
            }
            catch (Exception ex)
            {
                return JsonInternalServerError(ex.InnerException?.Message ?? ex.Message);
            }

        }
        public async Task<IActionResult> Details(string id)
        {
            var Address = await _AddressService.GetByIdAsync(id);
            return View(Address);
        }


    }
}
