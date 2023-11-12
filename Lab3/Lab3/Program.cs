namespace LABY_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Student student = new Student("Jan", "Nowak", 20, "12345");
            //    Console.WriteLine(student.ToString());
            Book book = new Book("Moby Dick", new Person("Herman", "Melville", 87), 1851);
            book.View();
        }
    }
}