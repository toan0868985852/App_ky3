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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace lab7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        private ObservableCollection<String> obs = new ObservableCollection<String>();

        public BlankPage1()
        {
            this.InitializeComponent();
               listview.ItemsSource = obs;
        }
       

        private void Add(object sender, RoutedEventArgs e)
        {
            obs.Add($"Mục mới thêm {obs.Count + 1}");
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            if (obs.Count > 0)
                obs.RemoveAt(obs.Count - 1);
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            obs.Clear();
        }
    }
}
