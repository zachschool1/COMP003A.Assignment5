namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IntroductionMsg();

            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int inputAge = Convert.ToInt32(Console.ReadLine());

            ShowInfo(inputName, inputAge);

            double divisionAnswer = DoDivision(12, 4);
            Console.WriteLine($"Your divison answer is {divisionAnswer}");
           

        }

        static void IntroductionMsg()
        {
            Console.WriteLine("Hello! Welcome to the Program Organizer!");
        }

        static void ShowInfo(string name, int age)
        {
            Console.WriteLine($"Hello {name}, Your age is {age}.");
        }

        static double DoDivision(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
