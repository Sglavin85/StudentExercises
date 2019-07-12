using System;
using System.Collections.Generic;
using System.Linq;

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
            var nateF = new Student("Nathan", "Flemming", "NateF");

            //instructors
            var brenda = new Instructor("Brenda", "Long", "Blong", "Making Tacos");
            var bryan = new Instructor("Bryan", "Nilsen", "BigBriFive", "High Fives");
            var adam = new Instructor("Adam", "Shaeffer", "AShaeffer", "Hats");

            d32.AddStudent(joeyD);
            d33.AddStudent(danS);
            n08.AddStudent(deepP);
            d32.AddStudent(seanG);
            d33.AddStudent(joelV);
            n08.AddStudent(nateF);

            d32.AddInstructor(brenda);
            n08.AddInstructor(bryan);
            d33.AddInstructor(adam);

            brenda.AssignExercise(classes, joeyD);
            brenda.AssignExercise(arrays, seanG);
            brenda.AssignExercise(objects, joeyD);
            brenda.AssignExercise(dictionaries, seanG);
            brenda.AssignExercise(classes, seanG);

            bryan.AssignExercise(objects, deepP);
            bryan.AssignExercise(arrays, deepP);


            adam.AssignExercise(dictionaries, joelV);
            adam.AssignExercise(arrays, joelV);
            adam.AssignExercise(arrays, danS);
            adam.AssignExercise(classes, danS);

            var allStudents = new List<Student>()
           {
                joeyD,
                joelV,
                deepP,
                seanG,
                danS,
                nateF
            };

            var allExercises = new List<Exercise>()
            {
                classes,
                dictionaries,
                arrays,
                objects
            };
            var allInstructors = new List<Instructor>()
            {
                brenda,
                bryan,
                adam
            };
            var allCohorts = new List<Cohort>()
            {
                d32,
                d33,
                n08
            };

            //List all JS exercises
            var JavascriptExercises = allExercises.Where(exercise => exercise.language == "Javascript");

            System.Console.WriteLine("Javascript Exercises:");
            foreach (var ex in JavascriptExercises)
            {
                System.Console.WriteLine(ex.name);
            }

            // List all students in Cohort 32
            var Cohort32Students = allCohorts.Where(cohort => cohort.name == "Day Cohort 32")
            .SelectMany(cohort => cohort.students);

            System.Console.WriteLine("");
            System.Console.WriteLine("Cohort 32 Students:");
            foreach (var student in Cohort32Students)
            {
                System.Console.WriteLine(student.firstName + " " + student.lastName);
            }

            //List all instructors in Cohort 33
            var Cohort33Instructors = allCohorts.Where(cohort => cohort.name == "Day Cohort 33")
            .SelectMany(cohort => cohort.instructors);

            System.Console.WriteLine("");
            System.Console.WriteLine("Cohort 32 Students:");
            foreach (var instructor in Cohort33Instructors)
            {
                System.Console.WriteLine(instructor.firstName + " " + instructor.lastName);
            }

            //Sort students by last name
            var studentsByLastName = allStudents.OrderBy(student => student.lastName);

            System.Console.WriteLine("");
            System.Console.WriteLine("Students by last name:");

            foreach (var student in studentsByLastName)
            {
                System.Console.WriteLine(student.lastName + ", " + student.firstName);
            }

            //Find Students with no assigned Exercises
            var studentsWithNoExercises = allStudents.Where(student => student.exercises.Count() == 0);

            System.Console.WriteLine("");
            System.Console.WriteLine("Students with no assigned Exercises:");
            foreach (var student in studentsWithNoExercises)
            {
                System.Console.WriteLine(student.firstName + " " + student.lastName);
            }

            //List the student with the most exercises assigned
            var studentWithMostAssignedExercises = allStudents.OrderBy(student => student.exercises.Count()).Take(1);

            System.Console.WriteLine("");
            System.Console.WriteLine("Student with the most exercises assigned");
            foreach (Student student in studentWithMostAssignedExercises)
            {
                System.Console.WriteLine(student.firstName + " " + student.lastName);
            }

            //Number of students in each cohort
            System.Console.WriteLine("");
            System.Console.WriteLine("Number of students in each cohort");

            foreach (var cohort in allCohorts)
            {
                System.Console.WriteLine(cohort.name + ": " + cohort.students.Count());
            }
            //List what exercises students are working on
            System.Console.WriteLine("");
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
