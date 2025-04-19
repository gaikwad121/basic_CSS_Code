using System;
namespace project;
class Program
{
    // Check Odd or Even  
    static void Main()
    {
        //CheckOddEven();
        //printOddNum();
        //CountOddNum();
        //CountEven();
        // CountEvensum();
        // OddNumbers();
        // reverseNum();
        // palindromeNum();
        //NoOfDigit();
        //ArmStrongNum();
        //swapTowNum();
        //sumOfDigit();
        primeNumber();
    }
    static void primeNumber() {
        int num =13;
        int count = 0;
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                count++;
            }
        }
            if (count == 0)
            {
                Console.WriteLine("The number is prime number");
            }
            else
            {
                Console.WriteLine("The number is not prime number");
            }
            // sum of digit
            static void sumOfDigit()
            {
                int num = 123456789;
                int n = 0;
                int sum = 0;
                while (num != 0)
                {
                    n = num % 10;
                    sum = sum + n;
                    num /= 10;
                }
                Console.WriteLine(sum);

            }
            // Swap two num without 3rd num
            static void Without3rd()
            {
                int a = 78;
                int b = 91;
                Console.WriteLine("Num Before Swap" + " " + a + " " + b);
                a = a * b;
                b = a / b;
                a = a / b;
                Console.WriteLine("Num after swap" + " " + a + " " + b);
            }
            // swap tow num with 3rd num
            static void swapTowNum()
            {
                int a = 12; int b = 89;
                Console.WriteLine("Num Before Swap" + " " + a + " " + b);
                int temp = a;
                a = b;
                b = temp;
                Console.WriteLine("Num after swap" + " " + a + " " + b);
            }
            //check armstrong number
            static void ArmStrongNum()
            {
                int arm = 0;
                int num = 153;
                int temp = num;
                while (num != 0)
                {
                    int n = num % 10;
                    arm = arm + (n * n * n);
                    num /= 10;
                }
                if (arm == temp)
                {
                    Console.WriteLine("the num is armstrong num");
                }
                else
                {
                    Console.WriteLine("the num is not armstrong num");
                }
            }
            // Count No of digit
            static void NoOfDigit()
            {
                long num = 98765432103;
                long count = 0;
                while (num != 0)
                {
                    count++;
                    num /= 10;
                }
                Console.WriteLine(count);

            }

            static void palindromeNum()
            {
                int num = 12121;
                int rev = 0;
                int temp = num;
                while (num! > 0)
                {
                    rev = rev * 10 + num % 10;
                    num /= 10;
                }
                if (temp == rev)
                {
                    Console.WriteLine("palindrome Number");
                }
                else
                {
                    Console.WriteLine("Not palindrome");
                }

            }

            // reverse number
            static void reverseNum()
            {
                int rev = 0;
                int num = 12345;
                int temp = num;
                while (num! > 0)
                {
                    rev = rev * 10 + num % 10;
                    num /= 10;
                }
                Console.WriteLine(rev);
            }



            static void CheckOddEven()
            {
                Console.WriteLine("Enter any number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }

            // Print Odd Numbers from 1 to N  
            static void printOddNum()
            {
                Console.WriteLine("Enter num");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            // Count Odd Numbers from 1 to N  
            static void CountOddNum()
            {
                Console.WriteLine("Enter num");
                int num = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }

            static void CountEven()
            {
                Console.WriteLine("Enter num");
                int num = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);

            }


            // even sum from 1 to n
            static void CountEvensum()
            {
                Console.WriteLine("Enter num");
                int num = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for (int i = 1; i <= num; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
            // print odd numbers from 1 to n
            static void OddNumbers()
            {
                Console.WriteLine("Enter num");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
        }
    }

    
