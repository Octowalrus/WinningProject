using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

#pragma warning disable SYSLIB0006


/**
 * protect against "20 + 2 + 2 + 16", "19 + 2 + 2 +17", "16 + 2 + 2 + 20"
 */

namespace RobotCaveFightTestArena
{
    internal class Program
    {                           //                                                          solved                                                                                                      solved
        static int[,] losers = { { 16, 1, 1, 22 }, { 17, 1, 1, 21 }, { 17, 2, 1, 20 }, { 18, 1, 1, 20 }, { 19, 1, 1, 19 }, { 19, 1, 2, 18 }, { 20, 1, 1, 18 }, { 21, 1, 1, 17 }, { 21, 2, 1, 16 }, { 23, 1, 1, 15 } };
        public static bool resume = false;
        public static bool resume2 = false;
        public static int currentNumber = 0;
        public static int maxWins2 = 0;
        public static string winningCombination2 = "";

        static void Main(string[] args)     // 1+1+1+37?    nah, 18+1+1+20 / ult is 17+2+1+20
        {
            //Console.WriteLine(losers.Length);
            //Console.WriteLine(losers[2, 3]);
            setupStuff();
            for (int lebron = 1; lebron < 2; lebron++)    //172
            {
                Thread t = new Thread(() => LiterallyTheCoolestSuperestThreadedAlgorithm(lebron));
                //Thread t = new Thread(() => AlgorithmTester(lebron));
                t.Start();
                Thread.Sleep(10);
            }
            Console.ReadLine();
            Console.WriteLine(Joe7);
            Console.WriteLine(Titan7);
            /*
            for (int j = 1; j < 9140; j++)      //when ur done, change this to j = 9135; j < 9140 to get the last two :)
            {
                //Thread t = new Thread(() => LiterallyTheCoolestSuperestThreadedAlgorithm(j));
                Thread t = new Thread(() => AlgorithmTester(j));
                t.Start();
                Thread.Sleep(10);
            }
            */
            Console.ReadLine();
            Console.WriteLine($"{winningCombination2}. Good Luck!");
            Console.WriteLine(losercombos);
            Console.WriteLine("ALL DONE");
            Console.WriteLine("ALL DONE");

            //Create bots
            /*for (int i = 0; i < 6546; i++)
            {
                currentNumber = i + 1;
                Thread t = new Thread(() => EvenCoolerSuperThreadedAlgorithm(currentNumber));
                t.Start();
                Thread.Sleep(100);
            }
            Console.ReadLine();
                Console.WriteLine($"{winningCombination2}. Good Luck!");
            //Console.WriteLine(losercombos);
            //TrainingDummy trainingDummy = new TrainingDummy();
            //TrainingDummy trainingDummy1 = new TrainingDummy();
            //arena.RunBattle();
            Console.WriteLine("ALL DONE");
                resume = false;
            */
        }

        public static string losercombos = "";

