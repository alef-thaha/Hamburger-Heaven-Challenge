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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App11
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            backbutton.Visibility = Visibility.Collapsed;
            textblock.Text = "Financial";
            myframe.Navigate(typeof(Financial));
            Financial.IsSelected = true;
        }

        private void hamburgerbutton_Click(object sender, RoutedEventArgs e)
        {
            mysplitview.IsPaneOpen = !mysplitview.IsPaneOpen;
        }
        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            if (myframe.CanGoBack)
            {
                myframe.GoBack();
                Financial.IsSelected = true;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Financial.IsSelected)
            {
                backbutton.Visibility = Visibility.Collapsed;
                myframe.Navigate(typeof(Financial));
                textblock.Text = "Financial";
            }
           else if (Food.IsSelected)
            {
                backbutton.Visibility = Visibility.Visible;
                myframe.Navigate(typeof(Food));
                textblock.Text = "Food";
            }
        }

        
    }
}
