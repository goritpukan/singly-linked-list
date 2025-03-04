using SinglyLinkedListLibrary;

namespace SinglyLinkedListConsole
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var list = new SinglyLinkedList();
            list.AddFirst(10);
            list.AddFirst(20);
            list.AddFirst(30);
            list.AddFirst(40);
            list.AddFirst(50); 
            list.AddFirst(60);
            
            var firsMultipleOf = list.FindFirstMultipleOf(3);
            System.Console.WriteLine("The first element that is a multiple of the variable: " + firsMultipleOf);

            short multiplyBelowAverage = list.GetMultiplyElementsBelowAverage();
            System.Console.WriteLine("The yield of elements that are below average: " + multiplyBelowAverage);
            
            var newListWithElementsMultipleOf = list.GetAllMultipleOf(3); ;
            list.RemoveGraterThanAverage();
        }
    }
}
