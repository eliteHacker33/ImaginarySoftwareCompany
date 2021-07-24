using ImaginarySoftwareCompany.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImaginarySoftwareCompany.Models
{
    public class VersionManager
    {
        public IEnumerable<Software> SoftwareVersions { get; set; }

        [Version]
        public string Version { get; set; }
    }
}
