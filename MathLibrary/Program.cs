﻿using System;

namespace MathLibrary {
    class Program {
        static void Main(string[] args) {

            //var math = new Math();
            var answer = Math.Add(1, 2);
            Console.WriteLine($"1 plus 2 equals {answer}");

            answer = Math.Subtract(7, 2);
            Console.WriteLine($"7 minus 2 equals {answer}");

            answer = Math.Multiply(7, 2);
            Console.WriteLine($"7 times 2 equals {answer}");

            answer = Math.Divide(7, 2);
            Console.WriteLine($"7 divided by 2 equals {answer}");

            answer = Math.Modulo(7, 2); // should return 1
            Console.WriteLine($"7 modulo 2 equals {answer}");

            answer = Math.Modulo(13, 5); // should return 3
            Console.WriteLine($"13 modulo 5 equals {answer}");

            answer = Math.Modulo(1234, 13); // should return 12
            Console.WriteLine($"1234 modulo 13 equals {answer}");

            var a = 2;
            var b = 4;
            answer = Math.Power(a, b); // should return 16
            Console.WriteLine($"{a} power {b} equals {answer}");

            a = 7;
            b = 4;
            answer = Math.Power(a, b); // should return 2401
            Console.WriteLine($"{a} power {b} equals {answer}");

            a = 13;
            b = 3;
            answer = Math.Power(a, b); // should return 2197
            Console.WriteLine($"{a} power {b} equals {answer}");

            a = 7;
            bool boolAnswer = Math.IsEven(a);
            Console.WriteLine($"{a} is {(boolAnswer ? "Even" : "Odd")}");

            a = 44;
            boolAnswer = Math.IsEven(a);
            Console.WriteLine($"{a} is {(boolAnswer ? "Even" : "Odd")}");

            a = 88;
            Console.WriteLine($"{a} incremented is {Math.Increment(a)}");
            Console.WriteLine($"{a} decremented is {Math.Decrement(a)}");
            
            // to change the value of a
            a = Math.Increment(a);
        }
    }
}
