using static LabWork11_2.Program;

namespace LabWork11_2.Extension
{
    public static class Extension
    {
        internal static List<Student> FindStudent(this List<Student> students, StudentPredicateDelegate studentPredicateDelegate)
        {
            List<Student> result = new List<Student>();

            for (int i = 0; i < students.Count; i++)
            {
                if (studentPredicateDelegate(students[i]))
                {
                    result.Add(students[i]);
                }
            }

            return result;
        }
    }
}