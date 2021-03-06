﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransport
{
    public class Udgift
    {
        public List<double> liste = new List<double>();
        //liste.Add();
        public List<string> UdgiftFelt = new List<string>();
        public List<double> udgiftsliste = new List<double>();
        int row = 0;
        int Udgiftsnummer = 0;
        int column = 0;

        public void AddExpense()
        {
            bool exit = true;
            bool looping = true;
            row = 0;
            Console.SetCursorPosition(row, column);

            while (exit)
            {
                looping = true;
                row = 0;
                Console.SetCursorPosition(row, column);
                Console.SetCursorPosition(row + 5, column);
                string input = Console.ReadLine();

                if (input.Equals(string.Empty))
                {
                    exit = false;
                }

                else if (input is string)
                {
                    UdgiftFelt.Add(input);
                    row = 30;

                    while (looping)
                    {
                        Console.SetCursorPosition(row, column);
                        input = Console.ReadLine();

                        if (int.TryParse(input, out Udgiftsnummer))
                        {
                            udgiftsliste.Add(Udgiftsnummer);
                            column += 1;
                            looping = false;
                        }

                        else
                        {
                            Console.WriteLine("Virker ikke");
                        }
                    }
                }
            }
        }
    }
}
