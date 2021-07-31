using System;

namespace level2.lesson1
{
    class Program
    {
        //метод теста задание 1
        static string Checknamber(int n)
        {
            string result;
            int d = 0;
            int i = 2;
            for (; i < n; i++)
            {
                if (n % i == 0)
                {
                    d++;
                }
            }
                if (d == 0)
                {
                    result = "простое";
                }
                else
                {
                 result = "не простое";
                }
                return result;
            
        }
        //метод теста к заданию 3
        static void TestFib(TestCase testCase, bool recursive)
        {
            try
            {
                int actual;
                if (recursive)
                { 
                    actual = GetFibbonaciRec(testCase.N);
                }
                else
                {
                    actual = GetFibbonaciNonRec(testCase.N);
                }

                if (actual == testCase.ExpectedFib)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    //TODO add type exception tests;
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }
        static void TestChecknamber(TestCase testCase)
        {
            try
            {
                var actual = Checknamber(testCase.N);

                if (actual == testCase.ExpectedString)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    //TODO add type exception tests;
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }



        static void Main(string[] args)
        {
            //test задание 1
            TestCase test1 = new TestCase()
            {
                N = 2,
                ExpectedString = "простое",
                ExpectedException = null

            };
            TestCase test2 = new TestCase()
            {
                N = 3,
                ExpectedString = "простое",
                ExpectedException = null

            };
            TestCase test3 = new TestCase()
            {
                N = 5,
                ExpectedString = "простое",
                ExpectedException = null

            };
            TestCase test4 = new TestCase()
            {
                N = -9,
                ExpectedString = "не простое",
                ExpectedException = null

            };
            TestCase test5 = new TestCase()
            {
                N = 0,
                ExpectedString = "не простое",
                ExpectedException = null

            };

            TestChecknamber(test1);
            TestChecknamber(test2);
            TestChecknamber(test3);
            TestChecknamber(test4);
            TestChecknamber(test5);

            //test задание 3
            TestCase testfib1 = new TestCase()
            {
                N = 1,
                ExpectedFib = 1,
                ExpectedException = null
            };
            TestCase testfib2 = new TestCase()
            {
                N = 2,
                ExpectedFib = 1,
                ExpectedException = null
            };
            TestCase testfib3 = new TestCase()
            {
                N = 3,
                ExpectedFib = 2,
                ExpectedException = null
            };
            TestCase testfib4 = new TestCase()
            {
                N = -5,
                ExpectedFib = 5,
                ExpectedException = null
            };
            TestCase testfib5 = new TestCase()
            {
                N = -3,
                ExpectedFib = 2,
                ExpectedException = null
            };
            bool isRecursive = false;
            TestFib(testfib1, isRecursive);
            TestFib(testfib2, isRecursive);
            TestFib(testfib3, isRecursive);
            TestFib(testfib4, isRecursive);
            TestFib(testfib5, isRecursive);

            //задание 2
            Console.WriteLine("Задание 2 сложность функции O(n3)");

           
        }
        //задание 2
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; // O(1)
            for (int i = 0; i < inputArray.Length; i++) // O(n)  
            {
                for (int j = 0; j < inputArray.Length; j++) //O(n) 
                {
                    for (int k = 0; k < inputArray.Length; k++) //O(n) 
                    {
                        int y = 0; // O(1)

                        if (j != 0) // O(1)
                        {
                            y = k / j; //O(1)
                        }

                        sum += inputArray[i] + i + k + j + y; // O(1)
                    }
                }
            }

            return sum; // O(1)
            //итого O(n3)
        }
        //задание 3 рекурсивный метод
        static int GetFibbonaciRec(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            if (n == 0)
            {
                return 0;
            }

            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return GetFibbonaciRec(n - 2) + GetFibbonaciRec(n - 1);
            }
           
            
        }
        //задание 3 метод без рекурсии
        static int GetFibbonaciNonRec(int n)
        {
            int prev = 0;
            int curr = 1;
            int result = 0;
            if (n == 1)
            {
                return 1;
            }
            for (int i = 1; i < n; i++)
            {
                result = prev + curr;
                prev = curr;
                curr = result;

            }
            return result;

        }
    }
    



}
