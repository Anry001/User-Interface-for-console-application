using System;
using Menus.Interfaces;

namespace Menus.TestDemonstration
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
