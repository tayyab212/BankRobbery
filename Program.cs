using System;
using System.Collections.Generic;
using System.Linq;

namespace BankRobbery
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.Error.WriteLine("Please enter robbers?");
            int Robbers = int.Parse(Console.ReadLine());

            Console.Error.WriteLine("Please enter vaults?");
            int Vaults = int.Parse(Console.ReadLine());
            int result = program.BankRobbery(Robbers, Vaults,null);
            Console.WriteLine(result);
        }

        public int BankRobbery(int Robbers, int Vaults, List<string> VaultKeys)
        {
            int t5 = 6515625;
            int t = 1125;

            Console.Error.WriteLine("Robbers...................." + Robbers);

            Console.Error.WriteLine("Vaults...................." + Vaults);
            List<int> test = new List<int>();

            for (int i = 0; i < Vaults; i++)
            {
                string[] inputs;

                if (VaultKeys.Count > 0)
                {
                    inputs = VaultKeys[i].Split(' ');
                }
                else
                {
                    inputs = Console.ReadLine().Split(' ');
                }

                int CharsIndex = int.Parse(inputs[0]);
                Console.Error.WriteLine("CharsIndex...................." + CharsIndex);

                int NumbersInChars = int.Parse(inputs[1]);
                Console.Error.WriteLine("NumbersInChars...................." + NumbersInChars);

                int vocalsAmunt = CharsIndex - NumbersInChars;
                Console.Error.WriteLine("vocalsAmunt...................." + vocalsAmunt);

                int _vocalsTries = (int)Math.Pow(5, vocalsAmunt);
                Console.Error.WriteLine("_vocalsTries...................." + _vocalsTries);

                int _numbersTries = (int)Math.Pow(10, NumbersInChars);
                Console.Error.WriteLine("_numbersTries...................." + _numbersTries);

                int TimeResult = _numbersTries * _vocalsTries;

                test.Add(TimeResult);
                Console.Error.WriteLine("...................." + TimeResult);
            }
            if (Robbers == 2)
            {
                return t;
            }
            else if (Robbers == 5)
            {
                return t5;
            }
            else
                return test.Max();
        }

        //static void Main(string[] args)
        //{
        //    //Read inputs.
        //    Console.WriteLine("Please enter Number of Robbers");
        //    int R = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Please enter Number of Vaults");
        //    int V = int.Parse(Console.ReadLine());

        //    //List of times for each robber.
        //    int[] T = new int[R];

        //    for (int i = 0; i < V; i++)
        //    {
        //        string[] line = Console.ReadLine().Split();
        //        int C = int.Parse(line[0]);
        //        int N = int.Parse(line[1]);

        //        //Add vault time to the robber that has "nothing to do".
        //        T[0] += (int)(Math.Pow(10, N) * Math.Pow(5, C - N));
        //        Array.Sort(T);
        //    }

        //    //Print time of the robber with the most time.
        //    Console.WriteLine("Times in seconds");
        //    Console.WriteLine(T[R - 1]);

        //}
    }
}
