namespace LabWork11_2
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public bool CheckAge(Student student) => student.Age >= 18;
        public bool CheckFirstName(Student student) => student.FirstName[0] == 'A';
        public bool CheckLastName(Student student) => student.LastName.Length > 3;
    }
}
