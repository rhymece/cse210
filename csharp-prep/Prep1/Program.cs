using System;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        // CODE BELOW IS FOR PREP #1 - VARIABLE INPUT, OUTPUT
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
        
        
        // CODE BELOW IS FOR PREP #2 - CONDITIONALS ---------------------------------------------------
        Console.Write("Enter your Grade percentage: ");
        string grade = Console.ReadLine();
        int grade_num = int.Parse(grade);

        string Letter = "";

        if (grade_num >= 90) {
            Letter = "A";
        } 
        else if (grade_num >= 80){
            Letter = "B";
        }
        else if (grade_num >= 70){
            Letter = "C";
        }
        else if (grade_num >= 60){
            Letter = "D";
        }
        else {
            Letter = "F";
        }

        Console.WriteLine($"You Grade is: {Letter}.");

        if (grade_num >= 70){
            Console.WriteLine("Congratularions! You pass.");
        }
        else {
            Console.WriteLine("Let's do it next time!");
        }
        



        // CODE BELOW IS FOR PREP 3 - LOOPS ---------------------------------------------------------------------
        string response = "";
        string correct = "no";
        
        //Console.Write("What is the magic number? ");
        //string magic = Console.ReadLine();
        //int magic_num = int.Parse(magic);

        Random numberGenerator = new Random();
        int magic_num = numberGenerator.Next(1, 100);
        Console.WriteLine("Guessing game! Try to guess the magic number.");

        do  {
            Console.Write("What is your Guess number? ");
            string guess = Console.ReadLine();
            int guess_num = int.Parse(guess);

            if (guess_num == magic_num) {
                response = "You guessed it!";
                correct = "yes";
            }
            else if (guess_num > magic_num){
                response = "Lower it";
            }
            else {
                response = "Higher it!";
            }
            Console.WriteLine($"{response}");
        } while (correct != "yes");
        
        
        Console.WriteLine($"Magic number is: {magic_num}");
       

        // CODE BELOW IS FOR PREP 4 - LIST -----------------------------------------------------------------------

        List<int> in_num = new List<int>(); 
        int number = 1;
        int total = 0;
        int LargeNum = 0;
        

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do {
        Console.Write("Enter number: ");
        string num = Console.ReadLine();
        number = int.Parse(num);
        if (number != 0){
            in_num.Add(number);
        }
        } while (number != 0);  

        for (int i = 0; i < in_num.Count; i++ ){
            total += in_num[i];
            
            if (in_num[i] > in_num[0]) {
                LargeNum = in_num[i];
            }

        }


        float list_size = in_num.Count;
        double average = Math.Round(total / list_size, 3);


        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {LargeNum}");
       
        in_num.Sort();

        Console.WriteLine("The sorted list is: ");
        foreach (int num_list in in_num) {
            Console.WriteLine(num_list);
        }
        



   
        // CODE BELOW IS FOR PREP 5 - FUNCTIONS ----------------------------------------------------------
        DisplayWelcome();
        string name = PromptUserName();
        int User_number = UserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);

    }
    static void DisplayWelcome(){
            Console.WriteLine("Welcome to the program!");
        }
    static string PromptUserName(){
        Console.Write("Enter your name: ");
        string UserName = Console.ReadLine();
        return UserName;
    }
    static int UserNumber(){
        Console.Write("Please enter your favorite number: ");
        int InNumber = int.Parse(Console.ReadLine());
        
        return InNumber;
    }
    static int SquareNumber(int num){
        int square_num = num * num;

        return square_num;
    }
    static void DisplayResult(string name, int squareNum){
        Console.WriteLine($"{name}, the square of your number is {squareNum}.");
    }

 
    
}