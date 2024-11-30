namespace AllLoopTypes
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Demonstrating different types of loops in C#:");
                Console.WriteLine("============================================");

                // 1. While Loop Example
                Console.WriteLine("\n1. While Loop Example: Counting Down with Break");
                CountDownUsingWhileWithBreak();

                // 2. Do-While Loop Example: Validating User Input
                Console.WriteLine("\n2. Do-While Loop Example: Validating User Input");
                GetUserInputUsingDoWhile();

                // 3. For Loop Example
                Console.WriteLine("\n3. For Loop Example: Skipping Numbers with Continue");
                SkipNumbersUsingFor();

                // 4. Foreach Loop Example
                Console.WriteLine("\n4. Foreach Loop Example: Breaking on Specific Item");
                BreakInForeachLoop();

                // 5. ATM PIN Validation Example
                Console.WriteLine("\n5. Do-While Loop Example: ATM PIN Validation");
                ValidatePinUsingDoWhile();

                Console.WriteLine("\nProgram completed successfully!");
            }

            static void CountDownUsingWhileWithBreak()
            {
                int counter = 5;

                while (counter > 0)
                {
                    Console.WriteLine("Countdown: " + counter);
                    counter--;

                    if (counter == 2)
                    {
                        Console.WriteLine("Countdown stopped early!");
                        break; // Exit the loop when the counter reaches 2
                    }
                }

                Console.WriteLine("Blastoff!");
            }

            static void GetUserInputUsingDoWhile()
            {
                int number;

                do
                {
                    Console.Write("Enter a positive number (or 0 to quit): ");
                    number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        Console.WriteLine("Negative numbers are not allowed. Try again.");
                        continue; // Skip the rest of the loop for invalid input
                    }

                    if (number > 0)
                    {
                        Console.WriteLine("You entered: " + number);
                    }

                } while (number != 0);

                Console.WriteLine("You have exited the loop.");
            }

            static void SkipNumbersUsingFor()
            {
                Console.WriteLine("Skipping multiples of 3 between 1 and 10:");

                for (int i = 1; i <= 10; i++)
                {
                    if (i % 3 == 0)
                    {
                        continue; // Skip the current iteration for multiples of 3
                    }

                    Console.WriteLine("Number: " + i);
                }
            }

            static void BreakInForeachLoop()
            {
                List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

                Console.WriteLine("Iterating over a collection of fruits and stopping at 'Cherry':");

                foreach (string fruit in fruits)
                {
                    if (fruit == "Cherry")
                    {
                        Console.WriteLine("Found 'Cherry', stopping the loop!");
                        break; // Exit the loop when "Cherry" is found
                    }

                    Console.WriteLine("Fruit: " + fruit);
                }
            }

            static void ValidatePinUsingDoWhile()
            {
                const string correctPin = "1234";
                string enteredPin;
                int attempts = 0;
                const int maxAttempts = 3;

                do
                {
                    Console.Write("Enter your PIN: ");
                    enteredPin = Console.ReadLine();
                    attempts++;

                    if (enteredPin == correctPin)
                    {
                        Console.WriteLine("Access granted!");
                        return; // Exit the method if the correct PIN is entered
                    }
                    else
                    {
                        Console.WriteLine("Incorrect PIN. Try again.");
                    }
                } while (attempts < maxAttempts);

                Console.WriteLine("Too many failed attempts. Access denied.");
            }
        }
    }
