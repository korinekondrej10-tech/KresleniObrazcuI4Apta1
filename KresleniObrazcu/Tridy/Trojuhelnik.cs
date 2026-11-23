using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KresleniObrazcu.Tridy
{
    public class Trojuhelnik : Obrazec
    {
        public override void Vykresli(Canvas platno)
        {
            Polygon trojuhelnik = new Polygon
            {
                Points = new PointCollection()
                {
                    new Point(50, 0),
                    new Point(0, 80),
                    new Point(100, 80)
                },

                Stroke = Brushes.Black,
                StrokeThickness = TloustkaCary,
                Fill = Vypln
            };

            Canvas.SetLeft(trojuhelnik, X);
            Canvas.SetTop(trojuhelnik, Y);

            platno.Children.Add(trojuhelnik);
        }
    }
}
