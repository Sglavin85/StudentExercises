namespace StudentExercises
{
    public class Exercise
    {
        public string name { get; set; }
        public string language { get; set; }

        public Exercise(string title, string lang)
        {
            name = title;
            language = lang;
        }
    }
}