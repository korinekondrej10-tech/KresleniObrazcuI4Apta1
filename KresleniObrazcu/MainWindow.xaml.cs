using KresleniObrazcu.Tridy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KresleniObrazcu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Obrazec> obrazce = new List<Obrazec>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Platno_MouseLeftButtonDown(
            object sender, MouseButtonEventArgs e)
        {
            // Zjištění souřadnic kliknutí
            Point pozice = e.GetPosition(platno);

            double x = pozice.X;
            double y = pozice.Y;

            // Výběr typu obrazce
            int typ = cmbObrazec.SelectedIndex;

            Obrazec obrazec;

            switch (typ)
            {
                case 0:
                    obrazec = new Obdelnik();
                    break;

                case 1:
                    obrazec = new Elipsa();
                    break;

                case 2:
                    obrazec = new Trojuhelnik();
                    break;

                default:
                    return;
            }

            // Nastavení souřadnic
            obrazec.X = x;
            obrazec.Y = y;

            // Nastavení tloušťky čáry
            ComboBoxItem polozkaTloustka =
                (ComboBoxItem)cmbTloustka.SelectedItem;

            obrazec.TloustkaCary =
                double.Parse(polozkaTloustka.Content.ToString()!);

            // Nastavení barvy výplně
            int barva = cmbVypln.SelectedIndex;

            switch (barva)
            {
                case 0:
                    obrazec.Vypln = Brushes.LightBlue;
                    break;

                case 1:
                    obrazec.Vypln = Brushes.LightGreen;
                    break;

                case 2:
                    obrazec.Vypln = Brushes.Yellow;
                    break;

                case 3:
                    obrazec.Vypln = Brushes.LightCoral;
                    break;

                default:
                    obrazec.Vypln = Brushes.Transparent;
                    break;
            }

            // Vykreslení obrazce
            obrazec.Vykresli(platno);

            // Uložení objektu do kolekce
            obrazce.Add(obrazec);

            // Výpis do seznamu
            lstObrazce.Items.Add(
                $"{obrazec.GetType().Name} " +
                $"X: {x:F0}, Y: {y:F0}, " +
                $"čára: {obrazec.TloustkaCary}");
        }

        private void BtnSmazat_Click(
            object sender, RoutedEventArgs e)
        {
            platno.Children.Clear();
            obrazce.Clear();
            lstObrazce.Items.Clear();
        }
    }
}