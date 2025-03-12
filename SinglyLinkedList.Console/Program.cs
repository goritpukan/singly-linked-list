using SinglyLinkedListLibrary;

namespace SinglyLinkedListConsole
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var list = new SinglyLinkedList();
            list.AddFirst(5);
            list.AddFirst(10);
            list.AddFirst(20);
            list.AddFirst(30);
            list.AddFirst(40);
            list.AddFirst(60);
            list.AddFirst(70);
            list.AddFirst(90);
            list.AddFirst(120);
            Console.WriteLine("Base list");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            
            var firsMultipleOf = list.FindFirstMultipleOf(25);
            System.Console.WriteLine("\nThe first element that is a multiple of the variable: " + firsMultipleOf);
            int[] arr = { 1, 2, 3, 5 };
            if (firsMultipleOf != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] *= (int)firsMultipleOf;
                }
            }
            


            int multiplyBelowAverage = list.GetMultiplyElementsBelowAverage();
            System.Console.WriteLine("\nThe yield of elements that are below average: " + multiplyBelowAverage);
            
            var newListWithElementsMultipleOf = list.GetAllMultipleOf(3);
            Console.WriteLine("\nNew list elements with multiple of 3");
            foreach (var item in newListWithElementsMultipleOf)
            {
                Console.Write(item + " ");
            }
            list.RemoveGraterThanAverage();
            Console.WriteLine("\nList after RemoveGraterThanAverage method");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
