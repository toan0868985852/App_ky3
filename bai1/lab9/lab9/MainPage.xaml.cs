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
using lab9.Model;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace lab9
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<IconBook> IconBooks;

        private ObservableCollection<Book> Books;
        public MainPage()
        {
            this.InitializeComponent();

            IconBooks = new List<IconBook>();
            IconBooks.Add(new IconBook { ImageBook = "Assets/1.png" });
            IconBooks.Add(new IconBook { ImageBook = "Assets/2.png" });
            IconBooks.Add(new IconBook { ImageBook = "Assets/3.png" });
            IconBooks.Add(new IconBook { ImageBook = "Assets/4.png" });
            IconBooks.Add(new IconBook { ImageBook = "Assets/5.png" });
            IconBooks.Add(new IconBook { ImageBook = "Assets/6.png" });
            IconBooks.Add(new IconBook { ImageBook = "Assets/7.png" });
            IconBooks.Add(new IconBook { ImageBook = "Assets/9.png" });
            IconBooks.Add(new IconBook { ImageBook = "Assets/10.png" });
            IconBooks.Add(new IconBook { ImageBook = "Assets/11.png" });
            IconBooks.Add(new IconBook { ImageBook = "Assets/12.png" });
            IconBooks.Add(new IconBook { ImageBook = "Assets/13.png" });
           
           

            Books = new ObservableCollection<Book>();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            string ImageBooks = ((IconBook)ImageBookComboBox.SelectedValue).ImageBook;
            double priceBook = Double.Parse(PriceTextBox.Text);
            Books.Add(new Book { Title = TitleTextBoox.Text, Author = AuthorTextBox.Text, Price = priceBook, Image = ImageBooks });
            TitleTextBoox.Text = "";
            AuthorTextBox.Text = "";
            PriceTextBox.Text = "";
            ImageBookComboBox.SelectedIndex = -1;
            TitleTextBoox.Focus(FocusState.Programmatic);
        }
    }
}
