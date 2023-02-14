using System;


namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            int month = 0;
            int day = 0;
            
            do
            {
                Console.Write("Enter year: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (year >= 1971 && year <= 2022)
                {
                    break;
                }
                Console.WriteLine("Invalid year. Try again...");
            } while (true);

            do
            {
                Console.Write("Enter month: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (month >= 1 && month <= 12)
                {
                    break;
                }
                Console.WriteLine("Invalid month. Try again...");
            } while (true);

            do
            {
                Console.Write("Enter day: ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (day >= 1 && day <= 31)
                {
                    if (month==2 && day<=28)
                    {
                        break;
                    }
                    else if ((month==4||month==6||month==9||month==11)&&(day<=30))
                    {
                        break;
                    }
                    else if ((month == 1 || month == 3 || month == 5 || month == 7||month==8||month==10||month==12) && (day <= 31))
                    {
                        break;
                    }
                }
                Console.WriteLine("Invalid month. Try again...");
            } while (true);
            string monthEng = null;
            switch (month)
            {
                case 1:
                    monthEng = "Jan";
                    break;
                case 2: monthEng = "Feb";
                    break;
                case 3: monthEng = "Mar";
                    break;
                case 4: monthEng = "Apr";
                    break;
                case 5: monthEng = "May";
                    break;
                case 6: monthEng = "Jun";
                    break;
                case 7: monthEng = "Jul";
                    break;
                case 8: monthEng = "Aug";
                    break;
                case 9: monthEng = "Sep";
                    break;
                case 10: monthEng = "Oct";
                    break;
                case 11: monthEng = "Nov";
                    break;
                case 12: monthEng = "Dec";
                    break;
                default: 
                    break;
            }
            Console.WriteLine(day + "-" + monthEng + "-" + year);
            Console.ReadLine();
            /*Console.Write("Enter Month: ");
            Console.WriteLine();
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Day: ");
            Console.WriteLine();
            int day = Convert.ToInt32(Console.ReadLine());*/
        }
    }
}
