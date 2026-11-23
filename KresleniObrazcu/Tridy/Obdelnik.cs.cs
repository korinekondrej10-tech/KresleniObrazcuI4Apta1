using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KresleniObrazcu.Tridy
{
    public class Obdelnik : Obrazec
    {
        public override void Vykresli(Canvas platno)
        {
            Rectangle obdelnik = new Rectangle();

            obdelnik.Width = 100;
            obdelnik.Height = 80;

            obdelnik.Stroke = Brushes.Black;
            obdelnik.StrokeThickness = TloustkaCary;
            obdelnik.Fill = Vypln;

            Canvas.SetLeft(obdelnik, X);
            Canvas.SetTop(obdelnik, Y);

            platno.Children.Add(obdelnik);
        }
    }
}
