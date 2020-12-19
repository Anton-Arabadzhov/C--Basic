using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                string  Command = Console.ReadLine();

                if (Command == "Stop")
                {
                    break;
                }
                Console.WriteLine(Command);
            }
            

        }
    }
}
