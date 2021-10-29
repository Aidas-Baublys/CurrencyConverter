using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyConverter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindCurrency();
        }

        private void BindCurrency()
        {
            DataTable currency = new DataTable();
            currency.Columns.Add("Text");
            currency.Columns.Add("Value");

            currency.Rows.Add("--SELECT--", 0);
            currency.Rows.Add("INR", 1);
            currency.Rows.Add("USD", 75);
            currency.Rows.Add("EUR", 85);
            currency.Rows.Add("SAR", 20);
            currency.Rows.Add("POUND", 5);
            currency.Rows.Add("DEM", 43);

            cmbFromCurrency.ItemsSource = currency.DefaultView;
            cmbFromCurrency.DisplayMemberPath = "Text";
            cmbFromCurrency.SelectedValuePath = "Value";
            cmbFromCurrency.SelectedIndex = 0;

            cmbToCurrency.ItemsSource = currency.DefaultView;
            cmbToCurrency.DisplayMemberPath = "Text";
            cmbToCurrency.SelectedValuePath = "Value";
            cmbToCurrency.SelectedIndex = 0;
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            lblCurrency.Content = "Kurwa";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            lblCurrency.Content = "Suka";
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
