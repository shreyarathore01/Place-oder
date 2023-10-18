using System;
using System.Collections.Generic;
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
using FyersAPI;

namespace oderapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FyersAPIHelper fyersAPIHelper;

        public MainWindow()
        {
            InitializeComponent();
            fyersAPIHelper = new FyersAPIHelper();
        }
        private void PlaceOrder_Click(object sender, RoutedEventArgs e)
        {
            // Create a new order object.
            Order order = new Order();

            // Populate the order object with the user's input.
            order.Symbol = symbolComboBox.SelectedItem.ToString();
            order.Side = (Side)Enum.Parse(typeof(Side), sideComboBox.SelectedIndex.ToString());
            order.Qty = Convert.ToInt32(quantityTextBox.Text);

            // Place the order using the Fyers API.
            string response = fyersAPIHelper.PlaceOrder(order);

            // Display the response in the logs tab.
            textBoxLogs.Text += $"Request: {order}\nResponse: {response}\n";
        }
    }
}
