namespace Assignment3_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Index Problem");
            Console.WriteLine();
            Console.WriteLine("How many elements in your array?");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = EnterIntArray(arrayLength);
            Console.WriteLine();
            Console.WriteLine("What is the target value? ");
            int targetValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int indexValue = FindIndexOfTarget(inputArray, targetValue);

            Console.WriteLine(indexValue);


        }

        static int[] EnterIntArray(int arrayLength)
        {
            Console.WriteLine("Input your array, one element at a time.");
            int[] inputArray = new int[arrayLength];

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"The array you entered is: ");
            foreach (int input in inputArray)
            {
                Console.Write(input + " ");
            }

            return inputArray;
        }


        static int FindIndexOfTarget(int[] inputArray, int targetValue)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == targetValue)
                {
                    return i;

                }
            }
            return -1;
        }


    }



}
