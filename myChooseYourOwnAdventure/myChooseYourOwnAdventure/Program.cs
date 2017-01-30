using System;
using System.Threading;

namespace myChooseYourOwnAdventure
{
    class Program
    {

        public static void setup(string version)
        {
            var consoleTitle = "Swords & Castles [v:" + version + "]";
            Console.Title = consoleTitle;
        }
        
        public static void welcome()
        {
            Console.Write("Welcome ");
            Sleep(10);
            Console.Write("to ");
            Sleep(10);
            Console.Write("Swords ");
            Sleep(10);
            Console.Write("And ");
            Sleep(10);
            Console.WriteLine("Castles");
            Sleep(100);
            Console.WriteLine("Press Any Key To Continue");
        }

        static void Sleep(int mSecs)
        {
            Thread.Sleep(mSecs);
        }

        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("hello world!");
            Console.WriteLine("Press any key to start!");
=======
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            welcome();
>>>>>>> origin/master
            Console.ReadKey();
            Console.WriteLine("Welcome to the best game on planet e-arrth! Please type your name!");
            var userName = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + userName + "!");
        SelectWarrior:
            #region SelectWarrior
            Console.WriteLine("Are you an archer(type 1) or a swordsman(type 2)?");
            ConsoleKeyInfo warriorInput = Console.ReadKey();
            var warriorType = "";
            var warriorWeapon = "";

            if (warriorInput.KeyChar == '1')
            {
                warriorType = "archer";
                warriorWeapon = "bow and arrow";
            }
            else if (warriorInput.KeyChar == '2')
            {
                warriorType = "swordsman";
                warriorWeapon = "sword";
            }
            else
            {
                Console.Clear();
                Console.WriteLine("please select a valid option");
                goto SelectWarrior;
            }
            #endregion

            Console.WriteLine("Ah... a new " + warriorType + "... Good Choice.");
            Console.ReadKey();
            Console.WriteLine("Here is your " + warriorWeapon);
            Console.ReadKey();
            
        SelectActivity:
            Console.WriteLine("Would you like to practice with your " + warriorWeapon + " (1) or get to know people in town (2)");
            ConsoleKeyInfo activityInput = Console.ReadKey();
            var activityType = "";
            var activityTypeAction = "";

            if (activityInput.KeyChar == '1')
            {
                activityType = "practice";
                activityTypeAction = "You grab your " + warriorWeapon + "and begin to practice.";
            }
            else if (activityInput.KeyChar == '2')
            {
                activityType = "not practice";
                activityTypeAction = "You begin to walk around.";
            }
            else
            {
                Console.Clear();
                Console.WriteLine("please select a valid option");
                goto SelectActivity;
            }
            Console.WriteLine(activityTypeAction);
        }
    }
}
