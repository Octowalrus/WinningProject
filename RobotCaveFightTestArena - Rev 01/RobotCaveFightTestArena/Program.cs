namespace RobotCaveFightTestArena {
	internal class Program {
		static void Main(string[] args) {
			//Create bots
			TrainingDummy trainingDummy = new TrainingDummy();
			TrainingDummy trainingDummy1 = new TrainingDummy();
			IRobot Joe = new Joe();

			//Create a new arena
			Arena arena = new Arena(trainingDummy, Joe);

			arena.RunBattle();
		}
		static void SuperCoolAlgorithm()
		{
			for (int i = 1; i < 40; i++)
			{
				for(int j = 1; j < 40; j++)
				{ 
					for(int k = 1; k < 40; k++)
					{
						for(int  l = 1; l < 40; l++)
						{
							
						}
					}
				}
			}
		}
	}
}