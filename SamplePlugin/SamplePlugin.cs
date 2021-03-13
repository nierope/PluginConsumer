using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugins;

namespace SamplePlugin
{
    public class SamplePlugin : IPlugin
    {
        private string _name = "";

        public string Name { get => _name; set => _name = value; }

        public string Display()
        {
            return Name;
        }

        public void Dispose()
        {

        }

        public void Load(string name)
        {
            Name = name;
        }
    }
}
