using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DJB.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();

        }

      

        private async void BtnLogin_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AttendancePage());
        }

        private async void LblSignup_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignupPage());
        } 
    }
}