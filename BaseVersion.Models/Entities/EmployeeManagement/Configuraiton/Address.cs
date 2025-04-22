using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseVersion.Models.Entities.EmployeeManagement.Configuraiton
{
    public class Address :BaseEntity
    {
        
        // Basic address properties
        [Required]
        [MaxLength(100)]
        public string Street { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        // Additional properties
        [MaxLength(50)]
        public string County { get; set; } // Commonly used in certain countries

        [MaxLength(100)]
        public string District { get; set; } // Useful for regions with districts

        [MaxLength(50)]
        public string Neighborhood { get; set; } // Smaller subdivisions, such as neighborhoods

        [MaxLength(10)]
        public string ApartmentNumber { get; set; } // For specific apartment or unit numbers

        [MaxLength(10)]
        public string BuildingNumber { get; set; } // Distinct from Street, for building numbers

        [MaxLength(100)]
        public string Landmark { get; set; } // Nearby landmark to help identify the location

        // Geographic coordinates
        public double? Latitude { get; set; } // Latitude coordinate for mapping
        public double? Longitude { get; set; } // Longitude coordinate for mapping

        // Address type or category
        [MaxLength(20)]
        public string AddressType { get; set; } // e.g., "Home", "Office", "Warehouse"

        // Contact information
        [MaxLength(15)]
        public string ContactPhone { get; set; } // Optional contact phone number for this address

        [MaxLength(100)]
        public string ContactPerson { get; set; } // Optional contact person for this address
         

        // IsPrimary indicates if this address is the primary address (e.g., primary residence)
        public bool IsPrimary { get; set; } = false;

        // Optional notes or additional information
        [MaxLength(250)]
        public string Notes { get; set; }
    }

}
