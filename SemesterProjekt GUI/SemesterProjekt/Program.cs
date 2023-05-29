using SemesterProjekt.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjekt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new BGFStartside());


        }

        static void FindSuitableGlasses()
        {
            Console.WriteLine("Velkommen til brille-guiden!");
            Console.WriteLine("Vi vil stille dig nogle spørgsmål for at hjælpe dig med at finde de bedste passende briller efter dine ønsker.");
            Console.WriteLine();

            Console.WriteLine("Hvor vil du start?");
            Console.WriteLine("1. Herrer");
            Console.WriteLine("2. Damer");
            Console.WriteLine("3. Børn");
            int genderSelection = Convert.ToInt32(Console.ReadLine());
            string gender = "";

            switch (genderSelection)
            {
                case 1:
                    gender = "Herrer";
                    break;
                case 2:
                    gender = "Damer";
                    break;
                case 3:
                    gender = "Børn";
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Vælg venligst et gyldigt køn.");
                    FindSuitableGlasses();
                    return;
            }

            Console.WriteLine("Hvad er deres alder?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvad er deres brille længde?");
            int lengthOfGlasses = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvad er deres brille længde?");
            int widthOfGlasses = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvilken brilletype søger du?");
            Console.WriteLine("1. Almindelige brille");
            Console.WriteLine("2. Solbriller");
            int typeSelection = Convert.ToInt32(Console.ReadLine());
            string type = "";

            switch (typeSelection)
            {
                case 1:
                    type = "Almindelige brille";
                    break;
                case 2:
                    type = "Solbriller";
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Vælg venligst en gyldig type.");
                    FindSuitableGlasses();
                    return;
            }

            Console.WriteLine("Hvor skal de anvendes?");
            Console.WriteLine("1. Hverdagsbrug");
            Console.WriteLine("2. Sport");
            Console.WriteLine("3. Læsebriller");
            int beUsedForSelection = Convert.ToInt32(Console.ReadLine());
            string beUsedFor = "";

            switch (beUsedForSelection)
            {
                case 1:
                    beUsedFor = "Hverdagsbrug";
                    break;
                case 2:
                    beUsedFor = "Sport";
                    break;
                case 3:
                    beUsedFor = "Læsebriller";
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Vælg venligst en gyldig anvendelse.");
                    FindSuitableGlasses();
                    return;
            }

            Console.WriteLine("Hvilken stil søger du?");
            Console.WriteLine("1. Klassisk");
            Console.WriteLine("2. Moderne");
            Console.WriteLine("3. Sporty");
            int styleSelection = Convert.ToInt32(Console.ReadLine());
            string style = "";

            switch (styleSelection)
            {
                case 1:
                    style = "Klassisk";
                    break;
                case 2:
                    style = "Moderne";
                    break;
                case 3:
                    style = "Sporty";
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Vælg venligst en gyldig stil.");
                    FindSuitableGlasses();
                    return;
            }

            Console.WriteLine("Hvilken farve foretrækker du?");
            Console.WriteLine("1. Sort");
            Console.WriteLine("2. Brun");
            Console.WriteLine("3. Blå");
            int colorChoice = Convert.ToInt32(Console.ReadLine());
            string color = "";

            switch (colorChoice)
            {
                case 1:
                    color = "Sort";
                    break;
                case 2:
                    color = "Brun";
                    break;
                case 3:
                    color = "Blå";
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Vælg venligst en gyldig farve.");
                    FindSuitableGlasses();
                    return;
            }

            Console.WriteLine();
            Console.WriteLine("Tak for dine svar! Baseret på dine præferencer anbefaler vi følgende briller:");

            // Here can you add logic to recommend glasses based on customer responses
            // You can have a database of glasses with different properties (style, color, size, etc.)
            // and find the glasses that best match the customer's preferences.

            Console.WriteLine($"{gender}");
            Console.WriteLine($"{lengthOfGlasses}");
            Console.WriteLine($"{widthOfGlasses}");
            Console.WriteLine($"{type}");
            Console.WriteLine($"{beUsedFor}");
            Console.WriteLine($"Stil: {style}");
            Console.WriteLine($"Farve: {color}");
            Console.WriteLine("Mere information om de anbefalede briller...");

            // You can also add more information about the recommended glasses or present a list of alternative options to the customer.

            Console.WriteLine();
            Console.WriteLine("Vi håber, at du finder denne information nyttig. God dag!");
        }
    }

}

