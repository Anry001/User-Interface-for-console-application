using Menus.Delegates;

namespace Menus.TestDemonstration
{
    public class MenuUsingDelegate
    {
        public static void RunMenuViaDelegate()
        {
            MainMenu m_MainMenu = new MainMenu(2);
            m_MainMenu.ItemTitle = "Delegates Main Menu";
            m_MainMenu.Items[0].ItemTitle = "Version and Capitals";
            m_MainMenu.Items[1].ItemTitle = "Show Date/Time";
            m_MainMenu.Items[0].AddItems(2);
            m_MainMenu.Items[0].Items[0].ItemTitle = "Count Capitals";
            m_MainMenu.Items[0].Items[1].ItemTitle = "Show Version";
            m_MainMenu.Items[0].Items[0].AttachOperation(new CountCapitals().ExecuteOperation);
            m_MainMenu.Items[0].Items[1].AttachOperation(new ShowVersion().ExecuteOperation);
            m_MainMenu.Items[1].AddItems(2);
            m_MainMenu.Items[1].Items[0].ItemTitle = "Show Date";
            m_MainMenu.Items[1].Items[1].ItemTitle = "Show Time";
            m_MainMenu.Items[1].Items[0].AttachOperation(new ShowDate().ExecuteOperation);
            m_MainMenu.Items[1].Items[1].AttachOperation(new ShowTime().ExecuteOperation);
            m_MainMenu.Show();
        }
    }
}
