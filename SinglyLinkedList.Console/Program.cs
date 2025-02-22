using SinglyLinkedListLibrary;

namespace SinglyLinkedListConsole
{
    public static class Program
    {
        public static void PrintList(SinglyLinkedList list)
        {
            var current = list.Head;
            while (current != null)
            {
                System.Console.Write(current.Data + (current.Next != null ? " -> " : "\n"));
                current = current.Next;
            }
        }
        public static void Main(string[] args)
        {
            var list = new SinglyLinkedList();
            list.AddFirst(10);
            list.AddFirst(20);
            list.AddFirst(30);
            list.AddFirst(40);
            list.AddFirst(50); 
            list.AddFirst(60);
            
            System.Console.WriteLine("Base list");
            PrintList(list);
            
            var firsMultipleOf = list.FindFirstMultipleOf(3);
            System.Console.WriteLine("The first element that is a multiple of the variable: " + firsMultipleOf?.Data);

            short multiplyBelowAverage = list.GetMultiplyElementsBelowAverage();
            System.Console.WriteLine("The yield of elements that are below average: " + multiplyBelowAverage);
            
            var newListWithElementsMultipleOf = list.GetNewListWithElementsMultipleOf(3);
            System.Console.WriteLine("New list returned from GetNewListWithElementsMultipleOf");
            PrintList(newListWithElementsMultipleOf);
            
            System.Console.WriteLine("List before RemoveGraterThanAverage method");
            PrintList(list);
            
            list.RemoveGraterThanAverage();
            
            System.Console.WriteLine("List after RemoveGraterThanAverage method");
            PrintList(list);
        }
    }
}
