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
using lab7_2.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace lab7_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        private List<Icon> Icons;
       
        private ObservableCollection<Contact> Contacts;
        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icon>();
            Icons.Add(new Icon { Icons = "Assets/male-01.png" });
            Icons.Add(new Icon { Icons = "Assets/male-02.png" });
            Icons.Add(new Icon { Icons = "Assets/male-03.png" });
            Icons.Add(new Icon { Icons = "Assets/female-01.png" });
            Icons.Add(new Icon { Icons = "Assets/female-02.png" });
            Icons.Add(new Icon { Icons = "Assets/female-03.png" });
            

            Contacts = new ObservableCollection<Contact>();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icon)AvatarComboBox.SelectedValue).Icons;
            Contacts.Add(new Contact { FirstName = FirstNameTextBox.Text, LastName = LastnameTextBox.Text, Avatar = avatar });
            FirstNameTextBox.Text = "";
            LastnameTextBox.Text = "";
            AvatarComboBox.SelectedIndex = -1;
            FirstNameTextBox.Focus(FocusState.Programmatic);
        }
    }
}
