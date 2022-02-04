using System;

namespace Menus.Delegates
{
    public delegate void ClickUsersButtonOperation();

    public class MenuItem : MainMenu
    {        
        private event ClickUsersButtonOperation m_Clicked = null;

        public MenuItem() {}

        public void AddItems(int i_NumberOfItems)
        {
            for (int i = 0; i < i_NumberOfItems; i++)
            {
                this.Items.Add(new MenuItem());
            }
            CheckIfListEmpty(i_NumberOfItems: i_NumberOfItems);
        }

        public void AttachOperation(ClickUsersButtonOperation i_Operation)
        {
            m_Clicked += i_Operation;
            CheckIfListEmpty(0);
        }

        public void CheckIfListEmpty(int i_NumberOfItems)
        {
            if (i_NumberOfItems == 0)
            {
                CheckIfOperationAssigned();
            }
        }

        public virtual void OnClick()
        {
            if (m_Clicked != null)
            {
                m_Clicked.Invoke();
            }
            else
            {
                Console.WriteLine("assign an operation to {0}.", this.ItemTitle);
            }
        }

        public void CheckIfOperationAssigned()
        {
            if (m_Clicked == null)
            {
                Console.WriteLine("assign an operation to {0}.", this.ItemTitle);
            }
        }
    }
}
