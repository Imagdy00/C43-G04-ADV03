using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 1
            //            using System;

            //            delegate void MyDelegate(string message);

            //class Program
            //        {
            //            static void Main()
            //            {
            //                MyDelegate del = new MyDelegate(ShowMessage);
            //                del("Hello, World!");
            //            }

            //            static void ShowMessage(string message)
            //            {
            //                Console.WriteLine(message);
            //            }
            //        }
            #endregion

            #region Video 2
            //            using System;

            //            delegate int MathOperation(int a, int b);

            //class Program
            //        {
            //            static void Main()
            //            {
            //                MathOperation add = new MathOperation(Add);
            //                Console.WriteLine(add(5, 3));
            //            }

            //            static int Add(int a, int b)
            //            {
            //                return a + b;
            //            }
            //        }
            #endregion


            #region Video 3
            //            using System;

            //            delegate void PrintDelegate(string message);

            //class Program
            //        {
            //            static void Main()
            //            {
            //                PrintDelegate print = new PrintDelegate(PrintMessage);
            //                print("Hello, Delegate!");
            //            }

            //            static void PrintMessage(string message)
            //            {
            //                Console.WriteLine(message);
            //            }
            //        }
            #endregion


            #region Video 4
            //            using System;

            //            delegate void PrintDelegate<T>(T message);

            //class Program
            //        {
            //            static void Main()
            //            {
            //                PrintDelegate<string> print = new PrintDelegate<string>(PrintMessage);
            //                print("Hello, Generic Delegate!");
            //            }

            //            static void PrintMessage(string message)
            //            {
            //                Console.WriteLine(message);
            //            }
            //        }
            #endregion


            #region Video 5
            //            using System;

            //            delegate void Operation(int a, int b);

            //class Program
            //        {
            //            static void Main()
            //            {
            //                Operation op = Add;
            //                op += Subtract;
            //                op(10, 5);
            //            }

            //            static void Add(int a, int b)
            //            {
            //                Console.WriteLine($"Sum: {a + b}");
            //            }

            //            static void Subtract(int a, int b)
            //            {
            //                Console.WriteLine($"Difference: {a - b}");
            //            }
            //        }
            #endregion


            #region Video 6
            //            using System;

            //            delegate void Operation<T>(T a, T b);

            //class Program
            //        {
            //            static void Main()
            //            {
            //                Operation<int> op = Add;
            //                op += Subtract;
            //                op(10, 5);
            //            }

            //            static void Add(int a, int b)
            //            {
            //                Console.WriteLine($"Sum: {a + b}");
            //            }

            //            static void Subtract(int a, int b)
            //            {
            //                Console.WriteLine($"Difference: {a - b}");
            //            }
            //        }
            #endregion

            #region Video 7
            //            using System;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                Action<string> print = Console.WriteLine;
            //                print("Hello, Action!");

            //                Func<int, int, int> add = (a, b) => a + b;
            //                Console.WriteLine(add(5, 3));
            //            }
            //        }
            #endregion


            #region Video 8
            //            using System;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                Action<string> print = delegate (string message) {
            //                    Console.WriteLine(message);
            //                };
            //                print("Hello, Anonymous Method!");

            //                Action<string> printLambda = message => Console.WriteLine(message);
            //                printLambda("Hello, Lambda Expression!");
            //            }
            //        }
            #endregion

            #region Video 9
            //            using System;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                var number = 10;
            //                var message = "Hello, var!";
            //                Console.WriteLine($"{message} {number}");
            //            }
            //        }
            #endregion


            #region Video 10
////            using System;

////class Program
////        {
////            static void Main()
////            {
////                Func<int, Func<int, int>> add = x => y => x + y;
////                var addFive = add(5);
////                Console.WriteLine(addFive(3)); // Output: 8
////            }
////        }
        #endregion
    }
    }
}
