using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var skruerliste = System.IO.File.ReadAllLines("vegt.txt").ToList();

            string textoutput = "";

            List<double> skruevægt = new List<double>();
            foreach (var item in skruerliste)
            {
                skruevægt.Add(double.Parse(item));
                //skruevægt.Add(double.Parse(item));
            }

            var skruerOver2GramOgUnder1gram = skruevægt.Where(x => x > 2 || x < 1).ToList();


            foreach (var item in skruerOver2GramOgUnder1gram)
            {
                textoutput += "Skruernes med en vægt over 2 gram og under 1 gram. " + item + Environment.NewLine;
            }

            var skruerMellem1gramOg2Gram = skruevægt.Where(x => x <= 2 || x <= 1).ToList();

            var samletAntalAfSkruerMellem1gramOg2Gram = skruerMellem1gramOg2Gram.Count;
            var samletVægtskruerMellem1gramOg2Gram = skruerMellem1gramOg2Gram.Sum(x => x);

            var gennemsnitAfVægtPåskruerMellem1gramOg2Gram = samletVægtskruerMellem1gramOg2Gram / samletAntalAfSkruerMellem1gramOg2Gram;

            textoutput += "Gennemsnitsvægten på skruer mellem 1 og 2: " + gennemsnitAfVægtPåskruerMellem1gramOg2Gram;

            //indskriver resultatet i et txt fil. 
            System.IO.File.AppendAllText("kvalitet.txt", textoutput + " gram ");

        }
    }
}
