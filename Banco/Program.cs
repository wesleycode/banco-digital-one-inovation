using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Banco.model;
using Banco.view;

namespace Banco
{
    class Program
    {

        private static void Start()
        {
            new Menu();
        }
        
        static void Main(string[] args)
        {
            // To translate application to english uncomment the line below //
             CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            
            Start();

        }
    }
}