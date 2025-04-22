using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseVersion.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; } = GenerateUniqueId();

        private static string GenerateUniqueId()
        {
            return $"{DateTime.UtcNow:yyyyMMddHHmmss}-{Guid.NewGuid()}";
        }
    }

}
