using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Text.Json;
using System.IO;


namespace SEW_Projekt
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        List<Kunde> kunden = new List<Kunde>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"../../../Kundendaten.json";
            Random r = new Random();
            string randnum = Convert.ToString(r.Next(1000,10000));
            Adresse adresse= new Adresse(TextBox_Strasse.Text, TextBox_Hausnummer.Text, TextBox_Stadt.Text, TextBox_PLZ.Text, TextBox_Land.Text);
            Kunde kunde = new Kunde(TextBox_Vorname.Text, TextBox_Nachname.Text, Convert.ToString(TextBox_Verfuegernr.Text), TextBox_Kennwort.Text, DatePicker_geb.SelectedDate.Value, adresse);
            Konto konto = new Konto(randnum, kunde, 0, DateTime.Now);
            kunden.Add(kunde);
            string jsonsString = JsonSerializer.Serialize(kunden);
            File.AppendAllText(path, jsonsString);
            this.Close();
        }
    }
}
