using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersizes_in_class
{
    class Program
    {
        static void Main(string[] args)
        {


            #region 2dim multiplication

            //Create multiplication table using 2-D array

            int[,] multiplication = new int[10, 10];

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    multiplication[i - 1, j - 1] = i * j;
                }
            }

            for (int i = 0; i < multiplication.GetLength(0); i++)
            {
                for (int j = 0; j < multiplication.GetLength(1); j++)
                {
                    Console.Write(multiplication[i, j] + "\t");
                }
                Console.WriteLine();
            }

            #endregion

            #region HW Qst 2

            //Define array and variables for the game

            int[] guessArr = new int[10] { 2, 5, 4, 12, 9, 17, 20, 13, 6, 10 };
            int counter = 0;
            int guessNum;
            int firstValue;

            // Guessing game - need to guess the next variable in array
            // no limited attempts

            while (true)
            {
                Console.WriteLine("Try to guess the first value in GuessArr!\nEnter number (1-20):\n");
                guessNum = int.Parse(Console.ReadLine());
                firstValue = Array.IndexOf(guessArr, guessNum);

                if (firstValue == 0)
                {
                    counter++;
                    break;
                }
                else
                {
                    counter++;
                    Console.WriteLine("Nop, try again");
                }
            }
            Console.WriteLine($"Congrate! you found the first value in {counter} attempts!");
            Console.ReadLine();

            #endregion

            #region HW Qst 2 Challenge

            // Create an array with numbers and variables for the game

            int[] guessArr1 = new int[10] { 2, 5, 4, 12, 9, 17, 20, 13, 6, 10 };
            int counter1 = 0;
            int totalCount = 0;
            int guessNum1, value;

            // Guessing game - need to guess the next variable in array from the first
            // Only 30 attempts - not as easy as seem

            for (int i = 0; i < guessArr1.Length && totalCount < 30; i++)
            {
                while (totalCount < 30)
                {
                    Console.WriteLine("Try to guess the first value in GuessArr!\nEnter number (1-20):\n");

                    guessNum1 = int.Parse(Console.ReadLine());
                    value = Array.IndexOf(guessArr1, guessNum1);
                    if (value == i)
                    {
                        counter1++;
                        Console.WriteLine($"You found value number {i + 1} in {counter1} attempts!");
                        totalCount += counter1;
                        counter1 = 0;
                        break;
                    }
                    else
                    {
                        counter1++;
                        totalCount += counter1;
                        counter1 = 0;
                        Console.WriteLine("Nop, try again!");
                    }

                }
                if (totalCount == 30)
                {
                    break;
                }
            }
            if (totalCount == 30)
            {
                Console.WriteLine("Sorry, you reach all 30 attempts!\nGame Over!");
            }
            else
            {
                Console.WriteLine($"Well done! you found all values in {totalCount} attempts!");
            }
            Console.ReadLine();

            #endregion

            #region HW Qst 3

            // Create matrix by sisyphean work
           
            int[,] matrixGuess = new int[5, 5]
            {
                {1, 4, 5, 7, 3 },
                {3, 6, 7, 7, 8 },
                {6, 7, 4, 2, 3 },
                {3, 5, 9, 3, 6 },
                {9, 6, 4, 2, 5 }
            };

            // Create guessing game - user need to insert number
            // If number exist - it will print all indexes, if not - print nothing

            int guess;
            string[] countArr = new string[25];
            int count = 0;

            Console.WriteLine("Guess number (1-10):\n");
            guess = int.Parse(Console.ReadLine());

            for (int i = 0; i < matrixGuess.GetLength(0); i++)
            {
                for (int j = 0; j < matrixGuess.GetLength(1); j++)
                {
                    if (guess == matrixGuess[i, j])
                    {
                        countArr[count] = $"In place [{i},{j}]";
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine();
            }
            else
            {
                for (int x = 0; x <= count; x++)
                {
                    Console.WriteLine(countArr[x]);
                }
            }
            Console.ReadLine();
            #endregion

            #region using random

            // Just tried 'Random' for the first time

            int[,] arrr = new int[5, 5];

            Random random = new Random();

            for (int i = 0; i < arrr.GetLength(0); i++)
            {
                for (int j = 0; j < arrr.GetLength(1); j++)
                {
                    arrr[i, j] = random.Next(2);
                }
            }
            for (int i = 0; i < arrr.GetLength(0); i++)
            {
                for (int j = 0; j < arrr.GetLength(1); j++)
                {
                    Console.Write(arrr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Read();

            #endregion

            #region Submarine Challenge

            // Create a submarine game
            // First define matrix pointer as a game board and 'random' variable

            int[,] submarine = new int[3, 3];
            Random random1 = new Random();

            // Fill variable 0 or 1 using 'Random'

            for (int i = 0; i < submarine.GetLength(0); i++)
            {
                for (int j = 0; j < submarine.GetLength(1); j++)
                {
                    submarine[i, j] = random1.Next(2);
                }
            }

            // Define variable for the loop

            bool tnai = true; // keeping the game on!
            int counting = 0; // counting attempts
            int partyPoper = 0; // as it is - destroy the fun - ending the game

            // Get row and column from user and check:
            // 1 - submarine - 'Boom!', 0 - non - 'Miss!'
            
            while (tnai)
            {

                Console.WriteLine("Choose number of row (1-3):\n");
                int rowChoice = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose number of column (1-3):\n");
                int colChoice = int.Parse(Console.ReadLine());

                if (submarine[rowChoice - 1, colChoice - 1] == 1)
                {
                    Console.WriteLine("Boom!");
                    submarine[rowChoice - 1, colChoice - 1] = 0;
                    counting++;
                }
                else if (submarine[rowChoice - 1, colChoice - 1] == 0)
                {
                    Console.WriteLine("Miss!");
                    counting++;
                }

                for (int i = 0; i < submarine.GetLength(0); i++)
                {
                    for (int j = 0; j < submarine.GetLength(1); j++)
                    {
                        if (submarine[i, j] == 1)
                        {
                            break;
                        }
                        else
                        {
                            partyPoper++;
                        }
                    }
                }
                if (partyPoper == submarine.Length)
                {
                    tnai = false;
                }
                else
                {
                    partyPoper = 0;
                }
            }
            Console.WriteLine($"The game ended after {counting} attempts");
            Console.Read();

            #endregion

            #region HW Qst 6

            // Create a 3-D array and get variable from user

            int[,,] myThreeDimArr = new int[2, 3, 4];

            for (int i = 0; i < myThreeDimArr.GetLength(0); i++)
            {
                for (int j = 0; j < myThreeDimArr.GetLength(1); j++)
                {
                    for (int h = 0; h < myThreeDimArr.GetLength(2); h++)
                    {
                        Console.WriteLine("Enter value: ");

                        myThreeDimArr[i, j, h] = int.Parse(Console.ReadLine());
                    }
                }
            }

            #endregion

            #region HW Qst 7

            // Create an asterisks matrix

            string[,] kochava = new string[6, 4];

            for (int i = 0; i < kochava.GetLength(0); i++)
            {
                for (int j = 0; j < kochava.GetLength(1); j++)
                {
                    kochava[i, j] = "* ";
                    Console.Write(kochava[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            #endregion

            #region HW Qst 8

            // create jagged array pointer

            int[][] myJaggArr = new int[4][];

            int dim;
            int row = 0;

            // Insert variable by user, using while and for loops

            while (row < myJaggArr.GetLength(0))
            {
                Console.WriteLine($"Enter colomn length for row number {row}: ");
                dim = int.Parse(Console.ReadLine());
                myJaggArr[row] = new int[dim];

                for (int i = 0; i < dim; i++)
                {
                    Console.WriteLine($"Enter value number {i}: ");
                    myJaggArr[row][i] = int.Parse(Console.ReadLine());
                }
                row++;
            }

            // Print the array

            for (int i = 0; i < myJaggArr.GetLength(0); i++)
            {
                for (int j = 0; j < myJaggArr[i].Length; j++)
                {
                    Console.Write(myJaggArr[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Read();

            #endregion

            #region HW Qst 9 - Challenge
            
            // define variables and get number of classes from user (number of rows)

            float sum = 0;
            Console.WriteLine("Please enter number of classes: ");
            int classes = int.Parse(Console.ReadLine());
            float[] avgs = new float[classes];

            // Get number of students in each class from user (length of each row)

            int[][] myGrades = new int[classes][];
            for(int i = 0; i < myGrades.GetLength(0); i++)
            {
                Console.WriteLine($"Please enter number of students in class number {i}: ");
                int students = int.Parse(Console.ReadLine());
                myGrades[i] = new int[students];
            }
            
            // Get grade for each student from user (variables in each index)

            for(int i = 0; i < myGrades.GetLength(0); i++)
            {
                for (int j = 0; j < myGrades[i].Length; j++)
                {
                    Console.WriteLine($"Grade of student number {j}: ");
                    myGrades[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Calculate average of each class (insert each average in array called 'avgs')

            for(int row1 = 0; row1 < myGrades.GetLength(0); row1++)
            {
                for(int col = 0; col < myGrades[row1].Length; col++)
                {
                    sum += myGrades[row1][col];
                }
                float avg = sum / myGrades[row1].Length;
                sum = 0;
                Console.WriteLine($"The grades average of class {row1} is: {avg}");
                avgs[row1] = avg;
            }

            // Find the biggest average and declare on it

            float biggest = avgs.Max();
            int classNum = Array.IndexOf(avgs, biggest);
            Console.WriteLine($"The with the highest average is class number {classNum} and the average is {biggest}");
            
            Console.ReadLine();

            #endregion

        }
    }
}
