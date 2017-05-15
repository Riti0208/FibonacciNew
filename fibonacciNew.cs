using System;
namespace fibonacci{
    
    class MainClass{
        static int[] fibonacciList;
        public static void Main(){
            fibonacciList = new int[100];
            for (int i = 0; i < 100; i++){
                fibonacciList[i] = fibonacci(i);
                Console.WriteLine("n : " + i + " = " + fibonacciList[i]);
            }
        }
        private static int fibonacci(int value){
			if (value == 0) return 0;
			if (value == 1) return 1;
            return fibonacciList[value - 2] + fibonacciList[value - 1];
        }

    }
}