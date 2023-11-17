using System.Formats.Asn1;
using System.Runtime.InteropServices;

namespace RobotCaveFightTestArena {
	internal class Program {
		static void Main(string[] args) {
			//Create bots
			SuperCoolAlgorithm();
            Console.WriteLine($"{winningCombination}. Good Luck!");
            //TrainingDummy trainingDummy = new TrainingDummy();
            //TrainingDummy trainingDummy1 = new TrainingDummy();
            //Joe joe1 = new Joe();
            //Titan titan1 = new Titan();
            //Create a new arena
            //Arena arena = new Arena(joe1, titan1);

            //arena.RunBattle();
            Console.WriteLine("ALL DONE");
        }
		static void SuperCoolAlgorithm()
		{
            Joe joe1 = new Joe();
			Titan titan1 = new Titan();
            int test = 1;
			for (int i = 1; i < 40; i++)
			{
				for(int j = 1; j < 40; j++)
				{ 
					for(int k = 1; k < 40; k++)
					{
						for(int  l = 1; l < 40; l++)
						{
							if (i + j + k + l == 40)	//all combinations of stats for Joe
							{
								for(int  m = 1; m < 40; m++)
								{
									for(int n = 1; n < 40; n++)
									{
										for(int  o = 1; o < 40; o++)
										{
											for(int p = 1; p < 40; p++)
											{
												if(m + n + o + p == 40)
												{
													if (!((i == m) && (j == n) && (k == o) && (l == p)))
													{
                                                        Console.WriteLine(test);
                                                        Console.WriteLine($"joe stats: {i} + {j} + {k} + {l}");
                                                        Console.WriteLine($"titan stats: {m} + {n} + {o} + {p}");
                                                        joe1.setStats(i, j, k, l);
                                                        joe1.Reset();
                                                        titan1.Reset();
                                                        titan1.setStats(m, n, o, p);
                                                        Arena arena = new Arena(joe1, titan1);
                                                        arena.RunBattle();
                                                        if (arena.info == "Titan") Titan3++;
                                                        if (arena.info == "Joe") Joe3++;
                                                        Console.WriteLine($"Titan wins: {Titan3}");
                                                        Console.WriteLine($"Joe wins: {Joe3}");
                                                        test++;
                                                    }
                                                }
                                            }
										}
									}
								}
								if (maxWins < Joe3)
								{
									maxWins = Joe3;
									winningCombination = ($"Joe's Winning Combination: {i} + {j} + {k} + {l}");
                                    Console.WriteLine(winningCombination);
                                }
                            }

						}
					}
				}
			}
		}
		public static int Joe3 = 0;
		public static int Titan3 = 0;
		public static int maxWins = 0;
		public static string winningCombination = "";
	}
}