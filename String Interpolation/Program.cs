namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine($"{date,40:MMMM d, yyyy}");
            Console.WriteLine($"{date:yyyy.MM.dd}");
            Console.WriteLine($"{date:'Day' d 'of' MMMM, yyyy}");
            Console.WriteLine($"{date:'Year:' yyyy, 'Month:' MM, 'Day:' dd}");
            Console.WriteLine($"{date,10:dddd}");
            Console.WriteLine($"{date,10:t}{date,10:dddd}");
            Console.WriteLine($"{date:'h:'h, 'm:'mm, 's:'ss}");
            Console.WriteLine($"{date:yyyy.MM.dd.h.mm.ss}");
            Console.WriteLine(date);

            var pi = Math.PI;
            Console.WriteLine($"{pi:c}");
            Console.WriteLine($"{pi,10:f3}");
        }
    }
}