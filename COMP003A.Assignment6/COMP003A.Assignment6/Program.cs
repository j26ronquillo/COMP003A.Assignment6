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
			Console.Write($"Name: " + Duration + "minutes");
			Console.Write($"Completed: " + Workout);
		} 

        public void FinishWorkout()
        {
            Workout = true;
        }

        static void Main(string[] args)
        {

            WorkoutSession sessionone = new WorkoutSession("Cardio", 30, false);
            WorkoutSession sessiontwo = new WorkoutSession("Sit-ups till failure", 30, false);
            WorkoutSession sessionthree = new WorkoutSession("Push-ups till failure", 30, false);

            {
                Console.WriteLine("1. Display All\n2. Finished a Workout\n3. Exit Program");
            }

            int choice = 0;
            while (choice != 1)
            {
                switch (choice) {
                    case 1:

            }

        }
    }
}
