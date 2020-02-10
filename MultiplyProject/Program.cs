using System;

namespace MultiplyProject {
    class Program {
        static void Main(string[] args) {
            var sum = 1;
            for (var index = 2; index <=10; index++) {
                sum *= index;
                }
            Console.WriteLine($"Sum is {sum}");
            }
        }
    }
