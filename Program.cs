using System;

namespace Assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Num3.Mymethod();

            // Num4.Method();

            // Num6.Century();

            // Num7.sort();

            //Num1.Num233();

            //Num2.Num();

            // Num3.Mymethod();

            //Quiz1.Quadratic();

            // Quiz2.StopWatch();

            // Num13.Num12();

            // Num2 num = new Num2();
            // Console.Write("Enter Number: ");
            // double argNum1 = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter Arthemetic operator: ");
            // string arth = Console.ReadLine();

            // Console.Write("Enter Number: ");
            // double argNum2 = Convert.ToInt32(Console.ReadLine());

            // Class3.Jagaban(arth, argNum1, argNum2);
            

             Quiz2 quiz2 = new Quiz2();

            while (true)
            {
                Console.WriteLine("Enter 'start' to start Stopwatch\nEnter 'stop' to end Stopwach\nEnter any key to exit:\n");
                var input = Console.ReadLine().ToLower();

                if (input == "start" || input == "stop")
                    UseStopwatch(quiz2, input);
                else
                    return;
            }
        }
         static void UseStopwatch(MyWatch quiz2, string command)
        {
            switch (command)
            {
                case "start":
                    try
                    { 
                        
                        quiz2.Start();

                    }
                    catch (InvalidOperationException)
                    { 
                        Console.WriteLine("stopWatch is already started\n");
                        
                    }
                    break;
                case "stop":
                    try
                    {
                        quiz2.Stop();
                        Console.WriteLine("Duration: {0}\n", quiz2.GetDuration());
                    }
                    catch (InvalidOperationException)
                    {
                         Console.WriteLine("stopWatch is not started\n");
                    }
                    break;
                default:
                    break;
            }   
        }
    }
}
