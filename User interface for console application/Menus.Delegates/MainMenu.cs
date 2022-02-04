using System.Collections.Generic;

namespace Menus.Delegates
{
    public class MainMenu
    {
        private string m_ItemTitle = string.Empty;
        private List<MenuItem> m_Items = new List<MenuItem>();

        public MainMenu(int i_NumberOfItems)
        {
            for (int i = 0; i < i_NumberOfItems; i++)
            {
                m_Items.Add(new MenuItem());
            }
        }

        public MainMenu() {}

        public string ItemTitle
        {
            get { return m_ItemTitle; }
            set { m_ItemTitle = value; }
        }

        public List<MenuItem> Items
        {
            get { return m_Items; }
        }

        public void Show()
        {
            new MenuPresentor(m_Items, ItemTitle);
        }
    }
}
