using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DJB.Views
    //TODO: when page is left and then navigated back to from another page, all of the entered information is gone. Need to persist.
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FinancialsPage : ContentPage
	{
		public FinancialsPage ()
		{
			InitializeComponent ();
		}

        private void TxtIncome2_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { newAmountEntered(); }
        private void TxtIncome3_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { newAmountEntered(); }
        private void TxtIncome4_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { newAmountEntered(); }
        private void TxtIncome5_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { newAmountEntered(); }
        private void TxtIncome6_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { newAmountEntered(); }
        private void TxtExpense1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { newAmountEntered(); }
        private void TxtExpense2_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { newAmountEntered(); }
        private void TxtExpense3_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { newAmountEntered(); }
        private void TxtExpense4_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { newAmountEntered(); }
        private void TxtExpense5_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { newAmountEntered(); }
        private void TxtExpense6_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        { newAmountEntered(); }

        private void newAmountEntered()
        {
            var incomes = new List<double>();
            var expenses = new List<double>();
            double numberInput = 0;
            double totalIncome = 0;
            double totalExpenses = 0;
            double totalProfit = 0;
            var incorrectColor = Color.LightPink;

            // get/add up all income
            incomes.Add(double.Parse(lblMonthlyDuesIncome.Text));

            if (Double.TryParse(txtIncome2.Text, out numberInput))
            {
                txtIncome2.BackgroundColor = Color.Transparent;
                incomes.Add(numberInput);
            }
            else { txtIncome2.BackgroundColor = incorrectColor; }

            if (Double.TryParse(txtIncome3.Text, out numberInput))
            {
                txtIncome3.BackgroundColor = Color.Transparent;
                incomes.Add(numberInput);
            }
            else { txtIncome3.BackgroundColor = incorrectColor; }

            if (Double.TryParse(txtIncome4.Text, out numberInput))
            {
                txtIncome4.BackgroundColor = Color.Transparent;
                incomes.Add(numberInput);
            }
            else { txtIncome4.BackgroundColor = incorrectColor; }

            if (Double.TryParse(txtIncome5.Text, out numberInput))
            {
                txtIncome5.BackgroundColor = Color.Transparent;
                incomes.Add(numberInput);
            }
            else { txtIncome5.BackgroundColor = incorrectColor; }

            if (Double.TryParse(txtIncome6.Text, out numberInput))
            {
                txtIncome6.BackgroundColor = Color.Transparent;
                incomes.Add(numberInput);
            }
            else { txtIncome6.BackgroundColor = incorrectColor; }

            foreach (var item in incomes)
            {
                totalIncome = (totalIncome + item);
            }

            // get/add up all expenses
            if (Double.TryParse(txtExpense1.Text, out numberInput))
            {
                txtExpense1.BackgroundColor = Color.Transparent;
                expenses.Add(numberInput);
            }
            else { txtExpense1.BackgroundColor = incorrectColor; }

            if (Double.TryParse(txtExpense2.Text, out numberInput))
            {
                txtExpense2.BackgroundColor = Color.Transparent;
                expenses.Add(numberInput);
            }
            else { txtExpense2.BackgroundColor = incorrectColor; }

            if (Double.TryParse(txtExpense3.Text, out numberInput))
            {
                txtExpense3.BackgroundColor = Color.Transparent;
                expenses.Add(numberInput);
            }
            else { txtExpense3.BackgroundColor = incorrectColor; }

            if (Double.TryParse(txtExpense4.Text, out numberInput))
            {
                txtExpense4.BackgroundColor = Color.Transparent;
                expenses.Add(numberInput);
            }
            else { txtExpense4.BackgroundColor = incorrectColor; }

            if (Double.TryParse(txtExpense5.Text, out numberInput))
            {
                txtExpense5.BackgroundColor = Color.Transparent;
                expenses.Add(numberInput);
            }
            else { txtExpense5.BackgroundColor = incorrectColor; }

            if (Double.TryParse(txtExpense6.Text, out numberInput))
            {
                txtExpense6.BackgroundColor = Color.Transparent;
                expenses.Add(numberInput);
            }
            else { txtExpense6.BackgroundColor = incorrectColor; }

            foreach (var item in expenses)
            {
                totalExpenses = (totalExpenses + item);
            }

            //display totals
            lblTotalIncome.Text = "$" + totalIncome.ToString();
            lblTotalExpenses.Text = "$" + totalExpenses.ToString();
            totalProfit = (totalIncome - totalExpenses);
            lblTotalProfit.Text = "$" + totalProfit.ToString();
            if (totalProfit <= 0)
            {
                lblTotalProfit.TextColor = Color.Red;
            }
            else
            {
                lblTotalProfit.TextColor = Color.LightGreen;
            }
        }

    
    }
}