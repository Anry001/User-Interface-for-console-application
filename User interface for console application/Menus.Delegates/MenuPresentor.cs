using System;
using System.Collections.Generic;
using System.Linq;

namespace Menus.Delegates
{
    public class MenuPresentor
    {
        private readonly int r_HashCode = 0;

        public MenuPresentor(List<MenuItem> i_Items, string i_Title)
        {
            r_HashCode = i_Items.GetHashCode();
            ShowMenu(i_Items, i_Title);
        }

        public void ShowMenu(List<MenuItem> i_Items, string i_Title)
        {
            bool isNotBackOrExitButton = true;

            while (isNotBackOrExitButton)
            {
                Console.WriteLine("**{0}**", i_Title);
                Console.WriteLine("-----------------------");

                for (int i = 0; i < i_Items.Count; i++)
                {
                    Console.WriteLine("{0} -> {1}", i + 1, i_Items[i].ItemTitle);
                }

                eExitOrBackButton exitOrBackButton = checkIfExitOrBackButton(i_Items.GetHashCode());
                Console.WriteLine("0 -> {0}", exitOrBackButton);
                Console.WriteLine("-----------------------");
                Console.WriteLine("Enter your request: ({0} to {1} or press '0' to {2}){3}", 1, i_Items.Count, exitOrBackButton, Environment.NewLine);
                string usersInput = Console.ReadLine();
                int validUserInput = int.Parse(checkIsUserGuessValid(usersInput, i_Items));

                if (validUserInput == 0)
                {
                    Console.Clear();
                    isNotBackOrExitButton = false;
                }
                else if (checkIfCurrentListEmpty(i_Items[validUserInput - 1].Items.Count) == true)
                {
                    i_Items[validUserInput - 1].OnClick();
                    Console.WriteLine($"{Environment.NewLine}press any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    ShowMenu(i_Items[validUserInput - 1].Items, i_Items[validUserInput - 1].ItemTitle);
                }
            }

            return;
        }

        private static bool checkIfCurrentListEmpty(int i_NumberOfItems)
        {
            bool o_IsEmptyList = i_NumberOfItems == 0;

            return o_IsEmptyList;
        }

        private eExitOrBackButton checkIfExitOrBackButton(int i_CurrentListHashCode)
        {
            eExitOrBackButton exitOrBackButton = i_CurrentListHashCode == r_HashCode ? eExitOrBackButton.Exit : eExitOrBackButton.Back;

            return exitOrBackButton;
        }

        private static bool checkUserGuessIsNumber(string i_UserInput)
        {
            bool isUserInputNumber = i_UserInput.All(char.IsDigit);

            if (i_UserInput == "")
            {
                isUserInputNumber = false;
            }

            return isUserInputNumber;
        }
        
        private static bool checkNumberOfGuessesInRange(string i_UserNumberOfGuesses, List<MenuItem> i_Items)
        {
            int userNumberOfGuesses = int.Parse(i_UserNumberOfGuesses);
            bool o_isNumberInRange = userNumberOfGuesses >= 0 && userNumberOfGuesses <= i_Items.Count;

            return o_isNumberInRange;
        }

        private static string checkIsUserGuessValid(string i_usersInput, List<MenuItem> i_Items)
        {
            while (!checkUserGuessIsNumber(i_usersInput) || !checkNumberOfGuessesInRange(i_usersInput, i_Items))
            {
                Console.WriteLine("Input error, Please enter valid number between 1-{0} or '0'", i_Items.Count);
                i_usersInput = Console.ReadLine();
            }

            return i_usersInput;
        }

        private enum eExitOrBackButton
        {
            Exit,
            Back
        }
    }
}
