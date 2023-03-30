namespace cgpaCalculator
{
    public class cgpaCalculator
    {
        public static string calculateGPA(int subjectCount, List<int> marks)
        {

            int total = marks.Sum();
            float avg = total / subjectCount;
            Console.WriteLine("Average: " + avg);
            float cgpa = avg / 10.0f;
            string g = assigGrade(cgpa);
            return g;
        }
        enum grade
        {
            S, A, B, C, F
        }
        public static string assigGrade(float cgpa)
        {
            Console.WriteLine("cgpa: " + cgpa);
            string Grade;
            if (cgpa >= 9f)
            {
                Grade = grade.S.ToString();
            }
            else if (cgpa >= 8f && cgpa < 9f)
            {
                Grade = grade.A.ToString();
            }
            else if (cgpa >= 7f && cgpa < 8f)
            {
                Grade = grade.B.ToString();

            }
            else if (cgpa >= 6f && cgpa < 7f)
            {
                Grade = grade.C.ToString();
            }
            else
            {
                Grade = grade.F.ToString();
            }

            return Grade;
        }
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int subjectCount = 3;
            List<int> marks = new List<int>() { 90, 80, 70 };
            cgpaCalculator.calculateGPA(subjectCount, marks);
            //return true;
           
        }
    }
}