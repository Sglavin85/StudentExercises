using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercises
            var classes = new Exercise("Intro to Classes", "C#");
            var dictionaries = new Exercise("Intro to Dictionaries", "C#");
            var arrays = new Exercise("Intro to Array Methods", "Javascript");
            var objects = new Exercise("Intro to Objects", "Javascript");

            //cohorts
            var d32 = new Cohort("Day Cohort 32");
            var n08 = new Cohort("Night Cohort 08");
            var d33 = new Cohort("Day Cohort 33");

            //students
            var joeyD = new Student("Joey", "Driscol", "bigJD");
            var danS = new Student("Dan", "Storm", "dansDansRevolution");
            var deepP = new Student("Deep", "Patel", "DeepThoughts");
            var seanG = new Student("Sean", "Glavin", "SGlav");
            var joelV = new Student("Joel", "Venable", "JVrook");

            //instructors
            var brenda = new Instructor("Brenda", "Long", "Blong", "Making Tacos");
            var bryan = new Instructor("Bryan", "Nilsen", "BigBriFive", "High Fives");
            var adam = new Instructor("Adam", "Shaeffer", "AShaeffer", "Hats");

            d32.AddStudent(joeyD);
            d33.AddStudent(danS);
            n08.AddStudent(deepP);
            d32.AddStudent(seanG);
            d33.AddStudent(joelV);

            d32.AddInstructor(brenda);
            n08.AddInstructor(bryan);
            d33.AddInstructor(adam);

            brenda.AssignExercise(classes, joeyD);
            brenda.AssignExercise(arrays, seanG);
            brenda.AssignExercise(objects, joeyD);
            brenda.AssignExercise(dictionaries, seanG);

            bryan.AssignExercise(objects, deepP);
            bryan.AssignExercise(arrays, deepP);


            adam.AssignExercise(dictionaries, joelV);
            adam.AssignExercise(arrays, joelV);
            adam.AssignExercise(arrays, danS);
            adam.AssignExercise(classes, danS);

            var allStudents = new List<Student>();
            allStudents.Add(joeyD);
            allStudents.Add(joelV);
            allStudents.Add(deepP);
            allStudents.Add(seanG);
            allStudents.Add(danS);

            var allExercises = new List<Exercise>();
            allExercises.Add(classes);
            allExercises.Add(dictionaries);
            allExercises.Add(arrays);
            allExercises.Add(objects);

            foreach (Student student in allStudents)
            {
                System.Console.WriteLine($"{student.firstName} {student.lastName} is working on the following exercises");
                System.Console.WriteLine("------------------------------------------------");
                foreach (Exercise exercise in student.exercises)
                {
                    System.Console.WriteLine($"{exercise.name} in {exercise.language} language");
                }
                System.Console.WriteLine("");
                System.Console.WriteLine("");

            }

        }
    }
}
