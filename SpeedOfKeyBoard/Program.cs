namespace SpeedOfKeyBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool helper = true;
            while (helper)
            {
                Console.WriteLine("нажмите q чтобы начать");
                string c = Console.ReadLine();
                if(c.ToLower() == "q")
                {
                    var firsttime = DateTime.Now;
                    string words = Console.ReadLine();
                    var secondtime = DateTime.Now;
                    var diff = secondtime.Subtract(firsttime);
                    double secsdiff = (double)diff.TotalSeconds;
                    string[] check = words.Split(',', '.', ' ', '!', '!', '?');
                    Console.WriteLine($"Вы ввели {check.Length} слов за {Math.Round(secsdiff,2)} секунд");
                    
                }
            }

        }
    }
}