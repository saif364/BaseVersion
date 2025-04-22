using BaseVersion.Models.Entities.EmployeeManagement.Configuraiton;
using BaseVersion.Repository.DbConfigure;
using BaseVersion.Repository.Interface.EmployeeManagement.Configuraiton;

namespace BaseVersion.Repository.Repository.EmployeeManagement.Configuraiton
{
    public class AssetRepository : Repository<Asset>, IAssetRepository
    { 
        public AssetRepository(HRMDbContext context) : base(context) { }
    }
            
}  
   