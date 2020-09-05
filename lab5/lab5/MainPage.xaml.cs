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

namespace lab5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MychecBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CheckBlockResultTextBox.Text = MychecBox.IsChecked.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtontextBolock.Text = (bool)YesradioButton.IsChecked ? "Yes" : "No";
        }

        private void Combox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxResultTextBlock == null) return;

            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            ComboBoxResultTextBlock.Text = item.Content.ToString();
        }

        private void ListBox_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = MylistBox.Items.Cast<ListBoxItem>()
                .Where(p => p.IsSelected)
                .Select(t => t.Content.ToString())
                .ToArray();

            ListBoxResultTextBox.Text = String.Join(", ", selectedItems);
        }

        private void MyToggleBytton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButtonResultTextBlock.Text = MyToggleButton.IsChecked.ToString();
        }

        private void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {

            if ((bool)YesradioButton2.IsChecked)
            {
                RadioButtontextBolock2.Text = "Nam";
            }
            else if ((bool)NoradioButton2.IsChecked)
            {
                RadioButtontextBolock2.Text = "Nu";
            }
            else
            {
                RadioButtontextBolock2.Text = "Khac";
            }
        }
    }
}
