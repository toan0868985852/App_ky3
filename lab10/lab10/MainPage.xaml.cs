using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using lab10.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace lab10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Home> Homes;

        public MainPage()
        {
            this.InitializeComponent();
            Homes = new ObservableCollection<Home>();
            TitleTextBlock.Text = "Home";
            Home.IsSelected = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                NewManager.GetNews("Home", Homes);
                TitleTextBlock.Text = "Home";
            }
            else if (Game.IsSelected)
            {
                NewManager.GetNews("Game", Homes);
                TitleTextBlock.Text = "Game";
            }
        }

        private void page_loaded(object sender, RoutedEventArgs e)
        {
            Home.IsSelected = true;
        }
    }
}
