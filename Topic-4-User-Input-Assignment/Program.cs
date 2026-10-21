namespace Topic_4_User_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your part (Ideally start from 1):");
            Console.WriteLine();
            Console.WriteLine("1-Basic conversation.");
            Console.WriteLine("2-Totally legal data collection.");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (choice == 1)
            {
                Part1();
            }
            else if (choice == 2)
            {
                Part2();
            }
        }
        //Console.WriteLine("Assignment by Easton Powers");
        //Console.WriteLine("User inputs name, age and salary");
        public static void Part1()
        {
            string username;
            int age;
            double wage;
            Console.Write("I am Program.cs. What is your name? (PLEASE INPUT NAME): ");
            username = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
            Console.Write("What's up, " + username);
            Console.WriteLine("?");
            Console.WriteLine();
            Console.WriteLine("How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            Console.Write("Congrats on being " + age);
            Console.WriteLine(" !");
            Console.WriteLine();
            Console.Clear();
            Console.Write("Mind me asking how much you make at " + age);
            Console.Write(", " + username);
            Console.WriteLine("?");
            Console.WriteLine("(Please add a dollar and cent amount. Ex 13.50)");
            wage = Convert.ToDouble(Console.ReadLine());
            //Int32.TryParse(Console.ReadLine(), out age);
            Console.Write("Woah you make " + wage.ToString("C"));
            Console.Write(" at ");
            Console.WriteLine( age + "?");
            Console.WriteLine("I hope that's per hour and not per day. Good on you regardless, " + username);
            Console.WriteLine("Press Enter To Quit");
            Console.ReadLine();
            Console.Clear();
        }
        //Console.WriteLine("User inputs ");
        public static void Part2()
        {
            string firstname;
            string lastname;
            int year;
            int ID;
            string login;
            double average;
            Console.WriteLine("This is a government data collection program. (Press Enter To Continue Dialogue)");
            Console.WriteLine();
            Console.WriteLine("It is designed to keep as much surveillance as possible on the population of Parkside.");
            Console.WriteLine();
            Console.WriteLine("Please enter your firstname. (False aliases will NOT be tolerated.)");
            firstname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Thank you for your cooperation " + firstname);
            Console.Clear();
            Console.WriteLine("Now your legal lastname.");
            lastname = Console.ReadLine();
            Console.Clear();
            Console.Write(firstname);
            Console.Write(" ");
            Console.Write(lastname);
            Console.WriteLine("... Interesting.");
            Console.WriteLine();
            Console.Write("And what grade are you in " + firstname);
            Console.Write(" ");
            Console.Write(lastname);
            Console.WriteLine("?");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Only grade " + year);
            Console.WriteLine("? I Thought You Were Older.");
            Console.WriteLine();
            Console.WriteLine("Im gonna need proof. Enter your student ID:");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write(ID);
            Console.WriteLine("? Let me run that through the system.");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Info checks out. You're lucky. We're almost done here. I just need a few more things.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter your school login.");
            login = Console.ReadLine();
            Console.Clear();
            Console.Write(login);
            Console.WriteLine(". Very intriguing login.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Final piece of information:");
            Console.WriteLine("What is your percent average this year?");
            average = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Here is an overview of your provided information:");
            Console.WriteLine("Student Information:");
            Console.WriteLine("Student Login: " + login);
            Console.WriteLine("Identification: " + ID);
            Console.Write("Student Name: " + lastname);
            Console.Write(", ");
            Console.WriteLine(firstname);
            Console.WriteLine("Student % AVG: " + average);
            Console.WriteLine("Student Grade: " + year);
        }
    }
}
    
    

