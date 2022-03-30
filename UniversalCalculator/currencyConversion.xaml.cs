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
	public sealed partial class currencyConversion : Page
	{
		public currencyConversion()
		{
			this.InitializeComponent();
		}

		private void ConvertButton_Click(object sender, RoutedEventArgs e)
		{
			double amount;
			amount = double.Parse(AmountTextBox.Text);
			double conversion;


			if (FromComboBox.SelectedIndex == 0)
			{
				if (ToComboBox.SelectedIndex == 2)
				{

					conversion = CalcMoneytoPoundFromUS(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
				else if (ToComboBox.SelectedIndex == 1)
				{
					conversion = CalcMoneytoEuroFromUS(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
				else if (ToComboBox.SelectedIndex == 3)
				{
					conversion = CalcMoneyToRupeeFromUS(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
			}
			if (FromComboBox.SelectedIndex == 1)
			{
				if (ToComboBox.SelectedIndex == 0)
				{
					conversion = CalcMoneytoEuroFromUS(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
				else if (ToComboBox.SelectedIndex == 2)
				{
					conversion = CalcMoneyToPoundFromEuro(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
				else if (ToComboBox.SelectedIndex == 3)
				{
					conversion = CalcMoneyEuroToRupee(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
			}
			if (FromComboBox.SelectedIndex == 2)
			{
				if (ToComboBox.SelectedIndex == 0)
				{
					conversion = CalcPoundToUS(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
				else if (ToComboBox.SelectedIndex == 1)
				{
					conversion = CalcPoundToEuro(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
				else if (ToComboBox.SelectedIndex == 3)
				{
					conversion = CalcPoundToRupee(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
			}
			if (FromComboBox.SelectedIndex == 3)
			{
				if (ToComboBox.SelectedIndex == 0)
				{
					conversion = CalcRupeeToUS(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
				else if (ToComboBox.SelectedIndex == 1)
				{
					conversion = CalcRupeeToEuro(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
				else if (ToComboBox.SelectedIndex == 2)
				{
					conversion = CalcRupeeToPound(amount);
					ConversionTextBox.Text = conversion.ToString();
				}
			}
		}
		private double CalcMoneytoPoundFromUS(double amount)
		{
			const double pound = 0.72872436;
			double total;

			total = pound * amount;
			return total;
		}
		private double CalcMoneytoEuroFromUS(double amount)
		{
			const double euro = 0.85189982;
			double total;

			total = euro * amount;
			return total;
		}
		private double CalcMoneyToRupeeFromUS(double amount)
		{
			const double rupee = 74.257327;
			double total;

			total = rupee * amount;
			return total;
		}
		private double CalcMoneyToUSFromEuro(double amount)
		{
			const double us = 1.1739732;
			double total;

			total = us * amount;
			return total;
		}
		private double CalcMoneyToPoundFromEuro(double amount)
		{
			const double pound = 0.8556672;
			double total;

			total = pound * amount;
			return total;
		}
		private double CalcMoneyEuroToRupee(double amount)
		{
			const double rupee = 87.00755;
			double total;

			total = rupee * amount;
			return total;
		}
		private double CalcPoundToUS(double amount)
		{
			const double us = 1.371907;
			double total;

			total = us * amount;
			return total;
		}
		private double CalcPoundToEuro(double amount)
		{
			const double euro = 1.1686692;
			double total;

			total = euro * amount;
			return total;
		}
		private double CalcPoundToRupee(double amount)
		{
			const double rupee = 101.68635;
			double total;

			total = rupee * amount;
			return total;
		}
		private double CalcRupeeToUS(double amount)
		{
			const double us = 0.001492628;
			double total;

			total = us * amount;
			return total;
		}
		private double CalcRupeeToEuro(double amount)
		{
			const double euro = 0.0113492774;
			double total;

			total = euro * amount;
			return total;
		}
		private double CalcRupeeToPound(double amount)
		{
			const double pound = 0.098339397;
			double total;

			total = pound * amount;
			return total;
		}
	}
}

