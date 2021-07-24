using ImaginarySoftwareCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImaginarySoftwareCompany.Helpers
{
    public static class SoftwareManager
    {
        public static IEnumerable<Software> GetAllSoftware()
        {
            return new List<Software>
            {
                new Software
                {
                    Name = "MS Word",
                    Version = new Version("13.2.1")
                },
                new Software
                {
                    Name = "AngularJS",
                    Version = new Version("1.7.1")
                },
                new Software
                {
                    Name = "Angular",
                    Version = new Version("8.1.13")
                },
                new Software
                {
                    Name = "React",
                    Version = new Version("0.0.5")
                },
                new Software
                {
                    Name = "Vue.js",
                    Version = new Version("2.6")
                },
                new Software
                {
                    Name = "Visual Studio",
                    Version = new Version("2017.0.1")
                },
                new Software
                {
                    Name = "Visual Studio",
                    Version = new Version("2019.1")
                },
                new Software
                {
                    Name = "Visual Studio Code",
                    Version = new Version("1.35")
                },
                new Software
                {
                    Name = "Blazor",
                    Version = new Version("0.7")
                }
            };
        }

        public static IEnumerable<Software> GetSuccessiveSoftwareVersions(VersionManager providedSoftware)
        {
            try
            {
                IEnumerable<Software> allSoftware = GetAllSoftware();
                Version versionProvided = new Version(GetStringVersion(providedSoftware.Version));
                return allSoftware.Where(x => x.Version > versionProvided);
            }
            catch(Exception ex)
            {
                throw new Exception("Unable to obtain a collection of later software versions with exception: " + ex.Message);
            }
        }

        public static string GetStringVersion(string inputStringVersion)
        {
            return inputStringVersion.Contains(".") ? inputStringVersion : inputStringVersion + ".0";
        }
    }
}
