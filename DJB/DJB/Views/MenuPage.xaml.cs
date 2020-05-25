
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Threading.Tasks;

namespace DJB.Views
{
    public partial class MenuPage : MasterDetailPage
    {
        public List<MenuItem> menuItems { get; set; }
       
        public MenuPage()
        {
            MasterBehavior = MasterBehavior.Popover;
            InitializeComponent();

            menuItems = new List<MenuItem>();

            var page1 = new MenuItem() { Title = "Attendance", titleImage = "headerattendance.png", TargetType = typeof(AttendancePage) };
            var page2 = new MenuItem() { Title = "Students", titleImage = "headerstudents.png", TargetType = typeof(StudentsPage) };
            var page3 = new MenuItem() { Title = "Rank Req", titleImage = "headerrankreq.png", TargetType = typeof(RankReqPage) };
            var page4 = new MenuItem() { Title = "Financials", titleImage = "headerfinancials.png", TargetType = typeof(FinancialsPage) };
            var page5 = new MenuItem() { Title = "Calendar", titleImage = "headercalendar.png", hyperlink = "https://www.cascademaa.com/calendar" };
            var page6 = new MenuItem() { Title = "Messaging", titleImage = "headermessaging.png", TargetType = typeof(MessagingPage) };
            var page7 = new MenuItem() { Title = "Forms", titleImage = "headerforms.png", TargetType = typeof(FormsPage) };
            var page8 = new MenuItem() { Title = "Certs", titleImage = "headercerts.png", TargetType = typeof(CertsPage) };
            var page9 = new MenuItem() { Title = "Settings", titleImage = "settingsicon.png", TargetType = typeof(SettingsPage) };

            
            // add menu items to menuList
            menuItems.Add(page1);
            menuItems.Add(page2);
            menuItems.Add(page3);
            menuItems.Add(page4);
            menuItems.Add(page5);
            menuItems.Add(page6);
            menuItems.Add(page7);
            menuItems.Add(page8);
            menuItems.Add(page9);
      

            // set list in .xaml = to list here in .xaml.cs
            menuList.ItemsSource = menuItems;

            // initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(AttendancePage)));

            this.BindingContext = new
            {
                Header = "",
                Footer = ""
            };

        }


        private void MenuList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MenuItem)e.SelectedItem;
            var title = item.Title;
            if (title == "Calendar")
            {
                OpenBrowser(item.hyperlink);
            }
            else
            {
                Type page = item.TargetType;
                Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                IsPresented = false;
            }
        }

        void OpenBrowser(string uri)
        {
            Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        
    }

}