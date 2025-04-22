using BaseVersion.Models.Entities;
using BaseVersion.Models.Entities.EmployeeManagement;
using BaseVersion.Models.Entities.EmployeeManagement.Configuraiton;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Reflection.Emit;

namespace BaseVersion.Repository.DbConfigure
{
    public class HRMDbContext : IdentityDbContext<ApplicationUser>
    {


        public HRMDbContext(DbContextOptions<HRMDbContext> options) : base(options)
        {

        }
         
        #region ==============================Employe Management============================== 

        #region  ==============Configuraiton============== 
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Address> Addresss { get; set; }



        #endregion

        #region ==============Core==============
 
        #endregion

        #endregion

         
    }
}
