using System;
using System.Globalization;

namespace DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######## Day of the Week console #########");
            Console.WriteLine("");

            //getting the information by console
            Console.WriteLine("Tell the year the you were born, please:");
            string year;
            year = Console.ReadLine();

            //check the value it's a number
            if (!IsNumber(year))
            {
                Console.WriteLine("The value it's not a number, please try again.");
                return;
            }
            var yourBirthdayYear = int.Parse(year);

            //getting the information by console
            Console.WriteLine("Tell the month the you were born, please:");
            string month;
            month = Console.ReadLine();

            //check the value it's a number
            if (!IsNumber(month))
            {
                Console.WriteLine("The value it's not a number, please try again.");
                return;
            }
            var yourBirthdayMonth = int.Parse(month);

            //getting the information by console
            Console.WriteLine("Tell the day the you were born, please:");
            string day;
            day = Console.ReadLine();

            //check the value it's a number
            if (!IsNumber(day))
            {
                Console.WriteLine("The value it's not a number, please try again.");
                return;
            }
            var yourBirthdayDate = int.Parse(day);

            //getting the year
            var currentYear = DateTime.Now.Year;

            //calculating your age
            var age = currentYear - yourBirthdayYear;

            //get the day of the week
            var calculeTheWeekDay = new DateTime(yourBirthdayYear, yourBirthdayMonth, yourBirthdayDate);
            var weekDay = calculeTheWeekDay.ToString("dddd");

            Console.WriteLine($" Your Age: {age}");

            //Show the information in different languages
            //English
            Console.WriteLine($" English: Day of the week you were born: {weekDay}");

            //French
            weekDay = Calcule(calculeTheWeekDay, "fr-FR");
            Console.WriteLine($" French: Jour de la semaine où vous êtes né: {weekDay}");

            //Portuguese
            weekDay = Calcule(calculeTheWeekDay, "pt-BR");
            Console.WriteLine($" Português: Dia da semana que você nasceu: {weekDay}");

            //Spanish
            weekDay = Calcule(calculeTheWeekDay, "es-ES");
            Console.WriteLine($" Spañol: Día de la semana en que naciste: {weekDay}");

            Console.ReadLine();
        }

        private static string Calcule(DateTime calculeTheWeekDay, string culture)
        {
            return calculeTheWeekDay.ToString("ddddd", new CultureInfo(culture));
        }

        private static bool IsNumber(string value)
        {
            CheckData.IMain _checkData = new CheckData.Main();
            return _checkData.IsNumber(value);
        }
    }
}
