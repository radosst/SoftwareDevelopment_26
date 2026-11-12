using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace github_zadacha
{
    internal class FileStorage
    {
        private readonly string path;

        public FileStorage(string path)
        {
            this.path = path;
        }
    }
}
