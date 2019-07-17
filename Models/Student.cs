using System.Collections.Generic;

namespace StudentExercises
{
    public class Student : NSSPerson
    {

        public List<Exercise> exercises { get; set; } = new List<Exercise>();

        public Student(string nameFirst, string nameLast, string slack)
        {
            firstName = nameFirst;
            lastName = nameLast;
            slackHandle = slack;

        }
    }
}