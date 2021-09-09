using System;
using System.Collections.Generic;

namespace PhoneShop
{
    class Program
    {
        //make a list of the phones
        public static List<Phone> phones = new List<Phone>
        {
            new Phone("Huawei", "P30", "6.47\" FHD+ (2340x1080) OLED, Kirin 980 Octa-Core (2x Cortex-A76 2.6GHz + 2x Cortex-A76 1.92GHz + 4x Cortex-A55 1.8GHz), 8GB RAM, 128GB ROM, 40+20+8+TOF/32MP, Dual SIM, 4200mAh, Android 9.0 + EMUI 9.1", 697),
            new Phone("Samsung","Galaxy A52", "64 megapixel camera, 4k videokwaliteit6.5 inch AMOLED scherm128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)Water-en stofbestendig (IP67)", 399),
            new Phone("Apple", "IPhone 11", "Met de dubbele camera schiet je in elke situatie een perfecte foto of videoDe krachtige A13-chipset zorgt voor razendsnelle prestatiesMet Face ID hoef je enkel en alleen naar je toestel te kijken om te ontgrendelenHet toestel heeft een lange accuduur dankzij een energiezuinige processor", 619),
            new Phone("Google", "Pixel 4a", "12.2 megapixel camera, 4k videokwaliteit5.81 inch OLED scherm128 GB opslaggeheugen3140 mAh accucapaciteit", 411),
            new Phone("Xiaomi", "Redmi Note 10 Pro","108 megapixel camera, 4k videokwaliteit6.67 inch AMOLED scherm128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)Water-en stofbestendig (IP53)", 298)
        };
        static void Main(string[] args)
        {
            MainMenu();
        }

        // method MainMenu shows the user the available phones and shows the info of a phone they choose using a loop.
        static void MainMenu()
        {
            char userInput;
            do
            {
                //show all available phones
                Console.WriteLine("Voer a.u.b. het nummer in van de telefoon waarvan u de informatie wil zien. Of type een 0 om te stoppen.\n");
                for (int i = 0; i < phones.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + phones[i].GetName());
                }

                //get and handle userinput
                Console.Write("\nUw keuze: ");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (userInput == '0')
                {
                    continue;
                }


                if (!Char.IsDigit(userInput))
                {
                    Console.Clear();
                    Console.WriteLine("Ongeldige invoer.\n");
                    continue;
                }
                int choice = (int)Char.GetNumericValue(userInput);

                
                if (!(choice >= 1 && choice <= 5))
                {
                    Console.Clear();
                    Console.WriteLine("Ongeldige invoer.\n");
                    continue;
                }

                //print selected phone
                Console.Clear();
                phones[choice - 1].ShowAllInfo();
                Console.WriteLine("\n Druk op een toets om terug te gaan.");
                Console.ReadKey();
                Console.Clear();


            } while (userInput != '0');
        }
    }
}
