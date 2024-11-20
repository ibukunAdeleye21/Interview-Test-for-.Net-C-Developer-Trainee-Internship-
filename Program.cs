namespace DEVELOPER_TEST_.NET_C___ADELEYE_IBUKUN_JOHN_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an array and fill it
            int[] myArray = { 2, 4, 6, 8, 10 };

            // TASK 1 : Print Variable values
            PrintVariableValues();

            // TASK 2 : Check if a numnber is even or odd
            CheckEvenOrOdd();

            // TASK 3 : Print numbers from 1 to 10
            PrintNumbers();

            // TASK 4 : Calculate and print the sum of an array
            CalculateArraySum(myArray);
            PrintArrayElements(myArray);

            // TASK 5 : Greet User
            Greet("Alice");
            
        }

        // TASK 1: Print the Variable values
        static void PrintVariableValues()
        {
            // assign each variables to a value
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            // print values of the variable to the console
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("isAdmin: " + isAdmin);
        }

        // TASK 2: Check if a number is even or odd
        static void CheckEvenOrOdd()
        {
            Console.WriteLine("Please enter an integer number below: ");
            string stringUserInput = Console.ReadLine();

            try
            {
                // Convert the string input to int 
                int intUserInput = Convert.ToInt32(stringUserInput);

                // conditional statement to check if the number is zero(0)
                if (intUserInput == 0)
                {
                    Console.WriteLine("Zero is neither even nor odd");
                }
                // conditional statement to check if the number is a negative number(e.g. -1, -2)
                else if (intUserInput < 0)
                {
                    Console.WriteLine("Negative numbers are not classified as even or odd.");
                }
                // conditional statement to check if the number is a positive number (e.g. 1,2,3,4)
                else
                {
                    // when the number is divided by two and it has no reminder then print even
                    if (intUserInput % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    // print odd when the number is divided by two and it has a reminder
                    else
                    {
                        Console.WriteLine("Odd");
                    }
                }

            }
            // a catch statement to give a message when the input cannot be converted to an integer
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // TASK 3 : Print numbers from 1 to 10
        static void PrintNumbers()
        {
            for (int num = 1; num <= 10; num++)
            {
                // Print each number to the console
                Console.WriteLine(num);
            }
        }

        // TASK 4 : Calculate and print the sum of an array
        static void CalculateArraySum(int[] myArray)
        {
            // Initialize a variable to hold the total number and set it to zero
            int totalNumber = 0;

            // loop through the array
            for (int i = 0; i < myArray.Length; i++)
            {
                // update the totalNumber by adding it to each number in the array.
                totalNumber += myArray[i];
            }

            Console.WriteLine($"The sum of all elements in the array is: {totalNumber}");
        }

        static void PrintArrayElements(int[] myArray)
        {
            // print out all the elements of myArray using forEach
            foreach (int num in myArray)
            {
                Console.WriteLine(num);
            }
        }

        // TASK 5 : Greet User

        // create the method named "Greet
        static void Greet(string name)
        {
            Console.WriteLine("Hello");
        }
    }
}
