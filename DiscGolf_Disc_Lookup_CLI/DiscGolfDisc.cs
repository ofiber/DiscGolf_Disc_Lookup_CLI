using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscGolf_Disc_Lookup_CLI
{
    public class DiscGolfDisc
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public double Speed { get; set; }
        public double Glide { get; set; }
        public double Turn { get; set; }
        public double Fade { get; set; }

        public DiscGolfDisc(string name, string brand, string type, double speed, double glide, double turn, double fade)
        {
            Name = name;
            Brand = brand;
            Type = type;
            Speed = speed;
            Glide = glide;
            Turn = turn;
            Fade = fade;
        }
        public override string ToString()
        {
            return $"{Name} - {Brand} - {Type} | Speed: {Speed}, Glide: {Glide}, Turn: {Turn}, Fade: {Fade}";
        }
    }
}
