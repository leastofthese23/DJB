using DJB.DataModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DJB.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AttendancePage : ContentPage
	{
		public AttendancePage ()
		{
			InitializeComponent ();

            var stdList = new List<string>();
            stdList.Add("Adam Wright Sirkis");
            stdList.Add("Alyssa Webb");
            stdList.Add("Angelina Kukkonnen");
            stdList.Add("Anthony Pirot");
            stdList.Add("Diana Reynolds");
            stdList.Add("Erik Anderson");
            stdList.Add("Gabe Fitzpatrick");

            var monthList = new List<String>();
            monthList.Add("January");
            monthList.Add("February");
            monthList.Add("March");
            monthList.Add("April");
            monthList.Add("May");
            monthList.Add("June");
            monthList.Add("July");
            monthList.Add("August");
            monthList.Add("September");
            monthList.Add("October");
            monthList.Add("November");
            monthList.Add("December");

            var yearList = new List<String>();
            yearList.Add("2021");
            yearList.Add("2020");
            yearList.Add("2019");
            yearList.Add("2018");
            yearList.Add("2017");
            yearList.Add("2016");


            studentPickerA.ItemsSource = stdList;
            studentPickerA.Title = "Add a student";
            studentPickerA.SelectedIndex = 0;

            studentPickerR.ItemsSource = stdList;
            studentPickerR.Title = "Remove a student";
            studentPickerR.SelectedIndex = 1;

            studentPickerV.ItemsSource = stdList;
            studentPickerV.Title = "Select a student";

            monthPicker.ItemsSource = monthList;
            monthPicker.Title = "Select Month";
            monthPicker.SelectedIndex = 5;

            yearPicker.ItemsSource = yearList;
            yearPicker.Title = "Select Year";
            yearPicker.SelectedIndex = 1;

            ObservableCollection<DateStudentModel> attendanceRecords = new ObservableCollection<DateStudentModel>();

            attendanceRecords.Add(new DateStudentModel { date = "06/12/2020", name = "Israel McCulley" });
            attendanceRecords.Add(new DateStudentModel { date = "06/12/2020", name = "Max Puls" });
            attendanceRecords.Add(new DateStudentModel { date = "06/14/2020", name = "Diana Reynolds" });
            attendanceRecords.Add(new DateStudentModel { date = "06/14/2020", name = "Rick Vogt" });
            attendanceRecords.Add(new DateStudentModel { date = "06/14/2020", name = "Adam Wright Sirkis" });
            attendanceRecords.Add(new DateStudentModel { date = "06/20/2020", name = "Gabe Fitzpatrick" });
            attendanceRecords.Add(new DateStudentModel { date = "06/20/2020", name = "Skyler Fitzpatrick" });
            attendanceRecords.Add(new DateStudentModel { date = "06/20/2020", name = "Rick Vogt" });
            attendanceRecords.Add(new DateStudentModel { date = "06/21/2020", name = "Nicole Clements" });
            attendanceRecords.Add(new DateStudentModel { date = "06/21/2020", name = "Rick Vogt" });
            attendanceRecords.Add(new DateStudentModel { date = "06/21/2020", name = "Skyler Fitzpatrick" });
            attendanceRecords.Add(new DateStudentModel { date = "06/21/2020", name = "Chuck Norris" });
            attendanceRecords.Add(new DateStudentModel { date = "06/21/2020", name = "Troy Donaldson" });
            attendanceRecords.Add(new DateStudentModel { date = "06/22/2020", name = "Rick Vogt" });

            lvAttendance.ItemsSource = attendanceRecords;
        }
	}
}