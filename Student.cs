using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }
        public string cohort { get; set; }
        public List<Exercise> exercises { get; set; } = new List<Exercise>();

        public Student(string nameFirst, string nameLast, string slack)
        {
            firstName = nameFirst;
            lastName = nameLast;
            slackHandle = slack;

        }
    }
}