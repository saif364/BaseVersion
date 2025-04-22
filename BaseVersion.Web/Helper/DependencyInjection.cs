using BaseVersion.Models.Entities;
using BaseVersion.Repository.DbConfigure;
using BaseVersion.Repository.Interface;
using BaseVersion.Repository.Interface.EmployeeManagement.Configuraiton;
using BaseVersion.Repository.Repository;
using BaseVersion.Repository.Repository.EmployeeManagement.Configuraiton;
using BaseVersion.Service.Interface.EmployeeManagement.Configuraiton;
using BaseVersion.Service.InterfaceService;
using BaseVersion.Service.Service;
using BaseVersion.Service.Service.EmployeeManagement.Configuraiton;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagement.Helper
{
    public static class DependencyInjection
    {
        public static IServiceCollection ServiceCollectionsDI(this IServiceCollection services, string connectionString)
        {

            #region Program cs configure services
            // Register LibraryDbContext with Identity
            services.AddDbContext<HRMDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Register Identity with the LibraryDbContext
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<HRMDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.User.RequireUniqueEmail = true;
            });
            //

            services.AddControllersWithViews();
            //swagger for api
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            //

            // Configure cookie settings
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
            });
            //
            #endregion


            #region  ================= Own Service ================= 
            // Service Registrations
            #region ================= Employee Management =================
            services.AddScoped<IAssetService, AssetService>();
            
            services.AddScoped<IAddressService, AddressService>();
            

            //Core
            //services.AddScoped<IEmployeeService, EmployeeService>();


            #endregion


            // Repository registrations
            services.AddScoped<IAssetRepository, AssetRepository>();
           
            services.AddScoped<IAddressRepository, AddressRepository>();
            

            //Core
            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();




            // Audit trial registration


            //direct repository call for no business layer . Like child objects



            #endregion

            // AutoMapper registration
            services.AddAutoMapper(typeof(MappingProfile)); // Registers all profiles including MappingProfile



            return services;
        }
    }
}
