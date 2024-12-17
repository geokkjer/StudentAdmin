using System;
namespace StudentAdmin
{
    public class App
    {
        List<Student> StudentsList;
        List<Subject> SubjectList;
        List<Grade> GradeList;

        public App()
        {
            StudentsList = [
                new("Per", 22, [3] , 1),
                new("Espen", 33, [2], 2),
                new("Geir", 51, [1,2], 3),
            ];
            SubjectList =
            [
                new(1,"Jus",10),
                new(2,"Programering", 20),
                new(3,"IT - Informasjonsteknologi",20),
            ];
            GradeList = [
                // Studdenid, subjectid, grade
                new(1, 3, 5),
                new(2, 2, 4),
                new(3, 1, 6),
                new(3, 2, 3)
            ];
            AppMenu();
        }
        public void AppMenu()
        {
            var isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine($"Velkommen til Student Administrasjons program");
                Console.WriteLine("1.) Se alle studentene");
                Console.WriteLine("Q/q.) for å avslutte.");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ChooseStudentMenu(StudentsList);
                        break;
                    case "2":
                        ;
                        break;
                    case "q" or "Q":
                        isRunning = false;
                        break;
                }
            }
        }
        internal void ChooseStudentMenu(List<Student> students)
        {

            Console.Clear();
            Console.WriteLine("Velg en student: ");

            foreach (var st in students)
            {
                Console.WriteLine($"{st.StudentID}) {st.Name}");
            };
            ShowStudent(students);
        }
        void ShowStudent(List<Student> students)
        {
            var input = Convert.ToInt32(Console.ReadLine());
            if (students.Exists(x => x.StudentID == input))
            {
                Student studentFound = StudentsList.Find(x => x.StudentID == input);
                studentFound.SkrivUtInfo();
                GetSubjectsById(studentFound.Subjects);
                GetGradeById(studentFound.Subjects);
                Console.ReadKey();
            }
        }
        public void GetSubjectsById(int[] id)
        {
            foreach (int i in id)
            {
                Subject subjectFound = SubjectList.Find(x => x.SubjectCode == i);
                subjectFound.SkrivUtInfo();
            }
        }
        public void GetGradeById(int[] id)
        {
            foreach (int i in id)
            {
                Grade gradeFound = GradeList.Find(x => x.SubjectId == i);
                gradeFound.SkrivUtInfo();
            }
        }
    }

}