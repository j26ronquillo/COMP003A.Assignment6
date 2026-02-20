namespace COMP003A.Assignment6
{
    class WorkoutSession
    {
        //Theme B Fitness Session Planner

            public string Name;
            public int Duration;
            public bool Workout;

            public WorkoutSession(string name, int duration, bool workout)
            {
                Name = name;
                Duration = duration;
                Workout = workout;
            }

        public void DisplayInfo()
        {
            Console.Write($"Name: " + Name);
			Console.Write($"Workout: " + Duration + " minutes. ");
			Console.Write($"Completed: " + Workout + "\n");
		} 

        public void FinishWorkout()
        {
            Workout = true;
        }

        static void Main(string[] args)
        {

            WorkoutSession SessionOne = new WorkoutSession("Cardio. ", 30, false);
            WorkoutSession SessionTwo = new WorkoutSession("Sit-ups till failure. ", 30, false);
            WorkoutSession SessionThree = new WorkoutSession("Push-ups till failure. ", 30, false);

			Console.WriteLine("1. Display All\n2. Finished a Workout\n3. Exit Program");
			int choice = 0;

            while (choice != 3)
            {
                Console.Write("\nEnter Choice: ");
				choice = int.Parse(Console.ReadLine());

				switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nSession 1:");
                        SessionOne.DisplayInfo();

                        Console.WriteLine("\nSession 2:");
                        SessionTwo.DisplayInfo();

                        Console.WriteLine("\nSession 3:");
                        SessionThree.DisplayInfo();
                        break;

                    case 2:
                        Console.WriteLine("Select session to update (1-3): ");
                        int secondChoice = int.Parse(Console.ReadLine());

                        switch (secondChoice) 
                        {
                            case 1:
                                SessionOne.FinishWorkout();
                                Console.WriteLine("Session 1 updated.");
                                break;
							case 2:
								SessionTwo.FinishWorkout();
								Console.WriteLine("Session 2 updated.");
								break;
							case 3:
								SessionThree.FinishWorkout();
								Console.WriteLine("Session 3 updated.");
								break;
                            default:
                                Console.WriteLine("ERROR: Invalid Option");
                                break;
						}
                        break;

                    case 3:
                        Console.WriteLine(""
            }
        }
    }
}
