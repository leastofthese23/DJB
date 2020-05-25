using DJB.Controls;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace DJB.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StudentsPage : ContentPage
	{
		public StudentsPage ()
		{
			InitializeComponent ();

            monthsPicker.ItemsSource = Lists.MonthsList();
            monthsPicker.SelectedIndex = 8;

            activePicker.ItemsSource = Lists.TrueFalse();
            activePicker.SelectedIndex = 0;

            studentPicker.ItemsSource = Lists.ActiveStudents();
            studentPicker.SelectedIndex = 6;

            genderPicker.ItemsSource = Lists.GenderList();
            genderPicker.SelectedIndex = 0;

            statePicker.ItemsSource = Lists.StateAbbList();
            statePicker.SelectedIndex = 46;

            rankPicker.ItemsSource = Ranks.RanksList();
            rankPicker.SelectedIndex = 12;

            var listOfRankReq = Lists.RankReq("Sandan - Black III");
            RankReqListView.ItemsSource = listOfRankReq;
            RankReqListView.HeightRequest = (listOfRankReq.Count * 40);
        }
	}
}