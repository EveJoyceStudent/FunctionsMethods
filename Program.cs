using System;
using System.Collections.Generic;

namespace FunctionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a program in C# Sharp to create a user define function. 
            // Expected Output : 
            // Welcome Friends! 
            // Have a nice day!

            Console.WriteLine("I will greet you (with a function);");
            Welcome();


            // 2. Write a program in C# Sharp to create a user define function with parameters. 
            // Test Data : 
            // Please input a name : John 
            // Expected Output : 
            // Welcome friend John ! 
            // Have a nice day!

            Console.WriteLine("Enter your name and I will greet you;");
            Console.Write("Enter Name: ");
            WelcomeName(Console.ReadLine());


            // 3. Write a program in C# Sharp to create a function for the sum of two numbers. 
            // Test Data : 
            // Enter a number: 15 
            // Enter another number: 16 
            // Expected Output : 
            // The sum of two numbers is : 31
            
            Console.WriteLine("Enter two numbers and I will sum them;");
            Console.Write("Enter a number: ");
            int sumNumber1 = NumberInput();
            Console.Write("Enter another number: ");
            int sumNumber2 = NumberInput();
            SumNumbers(sumNumber1,sumNumber2);


            // 4. Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string. 
            // Test Data : 
            // Please input a string : This is a test string. 
            // Expected Output : 
            // "This is a test string." contains 4 spaces

            Console.WriteLine("Enter some text and i'll tell you how many spaces are in it;");
            Console.Write("Enter Text: ");
            string inputText = Console.ReadLine();
            Console.WriteLine("There were "+SpacesInString(inputText)+" spaces in your text");


            // 5. Write a program in C# Sharp to calculate the sum of elements in an array. 
            // Test Data : 
            // Input 5 elements in the array : 
            // element - 0 : 5 
            // element - 1 : 7 
            // element - 2 : 3 
            // element - 3 : 2 
            // element - 4 : 9 
            // Expected Output : 
            // The sum of the elements of the array is 26

            Console.WriteLine("Input 5 elements in the array and i will sum them;");
            int [] userArray = IntArrayInput(5);
            Console.WriteLine("The sum of the elements in the array is "+SumOfArrayElements(userArray));


            // 6. Write a program in C# Sharp to create a function to swap the values of two integer numbers. 
            // Test Data : 
            // Enter a number: 5 
            // Enter another number: 6 
            // Expected Output : 
            // Now the 1st number is : 6 , and the 2nd number is : 5

            Console.WriteLine("Enter two numbers and I will swap them around;");
            Console.Write("Enter a first number: ");
            int numberSwap1=NumberInput();
            Console.Write("Enter a second number: ");
            int numberSwap2=NumberInput();
            Console.WriteLine("The first number is "+numberSwap1+", and the second number is "+numberSwap2);
            SwapTwoIntegers(ref numberSwap1, ref numberSwap2);
            Console.WriteLine("The first number is "+numberSwap1+", and the second number is "+numberSwap2);


            // 7. Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another. 
            // Test Data : 
            // Input Base number: 3 
            // Input the Exponent : 2 
            // Expected Output : 
            // So, the number 3 ^ (to the power) 2 = 9
            
            Console.WriteLine("Enter two numbers and I will calculate the first number to the power of the second number;");
            Console.Write("Enter a base number: ");
            int baseInput=NumberInput();
            Console.Write("Enter an exponent number: ");
            int exponentInput=NumberInput();
            Console.WriteLine(baseInput+" ^ "+exponentInput+" = "+Exponentiation(baseInput,exponentInput));


            // 8. Write a program in C# Sharp to create a function to display the n number Fibonacci sequence. 
            // Test Data : 
            // Input number of Fibonacci Series : 5 
            // Expected Output : 
            // The Fibonacci series of 5 numbers is : 
            // 0 1 1 2 3

            Console.WriteLine("I will write some Fibonacci numbers for you;");
            Console.Write("Enter how many Fibonacci numbers you would like: ");
            int fibonacciInput=NumberInput();
            // this overflows at Fibonacci 47... oh well
            Fibonacci(fibonacciInput);
            Console.WriteLine();


            // 9. Write a program in C# Sharp to create a function to check whether a number is prime or not. 
            // Test Data : 
            // Input a number : 31 
            // Expected Output : 
            // 31 is a prime number
            
            Console.WriteLine("Enter a number you would like to test for primeness; ");
            Console.Write("Enter a Number: ");
            int primeInput=NumberInput();
            if(isPrime(primeInput)){
                Console.WriteLine(primeInput+" is a prime number");
            } else {
                Console.WriteLine(primeInput+" is not a prime number");
            }

            // 10. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. 
            // Test Data : 
            // Enter a number: 1234 
            // Expected Output : 
            // The sum of the digits of the number 1234 is : 10

            Console.WriteLine("Enter a number and I will sum its digits;");
            Console.Write("Enter a number: ");
            // i used NumberInput() to make sure a number was input but it uses int32 so only works to 2,147,483,647, would be better to check each substring is a digit
            string stringSumInput=Convert.ToString(NumberInput());
            Console.WriteLine("The sum of the digits of the number "+stringSumInput+" is: "+stringSum(stringSumInput));

            // 11. (Optional) Write a program in C# Sharp to create a recursive function to find the factorial of a given number. 
            // Test Data : 
            // Enter a number: 5 
            // Expected Output : 
            // The factorial of 5! is 120 
            
            Console.WriteLine("Enter a number and I will find its factorial;");
            Console.Write("Enter a positive integer: ");
            int factorialInput=NumberInput();
            Console.WriteLine(factorialInput+"! equals "+FactorialFunction(factorialInput));
            

            // 12. (Optional)  Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term. 
            // Test Data : 
            // Enter a number: 10 
            // Expected Output : 
            // The Fibonacci of 10 th term is 55 

            Console.WriteLine("Enter a positive integer you would like the (F(1)=0) Fibonacci number of; ");
            Console.Write("Enter a number: ");
            int fibonacciRecursiveInput=NumberInput();
            Console.WriteLine("The "+fibonacciRecursiveInput+"th Fibonacci number is "+FibonacciRecursive(fibonacciRecursiveInput));


            Console.WriteLine("End!");
        }
        static void Welcome(){
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!");
        }
        static void WelcomeName(string input){
            Console.WriteLine("Welcome friend "+input+"!");
            Console.WriteLine("Have a nice day!");
            // Please input a name : John 
            // Expected Output : 
            // Welcome friend John ! 
            // Have a nice day!
        }
        static int NumberInput(){
            string NumberInput = Console.ReadLine();
            int intNumberInput;
            while(!int.TryParse(NumberInput, out intNumberInput))
            {
                Console.Write("Sorry, I didn't understand that, please enter whole number as a numeral: ");
                NumberInput = Console.ReadLine();
            }
            return intNumberInput;
        }
        static void SumNumbers(int i, int j){
            Console.WriteLine("The sum of two numbers is: "+(i+j));
        }

        static int SpacesInString(string input){
            string[] subs = input.Split(' ');
            return subs.Length-1;
        }

        static int[] IntArrayInput(int arrayLength){
            int[] intArray = new int[arrayLength];
            for(int i = 0; i < arrayLength; i++){
                Console.Write("element - "+i+":");
                intArray[i] = NumberInput();
            }
            return intArray;
        }

        static int SumOfArrayElements(int[] inputArray){
            int sumCounter=0;
            for(int i = 0; i < inputArray.Length; i++){
                sumCounter += inputArray[i];                
            }
            return sumCounter;
        }

        static void SwapTwoIntegers(ref int inputNumber1, ref int inputNumber2){
            int newNumber1=inputNumber2;
            int newNumber2=inputNumber1;
            inputNumber1 = newNumber1;
            inputNumber2 = newNumber2;
        }

        static int Exponentiation(int baseNumber, int exponent){
            int product = 1;
            for(int i = 0; i < exponent; i++){
                product = product * baseNumber;
            }
            return product;
        }

        static void Fibonacci(int n){
            List<int> fibSeq = new List<int>();
            fibSeq.Add(0);
            fibSeq.Add(1);
            for(int i=0; i<n; i++){
                // add another fib number (two ahead of where we are)
                fibSeq.Add(fibSeq[fibSeq.Count-1]+fibSeq[fibSeq.Count-2]);
                // write the current fib number
                Console.Write(fibSeq[i]+" ");
            }
        }

        static bool isPrime(int number){
            bool boolIsPrime=true;
            for(int i=2; i<=Math.Sqrt(number);i++){
                if(number % i == 0){
                    boolIsPrime=false;
                    break;
                }
            }
            return boolIsPrime;
        }

        // Test Data : 
        // Enter a number: 1234 
        // Expected Output : 
        // The sum of the digits of the number 1234 is : 10
        static int stringSum(string inputString){
            int sumValue=0;
            for(int i = 0; i < inputString.Length; i++){
                sumValue += Convert.ToInt32(inputString.Substring(i,1));
            }
            return sumValue;
        }

        // 11. (Optional) Write a program in C# Sharp to create a recursive function to find the factorial of a given number. 
        // Test Data : 
        // Enter a number: 5 
        // Expected Output : 
        // The factorial of 5! is 120 
        static int FactorialFunction(int input){
            if (input<=1){
                return 1;
            } else {
                return input * FactorialFunction(input-1);
            }
        }

        static int FibonacciRecursive(int input){
            // if you're at the first Fibonacci number, that's 0
            if(input<=1){
                return 0;
            } else {
                //if you're at the second, that's 1
                if(input==2){
                    return 1;
                } 
                // otherwise, a Fibonacci number is the sum of the two previous Fibonacci numbers
                else {
                    return FibonacciRecursive(input-1)+FibonacciRecursive(input-2);
                }
            }
        }

    }
}
