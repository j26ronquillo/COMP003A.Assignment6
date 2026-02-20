namespace COMP003A.Assignment6
{
    class WorkoutSession
    {
        //Theme B Fitness Session Planner

            public string Name;
            public int Duration;
            public bool Workout;
		// This class models a fitness workout session that the user schedules.
		public WorkoutSession(string name, int duration, bool workout)
        {
            Name = name; // Name of the workout
			Duration = duration; // Duration of the workout in minutes
			Workout = workout; // Indicates whether the workout is completed
		}

        public void DisplayInfo() // Constructor initializes all fields when a new workout session is created.
		{
            Console.Write($"Name: " + Name);
			Console.Write($"Workout: " + Duration + " minutes. ");
			Console.Write($"Completed: " + Workout + "\n");
		} 

        public void FinishWorkout() // Marks the workout as completed.
		{
            Workout = true;
        }

        static void Main(string[] args)
        {
			// This program allows the user to manage multiple workout sessions using a menu system.
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
                        Console.Write("\nSelect session to update (1-3): ");
                        int secondChoice = int.Parse(Console.ReadLine());

                        switch (secondChoice)
                        {
                            case 1:
                                SessionOne.FinishWorkout();
                                Console.WriteLine("\nSession 1 updated.");
                                break;
                            case 2:
                                SessionTwo.FinishWorkout();
                                Console.WriteLine("\nSession 2 updated.");
                                break;
                            case 3:
                                SessionThree.FinishWorkout();
                                Console.WriteLine("\nSession 3 updated.");
                                break;
                            default:
                                Console.WriteLine("\nERROR: Invalid Option");
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Program ended. Thank you!");
                        break;

                    default:
                        Console.WriteLine("ERROR: Invalid Option");
                        break;
                }
            }
        }
    }
}
