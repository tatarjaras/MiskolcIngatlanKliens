using MiskolcIngatlanKliens.Models;
using MiskolcIngatlanKliens.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.WebRequestMethods;

namespace MiskolcIngatlanKliens.Windows
{
    /// <summary>
    /// Interaction logic for IngatlanokWindow.xaml
    /// </summary>
    public partial class IngatlanokWindow : Window
    {

        private HttpClient sajatKliens = new HttpClient()
        {
            BaseAddress=new Uri("http://localhost:5000")
        };

        private List<Ingatlan> ingatlanok = new List<Ingatlan>();
        public IngatlanokWindow()
        {
            InitializeComponent();
            Feltolt();
        }

        private async void BtnUj_Click(object sender, RoutedEventArgs e)
        {
            Ingatlan
            await IngatlanService.InserNew(sajatKliens,)
        }

        private void BtnModosit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btntorol_Click(object sender, RoutedEventArgs e)
        {

        }
        private async void Feltolt()
        {
            ingatlanok=await IngatlanService.GetAll(sajatKliens);
            Task.Delay(1000).Wait();
            dgrIngatlanok.ItemsSource=ingatlanok;
        }

    }
}
