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

namespace lab5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class bai3 : Page
    {
        public bai3()
        {
            this.InitializeComponent();
        }

        private void MyCalerdarView_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            var selectedDates = sender.SelectedDates.Select(p => p.Date.Month.ToString() + "/" + p.Date.Day.ToString())
                .ToArray();

            var values = string.Join(", ", selectedDates);
            ClendarViewResultTextBlock.Text = values;
        }

        private void InnerFlyouButton_Click(object sender, RoutedEventArgs e)
        {
            Myflyout.Hide();
        }


        private string[] selectionitems = new string[]
            {"Feldinand", "Frank", "Frida", "Nigel", "Tag", "Tanya", "Tanner", "Todd"};

        private void MyAutoSuggesBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autoSuggestBox = (AutoSuggestBox)sender;
            var filtered = selectionitems.Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();

            autoSuggestBox.ItemsSource = filtered;
        }
    }
}
