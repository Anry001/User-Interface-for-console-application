using System;
using Menus.Interfaces;

namespace Menus.TestDemonstration
{
    class ShowVersion : IExecuteOperation
    {
        public void ExecuteOperation()
        {
            Console.WriteLine("Version: 22.1.4.8930");
        }
    }
}
