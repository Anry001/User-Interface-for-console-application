using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class CountCapitals : IExecuteOperation
    {
        public void ExecuteOperation()
        {
            Console.WriteLine("Please enter your sentence");
            string userInput = Console.ReadLine();
            int amountOfCapitals = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (char.IsUpper(userInput[i]))
                {
                    amountOfCapitals++;
                }
            }
            Console.WriteLine("There are {0} capitals in your sentence", amountOfCapitals);
        }
    }
}
