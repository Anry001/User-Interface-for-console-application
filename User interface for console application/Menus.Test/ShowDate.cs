using System;
using Menus.Interfaces;

namespace Menus.TestDemonstration
{
    public class ShowDate : IExecuteOperation
    {
        public void ExecuteOperation()
        {
            Console.WriteLine("The date is: {0}", DateTime.Now.Date);
        }
    }
}
