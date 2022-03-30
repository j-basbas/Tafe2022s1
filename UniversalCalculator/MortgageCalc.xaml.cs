using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalc : Page
	{
		public MortgageCalc()
		{
			this.InitializeComponent();
		}

		private void calculateButton_Click(object sender, RoutedEventArgs e)
		{
			double principal;
			double years;
			double months;
			double yearlyInterestRate;
			double monthlyInterestRate;
			double monthlyRepayment;
			double totalMonths;

			principal = double.Parse(principalTextBox.Text);
			years = double.Parse(yearsTextBox.Text);
			yearlyInterestRate = double.Parse(yearlyInterestRateTextBox.Text);
			months = double.Parse(andMonthsTextBox.Text);
			totalMonths = (years * 12) + months;

			monthlyInterestRate = (yearlyInterestRate / 100) / 12;
			monthlyRepayment = principal * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, totalMonths)) / (Math.Pow(1 + monthlyInterestRate, totalMonths) - 1);
			monthlyInterestRateTextBox.Text = monthlyInterestRate.ToString("0.00##");
			monthlyRepaymentTextBox.Text = monthlyRepayment.ToString("C");
		}
	}
}
