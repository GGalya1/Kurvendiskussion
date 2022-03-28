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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kurvendiskussion
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Knopf_Click(object sender, RoutedEventArgs e)
        {
            double anstieg = Convert.ToDouble(EingM.Text);
            double yAchsenAbschnitt = Convert.ToDouble(EingB.Text);
            lineareFunktion f = new lineareFunktion(anstieg, yAchsenAbschnitt); //rufen so ein Konstruktor


            string AusgabeText = "Die Nullstelle ist x_n=" + f.berechneNullstelle();
            AusgabeText += "\nDer Schnittpunkt mit der xAchse liegt bei: (" + f.berechneNullstelle() + "/ 0)";
            Ausgabe.Text = AusgabeText;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double wert = Convert.ToDouble(WertX.Text);

            double anstieg = Convert.ToDouble(EingM.Text);
            double yAchsenAbschnitt = Convert.ToDouble(EingB.Text);
            lineareFunktion f = new lineareFunktion(anstieg, yAchsenAbschnitt);

            string AusgabeText = "Das berechnete y-Wert für gegebenen x-Wert ist = " + f.berechneFunktionswert(wert).ToString();

            Ausgabe.Text = AusgabeText;
        }
    }
}
