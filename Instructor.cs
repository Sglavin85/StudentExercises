namespace StudentExercises
{
    public class Instructor
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }
        public string cohort { get; set; }
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