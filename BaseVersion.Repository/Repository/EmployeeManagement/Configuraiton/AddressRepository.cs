using BaseVersion.Models.Entities.EmployeeManagement.Configuraiton;
using BaseVersion.Repository.DbConfigure;
using BaseVersion.Repository.Interface.EmployeeManagement.Configuraiton;

namespace BaseVersion.Repository.Repository.EmployeeManagement.Configuraiton
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    { 
        public AddressRepository(HRMDbContext context) : base(context) { }
    }
            
}  
   