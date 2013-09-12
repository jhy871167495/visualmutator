﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualMutator.TestGeneration
{
    using System.IO;
    using System.Reflection;

    public class AppDomainCreator
    {
        public void Execute()
        {
            Console.WriteLine("Press enter to load plugin");
            Console.ReadLine();

          //  Assembly entryAsm = Assembly.GetEntryAssembly();
            
            AppDomainSetup domainSetup = new AppDomainSetup();
            AppDomain domain = AppDomain.CreateDomain("PluginDomain", null, domainSetup);
            var obj = domain.CreateInstanceFromAndUnwrap(@"C:\Users\SysOp\Documents\Visual Studio 2012\Projects\ConsoleApplication1\ConsoleApplication1\bin\Debug\ConsoleApplication1.exe", "ConsoleApplication1.Klasa1");

            var m = obj.GetType().GetMethod("Method1");

            Console.WriteLine("Plugin Loaded.");

        }

    }
}