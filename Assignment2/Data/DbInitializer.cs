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
using Assignment4.Models;

namespace Assignment3.Data
{
    public class DbInitializer
    {
        public static void Initialize(LearningModel context, UserRolesContext IdContext)
        {
            //Checks to see if it has been started
            context.Database.EnsureCreated();
            IdContext.Database.EnsureCreated();

            // Look for any students.
            if (context.Courses.Any() || IdContext.Users.Any())
            {
                return;   // DB has been seeded
            }
            // ROLES
            IdContext.Roles.Add(new Microsoft.AspNetCore.Identity.IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = null });
            IdContext.Roles.Add(new Microsoft.AspNetCore.Identity.IdentityRole { Id = "2", Name = "Instructor", NormalizedName = "INSTRUCTOR", ConcurrencyStamp = null });
            IdContext.Roles.Add(new Microsoft.AspNetCore.Identity.IdentityRole { Id = "3", Name = "Chair", NormalizedName = "CHAIR", ConcurrencyStamp = null });

            // ADMIN ERIN
            IdContext.Users.Add(new Microsoft.AspNetCore.Identity.IdentityUser { Id = "6da82f6a-6027-487b-97bc-896570101ced", UserName = "admin_erin@cs.utah.edu", NormalizedUserName = "ADMIN_ERIN@CS.UTAH.EDU", Email = "admin_erin@cs.utah.edu", NormalizedEmail = "ADMIN_ERIN@CS.UTAH.EDU", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEKn9wkyyYYQsE86xfBIEEZBbl5x7QnhyABmhMAu+jRqJ3A8txusxDzBt5MR9aCLGoA==", SecurityStamp = "OW7342NEKX4ADAR7B7FNX3B64WXQUVQH", ConcurrencyStamp = "3ffa88a0-540b-4e7e-b491-2b974bfe09eb", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnd = null, LockoutEnabled = true, AccessFailedCount = 0 });
            IdContext.UserRoles.Add(new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "6da82f6a-6027-487b-97bc-896570101ced", RoleId = "1" });

            // INSTRUCTOR JIM
            IdContext.Users.Add(new Microsoft.AspNetCore.Identity.IdentityUser { Id = "3645dfa3-6ac8-439e-b802-9b9953056bce", UserName = "professor_jim@cs.utah.edu", NormalizedUserName = "PROFESSOR_JIM@CS.UTAH.EDU", Email = "professor_jim@cs.utah.edu", NormalizedEmail = "PROFESSOR_JIM@CS.UTAH.EDU", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEKn9wkyyYYQsE86xfBIEEZBbl5x7QnhyABmhMAu+jRqJ3A8txusxDzBt5MR9aCLGoA==", SecurityStamp = "L3BGZ2P3MXZO46DRCREMYUQFFJGTHPE2", ConcurrencyStamp = "25453c2a-7e02-4e52-b79b-ef22f9ddf5db", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnd = null, LockoutEnabled = true, AccessFailedCount = 0 });
            IdContext.UserRoles.Add(new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "3645dfa3-6ac8-439e-b802-9b9953056bce", RoleId = "2" });

            // INSTRUCTOR MARY
            IdContext.Users.Add(new Microsoft.AspNetCore.Identity.IdentityUser { Id = "3c694a12-8727-44f5-9f53-2c4e0e63ea5f", UserName = "professor_mary@cs.utah.edu", NormalizedUserName = "PROFESSOR_MARY@CS.UTAH.EDU", Email = "professor_mary@cs.utah.edu", NormalizedEmail = "PROFESSOR_MARY@CS.UTAH.EDU", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEKn9wkyyYYQsE86xfBIEEZBbl5x7QnhyABmhMAu+jRqJ3A8txusxDzBt5MR9aCLGoA==", SecurityStamp = "D2P2YGNCIN3NWWXKLVZH227CS3SPQ4ZU", ConcurrencyStamp = "a72ff5e2-24ba-4ee8-bff8-50ef20b0a619", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnd = null, LockoutEnabled = true, AccessFailedCount = 0 });
            IdContext.UserRoles.Add(new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "3c694a12-8727-44f5-9f53-2c4e0e63ea5f", RoleId = "2" });


            // INSTRUCTOR DANNY
            IdContext.Users.Add(new Microsoft.AspNetCore.Identity.IdentityUser { Id = "b71b04b8-bd26-45b2-80af-04615dea14d4", UserName = "professor_danny@cs.utah.edu", NormalizedUserName = "PROFESSOR_DANNY@CS.UTAH.EDU", Email = "professor_danny@cs.utah.edu", NormalizedEmail = "PROFESSOR_DANNY@CS.UTAH.EDU", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEKn9wkyyYYQsE86xfBIEEZBbl5x7QnhyABmhMAu+jRqJ3A8txusxDzBt5MR9aCLGoA==", SecurityStamp = "WO2IXER6NQ7QR4SBJK7357XLL4EMSAN5", ConcurrencyStamp = "e6cf5206-e2d5-4cd1-813c-8c9d50c90a91", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnd = null, LockoutEnabled = true, AccessFailedCount = 0 });
            IdContext.UserRoles.Add(new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "b71b04b8-bd26-45b2-80af-04615dea14d4", RoleId = "2" });

            // CHAIR WHITAKER
            IdContext.Users.Add(new Microsoft.AspNetCore.Identity.IdentityUser { Id = "bebeb818-8bdf-4e7b-8545-eb8577f973e9", UserName = "chair_whitaker@cs.utah.edu", NormalizedUserName = "CHAIR_WHITAKER@CS.UTAH.EDU", Email = "chair_whitaker@cs.utah.edu", NormalizedEmail = "CHAIR_WHITAKER@CS.UTAH.EDU", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEKn9wkyyYYQsE86xfBIEEZBbl5x7QnhyABmhMAu+jRqJ3A8txusxDzBt5MR9aCLGoA==", SecurityStamp = "LDOV3O2ROVKDJD5NVH7JDJ64YKINRWRS", ConcurrencyStamp = "1f18f86e-ac40-480d-81a3-0154f39ede51", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnd = null, LockoutEnabled = true, AccessFailedCount = 0 });
            IdContext.UserRoles.Add(new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "bebeb818-8bdf-4e7b-8545-eb8577f973e9", RoleId = "3" });

            // SAVE
            IdContext.SaveChanges();

            //2420 LEARNING OUTCOMES
            List<LearningOutcome> LOList1 = new List<LearningOutcome>();
            LOList1.Add(new LearningOutcome {  Name = "Algorithms", Description = "Students will learn algorithms for searching (sequential and binary) and sorting (selection, insertion, mergesort, quicksort, heapsort, radix sort), as well as the asymptotic behavior of each.", CourseInstanceId=1 });
            LOList1.Add(new LearningOutcome {  Name = "Data Structures", Description = "Students will become proficient using (and in many cases, implementing) data structures fundamental to computer science including arrays, linked lists, stacks, queues, graphs, trees, binary search trees, Huffman trees, hash tables, binary heaps, and priority queues. Students will reason about the asymptotic behavior of basic operations on these data structures.", CourseInstanceId = 1 });
            LOList1.Add(new LearningOutcome {  Name = "Efficiency", Description = "Students will regularly evaluate their solutions for efficiency through written reports. Evaluations will summarize efficiency in time (Big-O and/or actual running time), efficiency in space (memory requirements), and/or programmer efficiency (ease of implementation and maintenance) of solutions.", CourseInstanceId = 1 });
            LOList1.Add(new LearningOutcome {  Name = "Object-Oriented Programming", Description = "Students will improve on the object-oriented programming skills learned in CS 1410. Student understanding of the concepts of inheritance, polymorphism, and generic programming will be strengthened significantly by creating solutions with multiple levels of inheritance and by implementing generic versions of data structures.", CourseInstanceId = 1 });

            //3500 LEARNING OUTCOMES
            List<LearningOutcome> LOList2 = new List<LearningOutcome>();
            LOList2.Add(new LearningOutcome {  Name = "Large Software Systems", Description = "Practical exposure to the process of creating large software systems, including requirements specifications, design, implementation, testing, and maintenance", CourseInstanceId = 2 });
            LOList2.Add(new LearningOutcome {  Name = "Software Tools", Description = "Debuggers, profilers, source code repositories, test harnesses", CourseInstanceId = 2 });
            LOList2.Add(new LearningOutcome {  Name = "Software Engineering Techniques", Description = "time management, code, and documentation standards, source code management, object-oriented analysis and design", CourseInstanceId = 2 });

            //4540 LEARNING OUTCOMES
            List<LearningOutcome> LOList3 = new List<LearningOutcome>();
            LOList3.Add(new LearningOutcome {  Name = "HTML/CSS", Description = "Construct web pages using modern HTML and CSS practices, including modern frameworks. ", CourseInstanceId = 3 });
            LOList3.Add(new LearningOutcome {  Name = "Accessibility", Description = "Define accessibility and utilize techniques to create accessible web pages.  ", CourseInstanceId = 3 });
            LOList3.Add(new LearningOutcome {  Name = "MVC", Description = "Outline and utilize MVC technologies across the “full-stack” of web design (including front-end, back-end,  and  databases)  to  create  interesting  web  applications.  Deploy an  application  to  a  “Cloud” provider.", CourseInstanceId = 3 });
            LOList3.Add(new LearningOutcome {  Name = "HTTP", Description = "Describe  the  browser  security  model  and  HTTP;  utilize  techniques  for  data  validation,  secure  session communication, cookies, single sign-on, and separate roles.", CourseInstanceId = 3 });

            //2100 LEARNING OUTCOMES
            List<LearningOutcome> LOList4 = new List<LearningOutcome>();
            LOList4.Add(new LearningOutcome {  Name = "Mathematical Reasoning", Description = "Introduction to formal mathematical statements, logic, theorems and proofs.We will cover several fundamental strategies for proving mathematical statements", CourseInstanceId = 4 });
            LOList4.Add(new LearningOutcome {  Name = "Set Theory and Boolean Logic", Description = "Introduction to sets, set operations, proving set properties and Boolean Logic.", CourseInstanceId = 4 });
            LOList4.Add(new LearningOutcome {  Name = "Relations and Function", Description = "Introduction to relations, equivalence relations, functions, and properties of functions", CourseInstanceId = 4 });
            LOList4.Add(new LearningOutcome {  Name = "Combinatorics and Probability", Description = "Basic combinatorics, counting principles,and an introduction to discrete probability", CourseInstanceId = 4 });

            //4400 LEARNING OUTCOMES
            List<LearningOutcome> LOList5 = new List<LearningOutcome>();
            LOList5.Add(new LearningOutcome {  Name = "More Effective Programmer", Description = "Detecting and fixing bugs more efficiently and understanding and tuning program performance", CourseInstanceId = 5 });
            LOList5.Add(new LearningOutcome {  Name = "Terminal", Description = "You will be comfortable using the terminal and command line", CourseInstanceId = 5 });
            LOList5.Add(new LearningOutcome {  Name = "Specialized Systems", Description = "You will have a firm foundation for specialized systems classes and real-word software development", CourseInstanceId = 5 });

            //3500 LEARNING OUTCOMES DANNY
            List<LearningOutcome> LOList6 = new List<LearningOutcome>();
            LOList6.Add(new LearningOutcome {  Name = "Large Software Systems", Description = "Practical exposure to the process of creating large software systems, including requirements specifications, design, implementation, testing, and maintenance", CourseInstanceId = 6 });
            LOList6.Add(new LearningOutcome {  Name = "Software Tools", Description = "Debuggers, profilers, source code repositories, test harnesses", CourseInstanceId = 6 });
            LOList6.Add(new LearningOutcome {  Name = "Software Engineering Techniques", Description = "time management, code, and documentation standards, source code management, object-oriented analysis and design", CourseInstanceId = 6 });

            var Courses = new Course[]
            {
            new Course{CourseId=1,Name="Introduction to Algorithms & Data Structure",Description="This course provides an introduction to the problem of engineering computational efficiency into programs. Students will learn about classical algorithms (including sorting, searching, and graph traversal), data structures (including stacks, queues, linked lists, trees, hash tables, and graphs), and analysis of program space and time requirements", Department="CS", CourseNumber=2420, Semester="Fall", Year=2019, UserId="3645dfa3-6ac8-439e-b802-9b9953056bce", LearningOutcomes=LOList1},
            new Course{CourseId=2,Name="Software Practice",Description="Practical exposure to the process of creating large software systems, including requirements specifications, design, implementation, testing, and maintenance. Emphasis on software process, software tools (debuggers, profilers, source code repositories, test harnesses), software engineering techniques (time management, code, and documentation standards, source code management, object-oriented analysis and design), and team development practice. Much of the work will be in groups and will involve modifying preexisting software systems.", Department="CS", CourseNumber=3500, Semester="Spring", Year=2019, UserId="3645dfa3-6ac8-439e-b802-9b9953056bce" , LearningOutcomes=LOList2},
            new Course{CourseId=3,Name="Web Software Architecture",Description="Software architectures, programming models, and programming environments pertinent to developing web applications.  Topics include client-server model, multi-tier software architecture, client-side scripting (JavaScript), server-side programming (Servlets and JavaServer Pages), component reuse (JavaBeans), database connectivity (JDBC), and web servers.", Department="CS", CourseNumber=4540, Semester="Fall", Year=2019, UserId="3645dfa3-6ac8-439e-b802-9b9953056bce" ,LearningOutcomes=LOList3},
            new Course{CourseId=4,Name="Discrete Structures",Description="Introduction to propositional logic, predicate logic, formal logical arguments, finite sets, functions, relations, inductive proofs, recurrence relations, graphs, probability, and their applications to Computer Science.", Department="CS", CourseNumber=2100, Semester="Fall", Year=2019, UserId="3c694a12-8727-44f5-9f53-2c4e0e63ea5f" , LearningOutcomes=LOList4},
            new Course{CourseId=5,Name="Computer System",Description="Introduction to computer systems from a programmer's point of view.  Machine level representations of programs, optimizing program performance, memory hierarchy, linking, exceptional control flow, measuring program performance, virtual memory, concurrent programming with threads, network programming.", Department="CS", CourseNumber=4400, Semester="Fall", Year=2019, UserId="3c694a12-8727-44f5-9f53-2c4e0e63ea5f" , LearningOutcomes=LOList5},
            new Course{CourseId=6,Name="Software Practice",Description="Practical exposure to the process of creating large software systems, including requirements specifications, design, implementation, testing, and maintenance. Emphasis on software process, software tools (debuggers, profilers, source code repositories, test harnesses), software engineering techniques (time management, code, and documentation standards, source code management, object-oriented analysis and design), and team development practice. Much of the work will be in groups and will involve modifying preexisting software systems.  This is Danny's course, not Jim's", Department="CS", CourseNumber=3500, Semester="Fall", Year=2019, UserId="b71b04b8-bd26-45b2-80af-04615dea14d4" , LearningOutcomes=LOList6},

            };
            foreach (Course s in Courses)
            {
                context.Courses.Add(s);
            }
            context.SaveChanges();
        }
    }
}
