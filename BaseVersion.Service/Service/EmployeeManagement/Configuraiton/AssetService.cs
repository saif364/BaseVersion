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
    public class AssetService : BaseService<Asset>, IAssetService
    {
        public AssetService(IAssetRepository AssetRepository)
            : base(AssetRepository)
        {
        }

        // Additional methods specific to AssetService can go here, if needed
    }

}
