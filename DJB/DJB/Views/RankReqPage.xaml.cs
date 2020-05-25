using DJB.Controls;
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
	public partial class RankReqPage : ContentPage
	{
		public RankReqPage ()
		{
			InitializeComponent ();

            pickerRanks.ItemsSource = Ranks.RanksListMinus1();
            pickerRanks.SelectedIndex = 0;
            lblRankTitle.Text = "Requirements to promote to 9th Kyu - Blue I";
        }

        private void PickerRanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userSelectedRank = pickerRanks.SelectedItem.ToString();
            string nextRank = Ranks.GetNextRank(userSelectedRank);
            lblRankTitle.Text = userSelectedRank + " promote to " + nextRank;
            RankReqListView.ItemsSource = Lists.RankReq(userSelectedRank);
        }
    }
}