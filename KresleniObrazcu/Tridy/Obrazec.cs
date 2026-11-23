using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace KresleniObrazcu.Tridy
{
    public abstract class Obrazec
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double TloustkaCary { get; set; }
        public Brush Vypln { get; set; }

        public abstract void Vykresli(Canvas platno);
    }
}
