using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowTime : IExecuteOperation
    {
        public void ExecuteOperation()
        {
            Console.WriteLine("The time is: {0}", DateTime.Now.TimeOfDay);
        }
    }
}
