using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using static System.Console;

namespace Task1Console
{
    class Program
    {
        static bool alarmed = false;

        static void Main(string[] args)
        {
            WriteLine("Input seconds to wait");
            int seconds;
            while (!int.TryParse(ReadLine(),out seconds))
                WriteLine("Wrong input! Try again.");
            var alarm = new AlarmClock();
            alarm.WakeUp += WriteAlarmMessage;
            alarm.Set(TimeSpan.FromSeconds(seconds));
            WriteLine("Wait for alarm...");
            while (!alarmed)
                ReadKey();
        }

        static void WriteAlarmMessage(object sender, EventArgs e)
        {
            WriteLine();
            WriteLine("ALARM!!! ALARM!! ALARM!!");
            alarmed = true;
        }
    }
}
