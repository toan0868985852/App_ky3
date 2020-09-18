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
using Product.Model;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Product
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;

        private ObservableCollection<product> Products;
        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icon>();
            Icons.Add(new Icon { Icons = "Assets/1.png" });
            Icons.Add(new Icon { Icons = "Assets/2.png" });
            Icons.Add(new Icon { Icons = "Assets/3.png" });
            Icons.Add(new Icon { Icons = "Assets/4.png" });
            Icons.Add(new Icon { Icons = "Assets/5.png" });
            Icons.Add(new Icon { Icons = "Assets/6.png" });
            Icons.Add(new Icon { Icons = "Assets/7.png" });
            Icons.Add(new Icon { Icons = "Assets/9.png" });
            Icons.Add(new Icon { Icons = "Assets/10.png" });
            Icons.Add(new Icon { Icons = "Assets/11.png" });
            Icons.Add(new Icon { Icons = "Assets/12.png" });
            Icons.Add(new Icon { Icons = "Assets/13.png" });
          


            Products = new ObservableCollection<product>();
        }

 

        private void Add(object sender, RoutedEventArgs e)
        {


            Products.Add(new product { Producted = ProductTextBox.Text, Description = DescriptionTextBox.Text, Image = ((Icon)ImageComboBox.SelectedValue).Icons });
            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;
            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}
