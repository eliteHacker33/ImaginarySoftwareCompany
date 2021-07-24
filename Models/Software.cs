using ImaginarySoftwareCompany.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImaginarySoftwareCompany.Models
{
    public class Software
    {
        public string Name { get; set; }
        public Version Version { get; set; }
    }
}
