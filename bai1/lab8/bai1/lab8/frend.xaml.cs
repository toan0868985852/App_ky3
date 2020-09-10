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
using lab8.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace lab8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class frend : Page
    {

        private List<Frend> frends;

        public frend()
        {
            this.InitializeComponent();
            frends = FrendManager.GetFrends();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frend = (Frend)e.ClickedItem;
            ResultTextBock.Text = "You selected " + frend.Address;
        }
    }
}
