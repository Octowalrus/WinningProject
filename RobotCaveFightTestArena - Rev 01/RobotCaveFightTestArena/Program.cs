namespace RobotCaveFightTestArena {
	internal class Program {
		static void Main(string[] args) {
            //Create bots

            TrainingDummy trainingDummy = new TrainingDummy();
			TrainingDummy trainingDummy1 = new TrainingDummy();
			Joe joe1 = new Joe();

            //Create a new arena
            Arena arena = new Arena(trainingDummy, joe1);

			arena.RunBattle();
		}
	}
}