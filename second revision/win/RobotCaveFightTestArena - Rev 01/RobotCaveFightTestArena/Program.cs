namespace RobotCaveFightTestArena {
	internal class Program {
		static void Main(string[] args) {
            //Create bots

            TrainingDummy trainingDummy = new TrainingDummy();
			TrainingDummy trainingDummy1 = new TrainingDummy();
			Joe joe1 = new Joe();
			Titan titan1 = new Titan();
            Console.WriteLine(double.PositiveInfinity * 10);

            //Create a new arena
            Arena arena = new Arena(trainingDummy1, joe1);

			arena.RunBattle();
		}
	}
}