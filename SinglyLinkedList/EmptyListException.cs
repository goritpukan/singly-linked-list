namespace SinglyLinkedListLibrary;

public class EmptyListException : Exception
{
    public EmptyListException() : base("This list is empty.") { }
    public EmptyListException(string message) : base(message) { }
    public EmptyListException(string message, Exception innerException) : base(message, innerException) { }
}