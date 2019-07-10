using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public string name { get; set; }
        public List<Student> students { get; set; } = new List<Student>();
        public List<Instructor> instructors { get; set; } = new List<Instructor>();

        public Cohort(string title)
        {
            name = title;
        }

        public void AddStudent(Student name)
        {
            students.Add(name);
            name.cohort = this.name;
        }

        public void AddInstructor(Instructor name)
        {
            instructors.Add(name);
            name.cohort = this.name;
        }
    }
}