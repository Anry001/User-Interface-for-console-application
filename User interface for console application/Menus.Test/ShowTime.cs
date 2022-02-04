using System;
using Menus.Interfaces;

namespace Menus.TestDemonstration
{
    class ShowTime : IExecuteOperation
    {
        public void ExecuteOperation()
        {
            Console.WriteLine("The time is: {0}", DateTime.Now.TimeOfDay);
        }
    }
}
