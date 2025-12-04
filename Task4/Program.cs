namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Task 4 Updated Output:\n");

            // Selection and projection using LINQ

            List<int> number = [10, 20, 30, 40, 50];

            var squaredNumber = from n in number
                                select n * n;

            Console.WriteLine("Squared Numbers:");
            Console.WriteLine(string.Join(", ", squaredNumber));


            // Filtering using LINQ
            Book book1 = new Book("Flutter Guide", 850.00);
            Book book2 = new Book("AI Essentials", 1500.75);
            Book book3 = new Book("Data Science Pro", 2500.10);
            List<Book> bookList = [book1, book2, book3];

            var premiumBooks = from book in bookList
                               where book.price > 1000
                               select book;

            Console.WriteLine("\nBooks priced above Rs.1000:");
            foreach (var b in premiumBooks)
            {
                Console.WriteLine($"{b.bookName} - Rs.{b.price}");
            }


            // Sorting using LINQ
            Student student1 = new Student("Nisha", "A1");
            Student student2 = new Student("Ankit", "A3");
            Student student3 = new Student("Bikash", "B1");
            Student student4 = new Student("Riya", "C2");
            Student student5 = new Student("Kritika", "A2");
            Student student6 = new Student("Sandesh", "B3");
            Student student7 = new Student("Meena", "C1");
            Student student8 = new Student("Kabita", "A4");
            Student student9 = new Student("Roshan", "B2");
            Student student10 = new Student("Aarav", "C3");

            List<Student> studentList = [
                student1, student2, student3, student4, student5,
                student6, student7, student8, student9, student10
            ];

            var sortedStudentsWithOrderBy = from student in studentList
                                            orderby student.studentName
                                            select student;

            Console.WriteLine("\nSorted Students (Ascending):");

            foreach (var student in sortedStudentsWithOrderBy)
            {
                Console.WriteLine($"Name: {student.studentName}, Section: {student.section}");
            }



            var sortedStudentsWithOrderByDesc = from student in studentList
                                                orderby student.studentName descending
                                                select student;

            Console.WriteLine("\nSorted Students (Descending):");

            foreach (var student in sortedStudentsWithOrderByDesc)
            {
                Console.WriteLine($"Name: {student.studentName}, Section: {student.section}");
            }
        }
    }
}
