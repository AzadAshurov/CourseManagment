namespace CourseManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Course managment proggram \n");
            do
            {
                Console.WriteLine("Enter 1 for creating new class\n");

                switch (Console.ReadLine())
                {
                    default:
                        Console.WriteLine("No such operation, try again");
                        break;
                }

            }
            while (true);
        }
    }
}