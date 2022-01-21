using System;
using System.Timers;
using System.Threading;
using System.Text;

namespace homework
{
    //class Program
    //{

    //    static DateTime Time = new DateTime(2022, 1, 19);
    //    static int KeyCount = 0;
    //    static StringBuilder word = new();


    //    static void TimeUpdate(Object source, ElapsedEventArgs e)
    //    {
    //        Time = Time.AddHours(1);
    //    }

    //    static void SecondThreadFunction()
    //    {
    //        while (true)
    //        {
    //            if (Console.KeyAvailable)
    //            {
    //                Console.CursorTop = 1;
                    
    //                KeyCount++;

    //                var data = Console.ReadKey();


    //                if (data.Key == ConsoleKey.Enter)
    //                {
    //                    Console.Clear();
    //                    KeyCount = 0;
    //                    Console.CursorTop = 2;
    //                    Console.WriteLine(word);
    //                    word = new();
    //                }
    //                else if (data.Key == ConsoleKey.Backspace && KeyCount >= 2)
    //                {
    //                    KeyCount--;
    //                    KeyCount--;
    //                    Console.Clear();

    //                    word.Length = word.Length - 1;
    //                    Console.CursorTop = 1;
    //                    Console.WriteLine(word);
    //                }
    //                else
    //                {
    //                    word.Append(data.KeyChar.ToString());
    //                }

    //            }
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Thread myThread = new Thread(new ThreadStart(SecondThreadFunction));
    //        myThread.Start();
            
    //        var Event = new System.Timers.Timer(5000);

    //        Event.AutoReset = true;
    //        Event.Elapsed += TimeUpdate;
            
    //        Event.Start();

    //        while (true)
    //        {
    //            Console.CursorTop = 0;
    //            Console.CursorLeft = 100;
                
    //            Console.WriteLine(Time);
    //            Console.CursorLeft = KeyCount;

    //            Thread.Sleep(60);
    //        }
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary();

            dictionary.AppendWord("Pencere", "Window");
            dictionary.AppendWord("Qapi", "Door");
            dictionary.AppendWord("Top", "Ball");
            dictionary.AppendWord("Vaza", "Vase");
            dictionary.AppendWord("Yeni", "New");

            dictionary.AppendWord("Yuklenmeler", "Download");
            dictionary.AppendWord("Luget", "Dictionary");
            dictionary.AppendWord("Axtaris", "Search");
            dictionary.AppendWord("Sekil", "Picture");
            dictionary.AppendWord("Qacmaq", "Run");

            dictionary.AppendWord("Daxil Olmaq", "Join");
            dictionary.AppendWord("Dost", "Friend");
            dictionary.AppendWord("Qasiq", "Spoon");
            dictionary.AppendWord("O", "He");
            dictionary.AppendWord("Kecmek", "Skip");

            dictionary.AppendWord("is", "Job");
            dictionary.AppendWord("Cap etmek", "Print");
            dictionary.AppendWord("Nailiyyet", "Achievement");
            dictionary.AppendWord("Fealiyyet", "Activity");
            dictionary.AppendWord("Aktyor", "Actor");

            dictionary.AppendWord("Yagis", "Rain");
            dictionary.AppendWord("Qar", "Snow");
            dictionary.AppendWord("Yay", "Summer");
            dictionary.AppendWord("Qis", "Winter");
            dictionary.AppendWord("Yaz", "Spring");
            
            dictionary.AppendWord("Ox", "Arrow");
            dictionary.AppendWord("Kepka", "Cap");
            dictionary.AppendWord("Toyuq", "Hen");
            dictionary.AppendWord("Papaq", "Hat");
            dictionary.AppendWord("Bas", "Head");

            dictionary.AppendWord("Ramazan", "Bot");

            try
            {
                Console.WriteLine("Ramazan is {0}", dictionary["Ramazan"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
