using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis:
            //"oled liiga noor, et juhilube saada.";
            // kui kasutaja on piisavalt vana, et juhilube saada, siis programm kuvab konsoolis:
            //"oled piisavalt vana, et juhilube saada."
            //Kui kasutaja on 18, siis programm kuvab konsoolis:
            //"Palju õnne, nüüd saad juhilube taotleda!"

           Console.WriteLine("Tere!");
           Console.WriteLine("Palun, sisesta oma nimi.");
            string UserName;
            UserName = Console.ReadLine();

            Console.WriteLine(UserName + ", palun sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }
            else if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne, nüüd saad juhilube taotleda!.");
            }

            Console.WriteLine("Kena päeva!");
       
        }
    }
}
