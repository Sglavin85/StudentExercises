namespace StudentExercises
{
    public class Instructor : NSSPerson
    {

        public string specialty { get; set; }

        public Instructor(string nameFirst, string nameLast, string slack, string special)
        {
            firstName = nameFirst;
            lastName = nameLast;
            slackHandle = slack;
            specialty = special;
        }

        public void AssignExercise(Exercise ex, Student name)
        {
            name.exercises.Add(ex);
        }
    }
}