using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseVersion.Models.Entities.EmployeeManagement.Configuraiton
{
    public class Asset : BaseEntity
    {
        public string AssetName { get; set; }
        public string AssetType { get; set; } // e.g., Laptop, Phone, etc.
        public string SerialNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime? WarrantyExpiryDate { get; set; }
        public bool IsActive { get; set; }
    }
}
