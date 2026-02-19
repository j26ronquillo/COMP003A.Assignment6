namespace COMP003A.Assignment6
{
    class WorkoutSession
    {
        //Theme B Fitness Session Planner

            public string Name;
            public int Age;
            public bool Workout;

            public WorkoutSession(string name, int age, bool workout)
            {
                Name = name;
                Age = age;
                Workout = workout;
            }

        public void DisplayInfo()
        {
            Console.WriteLine($""
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("1. Display All\n2. Finished a Workout\n3. Exit Program");
        }
    }
}
