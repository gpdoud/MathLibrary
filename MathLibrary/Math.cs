using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary {

    class Math {

        public static int Add(int a, int b) {
            return a + b;
        }
        public static int Subtract(int a, int b) {
            return a - b;
        }
        public static int Multiply(int a, int b) {
            return a * b;
        }
        public static int Divide(int a, int b) {
            return a / b;
        }
        public static int Modulo(int a, int b) {
            return a - (a / b * b);
        }
        public static int Power(int a, int b) {
            var answer = 1;
            for(var idx = 0; idx < b; idx++) {
                answer *= a;
            }
            return answer;
        }
        public static bool IsEven(int a) {
            return (Modulo(a, 2) == 0) ? true : false;
        }
        public static int Increment(int a) {
            return a + 1;
        }
        public static int Decrement(int a) {
            return a - 1;
        }
    }
}
