using System;
using System.Collections.Generic;
using System.IO;
using Plugins;

namespace PluginConsumer
{
    public class Program
    {
        static private Dictionary<string, IPlugin> _Plugins = new Dictionary<string, IPlugin>();

        static void Main(string[] args)
        {
            LoadPlugins();
        }


        static void LoadPlugins()
        {
            
            string ServerPath = @"c:\temp\plugins";
            dynamic Plugins = Directory.GetFiles(ServerPath,"*.dll");



            foreach (string PluginPath in Plugins)
            {
                dynamic Assembly = System.Reflection.Assembly.LoadFile(PluginPath);

                Type[] types = Assembly.GetTypes();
                //IPlugin MyPlugin = null;

                foreach (Type typeThis in types)
                {
                    if (typeThis.GetInterface("IPlugin") != null)
                    {

                        dynamic MyPlugin = Activator.CreateInstance(typeThis);
                        MyPlugin.Load("Ewout");
                        _Plugins.Add(typeThis.ToString(), MyPlugin);
                        MyPlugin.Name = "Jan";
                        string strName = MyPlugin.Display();
                    }

                }
            }

        }
    }
}
