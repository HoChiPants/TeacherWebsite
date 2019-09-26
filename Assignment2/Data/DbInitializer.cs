/**
 * Author:    Austin Stephens
 * Date:      September/10/2019
 * Course:    CS 4540, University of Utah, School of Computing
 * Copyright: CS 4540 and Austin Stephens - This work may not be copied for use in Academic Coursework.
 *
 * I, Austin Stephens, certify that I wrote this code from scratch and did not copy it in part or whole from 
 * another source.  Any references used in the completion of the assignment are cited in my README file.
 *
 * File Contents
 *
 *    This seeds the database if there is nothing in it
 */
using System;
using Assignment3.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Data
{
    public class DbInitializer
    {
        private static int traker = 0;
        public static void Initialize(LearningModel context)
        {
            //Checks to see if it has been started
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Courses.Any())
            {
                return;   // DB has been seeded
            }
            //create a list of courses for the database
            var list = new Course[] {

                new Course
                {
                    CourseId = 1,
                    Name = "Web Software Architecture",
                    Description = "A class for teaching student how to develop" +
                    "web software using HTML, CSS, SQL, and Javascript",
                    Department = "CS",
                    CourseNumber = 4540,
                    Semester = "Fall",
                    Year = 2019,
                    LearningOutcomes = MakeLearningOutcomes(1)

                },
                new Course
                {
                    CourseId = 2,
                    Name = "Models of Computation",
                    Description = "A computer science theory class that is a pre" +
                    "requisite for Natural Language Processing",
                    Department = "CS",
                    CourseNumber = 3100,
                    Semester = "Fall",
                    Year = 2019,
                    LearningOutcomes = MakeLearningOutcomes(2)
                },
                new Course
                {
                    CourseId = 3,
                    Name = "Linear Algebra",
                    Description = "A math involving matricies",
                    Department = "Math",
                    CourseNumber = 2100,
                    Semester = "Fall",
                    Year = 2019,
                    LearningOutcomes = MakeLearningOutcomes(3)
                }
                };
            //adds all the courses to the database by adding them to a list
            foreach (Course c in list)
            {
                context.Courses.Add(c);
            }
            //saves the database
            context.SaveChanges();
        }

        //makes learning outcomes for the database
        private static List<LearningOutcome> MakeLearningOutcomes(int num)
        {
            List<LearningOutcome> learningoutcome = new List<LearningOutcome>();
            learningoutcome.Add(new LearningOutcome
            {
                LearningId = ++traker,
                Name = "learning outcome number " + traker,
                Description = "Welcome week",
                CourseInstanceId = num
            });
            learningoutcome.Add(new LearningOutcome
            {
                LearningId = ++traker,
                Name = "learning outcome number " + traker,
                Description = "Cover some basic material",
                CourseInstanceId = num
            });
            learningoutcome.Add(new LearningOutcome
            {
                LearningId = ++traker,
                Name = "learning outcome number " + traker,
                Description = "Somehow make the class extremley hard",
                CourseInstanceId = num
            });
            return learningoutcome;
        }
    }
}
