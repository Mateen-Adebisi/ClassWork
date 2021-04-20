using System;

namespace Assingment
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Num1.DivisionofTwoNumers();

            Num2.SwapingofTwoNumbers();

            Num3.PrintMultipleofSeven();
            
            Num4.myCalculator();

            Num5.RevercetheWordofaSectence();

            Num6.Multiplication();

            Num7.ComputetheSumOfAnIneger();

            Num8.FromCelciusTofarenheit();

            Num9.RemoveIndex();

            Num11.ComputeThesumAGivenIn();

            Num12.MultiplyTheArrays();

            Num13.CheckingLongestWordInAnArray();

            Num14.checkifagivenpositivenumber();

            Num15.FindingTheHighestNumber();

            Num16.Creatinganewstring();

            Num16.test();

            Num17.computethesumofalltheelementsofanarrayofintegers();

            Num18.checkifthefirstelementandthelastelementareequal();

            Num20.CHeckTheCenturyFromYear();

            Num22.Checkingifagivennumberexistsinanarray();
            
            Quiz1.Quadratic();

            Quiz2.StopWatch();

            Num13.Num12();

           
            

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
