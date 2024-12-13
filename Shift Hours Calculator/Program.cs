/*
MIT License

Copyright(c) 2024 Samuel Crouch

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShiftHoursCalculator
{
    
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please type 'END' when you get to the 'Hours' after you have finished");
            Console.WriteLine("Hours and Minutes are inputted separately in this program");
            string rate;
            string Hours;
            string Minutes;
            bool loop = true;
            int shiftNo = 0;
            List<int> HoursList = new List<int>();
            List<int> MinsList = new List<int>();
            Console.Write("Hourly Rate: £");
            rate = Console.ReadLine();
            bool convertRate = float.TryParse(rate, out float ratenum);
            if (convertRate == false)
            {
                Console.WriteLine("ERROR");
                
            }

            while (loop == true && convertRate == true)
            {

                Console.WriteLine("...");
                shiftNo++;
                Console.WriteLine($"SHIFT {shiftNo}");

                //HOURS
                Console.WriteLine("Hours: ");
                Hours = Console.ReadLine();
                if (Hours.ToUpper() == "END")
                {
                    
                    Console.WriteLine("---");
                    Console.WriteLine($"Shifts Total: {shiftNo - 1}");
                    int HoursEnd = 0;
                    int MinsEnd = 0;

                    foreach (int Hour in HoursList)
                    {
                        
                        HoursEnd = HoursEnd + Hour;
                    }
                    foreach(int Mins in MinsList)
                    {
                        
                        MinsEnd = MinsEnd + Mins;
                    }

                    int MinsToHours = MinsEnd / 60;
                    float MinsRem = MinsEnd % 60;
                    

                    HoursEnd = HoursEnd + MinsToHours;

                    Console.WriteLine($"Hours Total: {HoursEnd}");
                    Console.WriteLine($"Minutes Total: {MinsRem}");

                    float HourRate = (HoursEnd * ratenum);
                    float MinRate = (MinsRem/60) * ratenum;
                    float TotalRate = HourRate + MinRate;

                    Console.WriteLine($"£{TotalRate}");

                    break;
                }
                if (Hours == null)
                {
                    Console.WriteLine("ERROR");
                    break;
                }
                bool convertHour = Int32.TryParse(Hours, out int Hnum);
                if (convertHour == false)
                {
                    Console.WriteLine("ERROR");
                    break;
                }
                else if (convertHour == true)
                {
                    HoursList.Add(Hnum);
                }

                //MINUTES
                Console.WriteLine("Minutes: ");
                Minutes = Console.ReadLine();
                
                bool convertMin = Int32.TryParse(Minutes, out int Mnum);
                if (convertMin == false)
                {
                    Console.WriteLine("ERROR");
                    break;
                }
                else if (convertMin == true)
                {
                    if (Mnum <= 60 && Mnum >= 0)
                    {
                        MinsList.Add(Mnum);
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                        break;
                    }
                    
                }

            }
        }
    }
}
