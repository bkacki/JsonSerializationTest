using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationTest
{
    public class Guy
    {
        public string Name { get; set; }
        public HairStyle Hair { get; set; }
        public Outfit Clothes { get; set; }
        public override string ToString() => $"{Name} ma {Hair} i nosi {Clothes}.";
    }

    public class Outfit
    {
        public string Top { get; set; }
        public string Bottom { get; set; }
        public override string ToString() => $"{Top} i {Bottom}";
    }

    public enum HairColor
    {
        kasztanowe, czarne, blond, niebieskie, brązowe, szare, platynowe, fioletowe, czerwone, białe,
    }

    public class HairStyle
    {
        public HairColor Color { get; set; }
        public float Length { get; set; }
        public override string ToString() => $"{Color} włosy o długości {Length:0.0}cm";
    }
}
