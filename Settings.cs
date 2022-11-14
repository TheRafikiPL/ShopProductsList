using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProductsList
{
    internal class Settings
    {
        public static readonly string currentPath = $"{FileSystem.Current.AppDataDirectory}\\current.txt";
        public static readonly string archivesPath = $"{FileSystem.Current.AppDataDirectory}\\archives";

        public static void CheckFileSystem()
        {
            if(!Directory.Exists(archivesPath))
            {
                Directory.CreateDirectory(archivesPath);
            }
            if (!File.Exists(currentPath))
            {
                File.Create(currentPath);
            }
        }
    }
}
