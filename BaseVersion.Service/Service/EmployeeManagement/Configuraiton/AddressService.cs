using BaseVersion.Models.Entities.EmployeeManagement.Configuraiton;
using BaseVersion.Repository.Interface.EmployeeManagement.Configuraiton;
using BaseVersion.Service.Interface.EmployeeManagement.Configuraiton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseVersion.Service.Service.EmployeeManagement.Configuraiton
{
    public class AddressService : BaseService<Address>, IAddressService
    {
        public AddressService(IAddressRepository AddressRepository)
            : base(AddressRepository)
        {
        }

        // Additional methods specific to AddressService can go here, if needed
    }

}
