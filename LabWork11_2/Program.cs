using LabWork11_2;
using LabWork11_2.Extension;

namespace LabWork11_2;
class Program
{
    public delegate bool StudentPredicateDelegate(Student student);
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>{
            new Student("Maxim", "Adamenko", 17),
            new Student("Andriy", "Artemenko", 19),
            new Student("Vlad", "Bashich", 14),
            new Student("Vlad", "Birin", 69),
            new Student("Roman", "Gumenuk", 18),
            new Student("Anton", "Kulay", 16),
            new Student("Eugene", "Nedin", 11),
            new Student("Andriy", "Ruban", 100),
            new Student("Ryabov", "Artem", -3),
            new Student("Sergiy", "Skyba", 0)
        };

        Student student = new Student();

        StudentPredicateDelegate studentPredicateDelegate_FirstName = student.CheckFirstName;
        StudentPredicateDelegate studentPredicateDelegate_LastName = student.CheckLastName;
        StudentPredicateDelegate studentPredicateDelegate_Age = student.CheckAge;

        List<Student> ResultList_FirstName = students.FindStudent(studentPredicateDelegate_FirstName);
        List<Student> ResultList_LastName = students.FindStudent(studentPredicateDelegate_LastName);
        List<Student> ResultList_Age = students.FindStudent(studentPredicateDelegate_Age);

        foreach (var item in ResultList_FirstName)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
        }
        Console.WriteLine("\n--------------------------------\n");

        foreach (var item in ResultList_LastName)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
        }
        Console.WriteLine("\n--------------------------------\n");

        foreach (var item in ResultList_Age)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
        }
    }
}