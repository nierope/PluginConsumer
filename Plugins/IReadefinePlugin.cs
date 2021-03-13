using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins
{
    public interface IRedefinePlugin
    {
        string Name { get; set; }
        void Load(string name);
        void Dispose();
        string Display();
    }
}