        static void duel()
        {
            int i = 14;
            int j = 1;
            int k = 1;
            int l = 24; //+3 health for T1
            int m = 10;
            int n = 15;
            int o = 5;
            int p = 10;
            Joe joe2 = new Joe();
            Titan titan2 = new Titan();
            joe2.setStats(i, j, k, l);
            joe2.Reset();
            titan2.Reset();
            titan2.setStats(m, n, o, p);
            Arena arena2 = new Arena(joe2, titan2);
            arena2.RunBattle();
            if (arena2.info == "Titan") Console.WriteLine("Titan Won");
            if (arena2.info == "Joe") Console.WriteLine("Joe Won");

        }
        static int Joe7 = 0;
        static int Titan7 = 0;
        static void AlgorithmTester(int p)
        {
            //int Joe7 = 0;
            //int Titan7 = 0;
            int test2 = 1;
            Joe joe2 = new Joe();
            Titan titan2 = new Titan();
            //Console.WriteLine(test2);
            for (int k = 0; k < 9140; k++)
            {
                //Console.WriteLine(attacks2[12] + "attacks2");
                Console.WriteLine($"joe stats: {attacks2[p]} + {defenses2[p]} + {speeds2[p]} + {constitutions2[p]}");
                Console.WriteLine($"titan stats: {attacks2[k]} + {defenses2[k]} + {speeds2[k]} + {constitutions2[k]}");
                joe2.setStats(attacks2[p], defenses2[p], speeds2[p], constitutions2[p]);
                //joe2.setStats(17, 2, 1, 20);
                joe2.Reset();
                titan2.Reset();
                titan2.setStats(attacks2[k], defenses2[k], speeds2[k], constitutions2[k]);
                Arena arena2 = new Arena(joe2, titan2);
                arena2.RunBattle();
                if (arena2.info == "Titan") Titan7++;
                if (arena2.info == "Joe") Joe7++;
                test2++;
                Console.WriteLine(Joe7);
                if (arena2.info == "Titan")
                {
                    losercombos = losercombos + ($"loser: {attacks2[k]} + {defenses2[k]} + {speeds2[k]} + {constitutions2[k]}\n joe: {attacks2[p]} + {defenses2[p]} + {speeds2[p]} + {constitutions2[p]}\n");
                }
                if (Joe7 == 12)
                {
                    //Console.WriteLine("winner" + attacks2[p] + " " + defenses2[p] + "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                }
                if (arena2.info == "Titan") Console.WriteLine("Titan Won");
                if (arena2.info == "Joe") Console.WriteLine($"Joe Won {joe2.GetStats()} l");
                if (arena2.info == "Joe")
                {
                    winningCombination2 = winningCombination2 + ($"bruh\n {attacks2[p]} + {defenses2[p]}, {speeds2[p]}, {constitutions2[p]}\n {losers[k, 0]}, {losers[k, 1]}, {losers[k, 2]}, {losers[k, 3]}");
                }
                if (arena2.info == "Joe") Console.WriteLine($"gg: {attacks2[p]}, {defenses2[p]}, {speeds2[p]}, {constitutions2[p]}");
            }
        }

        static int[] attacks = new int[2313442];
        static int[] defenses = new int[2313442];
        static int[] speeds = new int[2313442];
        static int[] constitutions = new int[2313442];
        static int[] attacks2 = new int[9140];
        static int[] defenses2 = new int[9140];
        static int[] speeds2 = new int[9140];
        static int[] constitutions2 = new int[9140];
        static int found = 0;
        static int i = 1;

        static void setupStuff()
        {
            var lines = File.ReadAllLines("dataset.txt");
            var lines2 = File.ReadAllLines("output.txt");
            i = 1;
            foreach (string s in lines)
            {
                string[] subs = s.Split(' ', '-');
                //Console.WriteLine(s);
                attacks[i] = Convert.ToInt32(subs[0]);
                defenses[i] = Convert.ToInt32(subs[1]);
                speeds[i] = Convert.ToInt32(subs[2]);
                constitutions[i] = Convert.ToInt32(subs[3]);
                i++;
            }
            /*
            foreach (string s in lines2)
            {
                string[] subs = s.Split(' ', '-');
                Console.WriteLine(s);
                attacks[i] = Convert.ToInt32(subs[0]);
                defenses[i] = Convert.ToInt32(subs[1]);
                speeds[i] = Convert.ToInt32(subs[2]);
                Console.WriteLine(i);
                i++;
            }
            */
            i = 1;
            for (i = 1; i < 2313442; i++)
            {
                if (attacks[i] + defenses[i] + speeds[i] + constitutions[i] == 40/* && constitutions[i] == 20*/)
                {
                    found++;
                    //j
                    //Console.WriteLine(found);
                    attacks2[found] = attacks[i];
                    defenses2[found] = defenses[i];
                    speeds2[found] = speeds[i];
                    constitutions2[found] = constitutions[i];
                    //Console.WriteLine(found);   //18 combinations jk its 171
                }
            }
        }
        static void alsoSetupStuff()
        {
            var lines = File.ReadAllLines("dataset.txt");
            i = 1;
            foreach (string s in lines)
            {
                string[] subs = s.Split(' ', '-');
                //Console.WriteLine(s);
                attacks[i] = Convert.ToInt32(subs[0]);
                defenses[i] = Convert.ToInt32(subs[1]);
                speeds[i] = Convert.ToInt32(subs[2]);
                constitutions[i] = Convert.ToInt32(subs[3]);
                i++;
            }
            for (i = 1; i < 2313442; i++)
            {
                if ((attacks[i] + defenses[i] + 20 == 39) && (speeds[i] == 1))
                {
                    found++;
                    //j
                    //Console.WriteLine(found);
                    attacks2[found] = attacks[i];
                    defenses2[found] = defenses[i];
                    speeds2[found] = 1;
                    constitutions2[found] = 20;

                }
            }
        }
        
        static void LiterallyTheCoolestSuperestThreadedAlgorithm(int newCurrent)
        {
            Joe joe2 = new Joe();
            Titan titan2 = new Titan();
            int test2 = 1;
            Console.WriteLine(joe2.GetStats());
            joe2.Reset();
            titan2.Reset();
            //titan2.setStats(attacks2[newCurrent], defenses2[newCurrent], speeds2[newCurrent], constitutions2[newCurrent]);
            Arena arena2 = new Arena(joe2, titan2);
            arena2.RunBattle();
            if (arena2.info == "Titan") Titan7++;
            if (arena2.info == "Joe") Joe7++;
            test2++;
            if (arena2.info == "Titan") Console.WriteLine("Titan Won");
            if (arena2.info == "Joe") Console.WriteLine("Joe Won");
        }

        static void EvenCoolerSuperThreadedAlgorithm(int newCurrent)
        {
            Joe joe2 = new Joe();
            Titan titan2 = new Titan();
            Console.WriteLine(newCurrent);
            int bad = 1;
            int test2 = 1;
            int Joe7;
            int Titan7;
            bool breakout = false;
            for (int i = 1; i < 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    for (int k = 1; k < 40; k++)
                    {
                        for (int l = 1; l < 40; l++)
                        {
                            if (i + j + k + l == 40)    //all combinations of stats for Joe
                            {
                                Joe7 = 0;
                                Titan7 = 0;
                                if (bad == newCurrent)
                                {
                                    for (int m = 1; m < 40; m++)
                                    {
                                        for (int n = 1; n < 40; n++)
                                        {
                                            for (int o = 1; o < 40; o++)
                                            {
                                                for (int p = 1; p < 40; p++)
                                                {
                                                    if (m + n + o + p == 40)
                                                    {
                                                        if (!((i == m) && (j == n) && (k == o) && (l == p)))
                                                        {
                                                            Console.WriteLine(test2);
                                                            Console.WriteLine($"joe stats: {i} + {j} + {k} + {l}");
                                                            Console.WriteLine($"titan stats: {m} + {n} + {o} + {p}");
                                                            joe2.setStats(i, j, k, l);
                                                            joe2.Reset();
                                                            titan2.Reset();
                                                            titan2.setStats(m, n, o, p);
                                                            Arena arena2 = new Arena(joe2, titan2);
                                                            arena2.RunBattle();
                                                            if (arena2.info == "Titan") Titan7++;
                                                            if (arena2.info == "Joe") Joe7++;
                                                            Console.WriteLine($"Titan wins: {Titan7}");
                                                            Console.WriteLine($"Joe wins: {Joe7}");
                                                            test2++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (maxWins2 < Joe7)
                                {
                                    maxWins2 = Joe7;
                                    winningCombination2 = ($"Joe's Winning Combination: {i} + {j} + {k} + {l}");
                                    Console.WriteLine(winningCombination2);
                                }
                                if (bad == newCurrent)
                                {
                                    breakout = true;
                                    break;
                                }
                                bad++;
                            }
                            if (breakout) break;

                        }
                        if (breakout) break;
                    }
                    if (breakout) break;
                }
                if (breakout) break;
            }
        }
        /* arr[] ---> Input Array
        data[] ---> Temporary array to
                    store current combination
        start & end ---> Starting and Ending 
                         indexes in arr[]
        index ---> Current index in data[]
        r ---> Size of a combination
                to be printed */
        static void combinationUtil(int[] arr, int[] data,
                                    int start, int end,
                                    int index, int r)
        {
            // Current combination is 
            // ready to be printed, 
            // print it
            if (index == r)
            {
                for (int j = 0; j < r; j++)
                    Console.Write(data[j] + " ");
                Console.WriteLine("");
                return;
            }

            // replace index with all
            // possible elements. The 
            // condition "end-i+1 >= 
            // r-index" makes sure that 
            // including one element
            // at index will make a 
            // combination with remaining 
            // elements at remaining positions
            for (int i = start; i <= end &&
                      end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                combinationUtil(arr, data, i + 1,
                                end, index + 1, r);
            }
        }

        // The main function that prints
        // all combinations of size r
        // in arr[] of size n. This 
        // function mainly uses combinationUtil()
        public static void printCombination(int[] arr,
                                     int n, int r)
        {
            // A temporary array to store 
            // all combination one by one
            int[] data = new int[r];
            // Print all combination 
            // using temporary array 'data[]'
            combinationUtil(arr, data, 0,
                            n - 1, 0, r);
        }
    }
}
