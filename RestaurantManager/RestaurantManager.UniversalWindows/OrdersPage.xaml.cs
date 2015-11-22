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
using RestaurantManager.UniversalWindows.RestaurantManager.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RestaurantManager.UniversalWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrdersPage : Page
    {

        public OrdersPage()
        {
            this.InitializeComponent();
        }

        private void homeClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage),DataContext);
        }

        private void addToOrder(object sender, RoutedEventArgs e)
        {
            DataManager d = (DataManager)DataContext;
            var obj = MenuList.SelectedItems.ToArray();

            foreach (var item in obj)
            {
                d.CurrentlySelectedMenuItems.Add(item.ToString());
            }
        }

        private void submitOrder(object sender, RoutedEventArgs e)
        {

            DataManager d = (DataManager)DataContext;
            var obj = OrderList.Items.ToArray();
            string r = string.Join(",", obj);
            r = "Your order of \""+ r +"\" is been added";
            d.OrderItems.Add(r);
            test.Text = r;
        }
    }
}
