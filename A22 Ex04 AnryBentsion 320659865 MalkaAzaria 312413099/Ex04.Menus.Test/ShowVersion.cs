using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowVersion : IExecuteOperation
    {
        public void ExecuteOperation()
        {
            Console.WriteLine("Version: 22.1.4.8930");
        }
    }
}
