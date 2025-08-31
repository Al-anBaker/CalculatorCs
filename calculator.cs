using System;
public class Calculator
{
    //Global Varibles
    public static int a = 0;
    public static int b = 0;
    public static int sum = 0;
    public static string operand = "";
    public static bool saved = false;
    public static bool useSaved = false;

    //This is the Main Method within the Calculator Class
    public static void Main(string[] args)
    {
        int i = 0;
        //Loop to keep program alive after sum displayed
        while(i != 55) {
            Console.Clear();
            //Asks the User what operation they would like to proform
            Console.WriteLine ("Would you like to (A)dd, (S)ubtract, (M)ultiply, (D)ivide, or (E)xit: ");
            Calculator.operand = Console.ReadLine();
            // If user selects Exit then set the break condition for the while loop and break out of the loop
            if (Calculator.operand == "E")
            {
                i = 55;
                Console.WriteLine("Thank you for using this Calculator");
                Console.Clear();
                break;
            }
            else {
            //Checks if user saved the output on a prev operation
            switch(Calculator.saved)
            {

                //if true ask they user if they would like to use the saved number
                case true:
                    Console.WriteLine("Saved Output found, would you like to use it (true, false): ");
                    Calculator.useSaved = Convert.ToBoolean(Console.ReadLine());
                    //if it is true then run Method that applys saved number
                    if (Calculator.useSaved = true) {
                        Saved();
                    }
                    // if user declines then run the normal operation
                    else {
                        normal();
                    }
                    break;
                    
                    
                // if cant find saved number then run normal operation
                case false:
                    normal();
                    break;
                }
            }
        }
    }
    //This Method takes in the operator and both inputted numbers labled as x and y
    public static int Calculate(string operation, int x, int y)
    {
        //Depending on what Operation the user uses switch between these cases
        switch(operation)
        {
            //if user selects addition, run this and return the addition between x, y
            case "A":
                Console.WriteLine(x +" + "+ y + " = ");
                return x + y;
            //if user selects subtraction, run this and return the subtraction between x, y
            case "S":
                Console.WriteLine(x +" - "+ y + " = ");
                return x - y;
            //if user selects Multiplication, run this and return the Multiplication between x, y
            case "M":
                Console.WriteLine(x +" * "+ y + " = ");
                return x * y;
            //if user selects Division, run this and return the Division between x, y
            case "D":
                Console.WriteLine(x +" / "+ y + " = ");
                return x / y;
        }
        return 0;
            

    }
    //This method runs the normal order of operations
    public static void normal() {
        //Ask the user what they want as their first number
        Console.WriteLine("Please enter Value of a: ");
        //Converts user input to int32 for the a varible
        Calculator.a = Convert.ToInt32(Console.ReadLine());
        //Ask the user what the second number should be
        Console.WriteLine("Please enter Value of b: ");
        //Converts User input to int32 from string
        Calculator.b = Convert.ToInt32(Console.ReadLine());
        //After asked numbers call the Calculate() varible with the supplied operation and both numbers and save the return value to sum
        Calculator.sum = Calculate(Calculator.operand, Calculator.a, Calculator.b);
        //Once saved Write sum to console
        Console.WriteLine(Calculate(Calculator.operand, Calculator.a, Calculator.b));
        //Then ask the user to save output
        Console.WriteLine("Would you like to save output?: ");
        //Takes user input to saved varible to be used on next operation
        Calculator.saved = Convert.ToBoolean(Console.ReadLine());
        return;
    }
    //This method runs if the user wanted to use a saved number
    public static void Saved() {
        //ask the user what value theyd like to replace with saved number
        Console.WriteLine("What value do you want to use the Saved Output for (A) or (B): ");
        string sValue = Console.ReadLine();
        //Switches depending on what value they wanted to swap
        switch (sValue)
        {
        //if A was selected then run through normal method but skip asking user for a input and replace it with sum
        case "A":
            Calculator.a = Calculator.sum;
            Console.WriteLine("A replaced with: " + Calculator.sum);
            Console.WriteLine("Please enter Value of b: ");
            Calculator.b = Convert.ToInt32(Console.ReadLine());
            Calculator.sum = Calculate(Calculator.operand, Calculator.a, Calculator.b);
            Console.WriteLine(Calculate(Calculator.operand, Calculator.a, Calculator.b));
            Console.WriteLine("Would you like to save output?: ");
            Calculator.saved = Convert.ToBoolean(Console.ReadLine());
            return;
        //If B was selected then run through normal method but skip asking user for b input and replace it with sum
        case "B":
            Calculator.b = Calculator.sum;
            //Tells user what B was swapped with
            Console.WriteLine("B replaced with: " + Calculator.sum);
            Console.WriteLine("Please enter Value of a: ");
            Calculator.a = Convert.ToInt32(Console.ReadLine());
            Calculator.sum = Calculate(Calculator.operand, Calculator.a, Calculator.b);
            Console.WriteLine(Calculate(Calculator.operand, Calculator.a, Calculator.b));
            Console.WriteLine("Would you like to save output?: ");
            Calculator.saved = Convert.ToBoolean(Console.ReadLine());
            return;
        }
    }
}