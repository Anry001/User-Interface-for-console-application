using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : MainMenu
    {
        private IExecuteOperation m_OperationObserver = null;

        public MenuItem() {}

        public void AddItems(int i_NumberOfItems) 
        {
            for (int i = 0; i < i_NumberOfItems; i++)
            {
                this.Items.Add(new MenuItem());
            }
            CheckIfItemListEmpty(i_NumberOfItems: i_NumberOfItems);
        }

        public void AttachOperation(IExecuteOperation i_Operation)
        {
            m_OperationObserver = i_Operation;
            this.AddItems(0);
        }

        public void CheckIfItemListEmpty(int i_NumberOfItems)
        {
            if (i_NumberOfItems == 0)
            {
                CheckIfOperationAssigned();
            }
        }

        public void ExecuteOperation()
        {
            if (m_OperationObserver != null)
            {
                m_OperationObserver.ExecuteOperation();
            }
            else
            {
                Console.WriteLine("assign an operation to {0}.", this.ItemTitle);
            }

        }

        public void CheckIfOperationAssigned()
        {
            if (m_OperationObserver == null)
            {
                Console.WriteLine("assign an operation to {0}.", this.ItemTitle);
            }
        }
    }
}

