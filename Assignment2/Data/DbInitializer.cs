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
            IdContext.Users.Add(new Microsoft.AspNetCore.Identity.IdentityUser { Id = "583abdab-54b2-4fbc-8024-41fd994718ba", UserName = "admin_erin@cs.utah.edu", NormalizedUserName = "ADMIN_ERIN@CS.UTAH.EDU", Email = "admin_erin@cs.utah.edu", NormalizedEmail = "ADMIN_ERIN@CS.UTAH.EDU", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEJttv1Isvz+wfAF0X4Acz9PfSFn92uPW3vTzG/MXm3DZ/TGvsVKnzEqyjZKJbie13A==", SecurityStamp = "7LB6S2EHKBN2NB4P2YGOGJ33S5EPHPD2", ConcurrencyStamp = "e253d6e0-6f70-440d-b4bb-3102ef94b221", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnd = null, LockoutEnabled = true, AccessFailedCount = 0 });
            IdContext.UserRoles.Add(new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "583abdab-54b2-4fbc-8024-41fd994718ba", RoleId = "1" });

            // INSTRUCTOR JIM
            IdContext.Users.Add(new Microsoft.AspNetCore.Identity.IdentityUser { Id = "e727124f-f3be-47c3-9063-398c6cc4cf16", UserName = "professor_jim@cs.utah.edu", NormalizedUserName = "PROFESSOR_JIM@CS.UTAH.EDU", Email = "professor_jim@cs.utah.edu", NormalizedEmail = "PROFESSOR_JIM@CS.UTAH.EDU", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEL6m1mfC4FFQJ+VijYUJEAyhm47XX1RrAznI9dWczVOMqZkXCDJJjMVpxq9S7BDl5Q==", SecurityStamp = "BWVUXMAXTEIKTWLXFVTAV7ECRLQZR3UE", ConcurrencyStamp = "1056c7f2-9ac2-438b-baf7-e7e069e1a9b8", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnd = null, LockoutEnabled = true, AccessFailedCount = 0 });
            IdContext.UserRoles.Add(new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "e727124f-f3be-47c3-9063-398c6cc4cf16", RoleId = "2" });

            // INSTRUCTOR MARY
            IdContext.Users.Add(new Microsoft.AspNetCore.Identity.IdentityUser { Id = "3c694a12-8727-44f5-9f53-2c4e0e63ea5f", UserName = "professor_mary@cs.utah.edu", NormalizedUserName = "PROFESSOR_MARY@CS.UTAH.EDU", Email = "professor_mary@cs.utah.edu", NormalizedEmail = "PROFESSOR_MARY@CS.UTAH.EDU", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEKn9wkyyYYQsE86xfBIEEZBbl5x7QnhyABmhMAu+jRqJ3A8txusxDzBt5MR9aCLGoA==", SecurityStamp = "D2P2YGNCIN3NWWXKLVZH227CS3SPQ4ZU", ConcurrencyStamp = "a72ff5e2-24ba-4ee8-bff8-50ef20b0a619", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnd = null, LockoutEnabled = true, AccessFailedCount = 0 });
            IdContext.UserRoles.Add(new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "3c694a12-8727-44f5-9f53-2c4e0e63ea5f", RoleId = "2" });


            // INSTRUCTOR DANNY
            IdContext.Users.Add(new Microsoft.AspNetCore.Identity.IdentityUser { Id = "3c3d6ea3-22c3-4cfb-8ae0-b1eba2663c61", UserName = "professor_danny@cs.utah.edu", NormalizedUserName = "PROFESSOR_DANNY@CS.UTAH.EDU", Email = "professor_danny@cs.utah.edu", NormalizedEmail = "PROFESSOR_DANNY@CS.UTAH.EDU", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEHuOUe7LJo4+QRSf4SpadQ/E9eb3waJQBTVG7ZUvlsNalvChCeLeA3ir0duqvbJGUA==", SecurityStamp = "JZC5JWMEJNNN7VIOIDGAZDQNL473XQ75", ConcurrencyStamp = "97b93df4-fb80-4b65-9448-6f7231d8c683", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnd = null, LockoutEnabled = true, AccessFailedCount = 0 });
            IdContext.UserRoles.Add(new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "3c3d6ea3-22c3-4cfb-8ae0-b1eba2663c61", RoleId = "2" });

            // CHAIR WHITAKER
            IdContext.Users.Add(new Microsoft.AspNetCore.Identity.IdentityUser { Id = "62defa0c-6d45-4d66-9c74-42e8253ad5d3", UserName = "chair_whitaker@cs.utah.edu", NormalizedUserName = "CHAIR_WHITAKER@CS.UTAH.EDU", Email = "chair_whitaker@cs.utah.edu", NormalizedEmail = "CHAIR_WHITAKER@CS.UTAH.EDU", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEGsHbHXLLKNkmwQvA0uj/yzsRkW5bAYxpTtbAJCYewc/DFGCG1IoXrA6lxZdEk/a9w==", SecurityStamp = "PXK7EQNEUB4SIJBP3KUA4FMOKKMLI4HP", ConcurrencyStamp = "9fea99b6-7808-4b44-9d31-c6e2afd5b0b8", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnd = null, LockoutEnabled = true, AccessFailedCount = 0 });
            IdContext.UserRoles.Add(new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "62defa0c-6d45-4d66-9c74-42e8253ad5d3", RoleId = "3" });
            
            // SAVE
            IdContext.SaveChanges();

            //2100 
            List<LearningOutcome> LOs1 = new List<LearningOutcome>();
            LOs1.Add(new LearningOutcome { LearningId = 1, Name = "2100", Description = "use symbolic logic to model real-world situations by converting informal language statements to propositional and predicate logic expressions, as well as apply formal methods to propositions and predicates (such as computing normal forms and calculating validity)", CourseInstanceId = 1 });
            LOs1.Add(new LearningOutcome { LearningId = 2, Name = "2100", Description = "analyze problems to determine underlying recurrence relations, as well as solve such relations by rephrasing as closed formulas", CourseInstanceId = 1 });
            LOs1.Add(new LearningOutcome { LearningId = 3, Name = "2100", Description = "assign practical examples to the appropriate set, function, or relation model, while employing the associated terminology and operations", CourseInstanceId = 1 });
            LOs1.Add(new LearningOutcome { LearningId = 4, Name = "2100", Description = "map real-world applications to appropriate counting formalisms, including permutations and combinations of sets, as well as exercise the rules of combinatorics (such as sums, products, and inclusion-exclusion)", CourseInstanceId = 1 });
            LOs1.Add(new LearningOutcome { LearningId = 5, Name = "2100", Description = "calculate probabilities of independent and dependent events, in addition to expectations of random variables", CourseInstanceId = 1 });
            LOs1.Add(new LearningOutcome { LearningId = 6, Name = "2100", Description = "illustrate by example the basic terminology of graph theory, as wells as properties and special cases (such as Eulerian graphs, spanning trees, isomorphism, and planarity)", CourseInstanceId = 1 });
            LOs1.Add(new LearningOutcome { LearningId = 7, Name = "2100", Description = "employ formal proof techniques (such as direct proof, proof by contradiction, induction, and the pigeonhole principle) to construct sound arguments about properties of numbers, sets, functions, relations, and graphs", CourseInstanceId = 1 });

            //2420 
            List<LearningOutcome> LOs2 = new List<LearningOutcome>();
            LOs2.Add(new LearningOutcome { LearningId = 8, Name = "2420", Description = "implement, and analyze for efficiency, fundamental data structures (including lists, graphs, and trees) and algorithms (including searching, sorting, and hashing)", CourseInstanceId = 2 });
            LOs2.Add(new LearningOutcome { LearningId = 9, Name = "2420", Description = "employ Big-O notation to describe and compare the asymptotic complexity of algorithms, as well as perform empirical studies to validate hypotheses about running time", CourseInstanceId = 2 });
            LOs2.Add(new LearningOutcome { LearningId = 10, Name = "2420", Description = "recognize and describe common applications of abstract data types (including stacks, queues, priority queues, sets, and maps)", CourseInstanceId = 2 });
            LOs2.Add(new LearningOutcome { LearningId = 11, Name = "2420", Description = "apply algorithmic solutions to real-world data", CourseInstanceId = 2 });
            LOs2.Add(new LearningOutcome { LearningId = 12, Name = "2420", Description = "use generics to abstract over functions that differ only in their types", CourseInstanceId = 2 });
            LOs2.Add(new LearningOutcome { LearningId = 13, Name = "2420", Description = "appreciate the collaborative nature of computer science by discussing the benefits of pair programming", CourseInstanceId = 2 });

            //3500 
            List<LearningOutcome> LOs3 = new List<LearningOutcome>();
            LOs3.Add(new LearningOutcome { LearningId = 14, Name = "3500", Description = "design and implement large and complex software systems (including concurrent software) through the use of process models (such as waterfall and agile), libraries (both standard and custom), and modern software development tools (such as debuggers, profilers, and revision control systems)", CourseInstanceId = 3 });
            LOs3.Add(new LearningOutcome { LearningId = 15, Name = "3500", Description = "perform input validation and error handling, as well as employ advanced testing principles and tools to systematically evaluate software", CourseInstanceId = 3 });
            LOs3.Add(new LearningOutcome { LearningId = 16, Name = "3500", Description = "apply the model-view-controller pattern and event handling fundamentals to create a graphical user interface", CourseInstanceId = 3 });
            LOs3.Add(new LearningOutcome { LearningId = 17, Name = "3500", Description = "exercise the client-server model and high-level networking APIs to build a web-based software system", CourseInstanceId = 3 });
            LOs3.Add(new LearningOutcome { LearningId = 18, Name = "3500", Description = "operate a modern relational database to define relations, as well as store and retrieve data", CourseInstanceId = 3 });
            LOs3.Add(new LearningOutcome { LearningId = 19, Name = "3500", Description = "appreciate the collaborative nature of software development by discussing the benefits of peer code reviews", CourseInstanceId = 3 });

            //3500 #2
            //3500 
            List<LearningOutcome> LOs4 = new List<LearningOutcome>();
            LOs4.Add(new LearningOutcome { LearningId = 20, Name = "3500", Description = "design and implement large and complex software systems (including concurrent software) through the use of process models (such as waterfall and agile), libraries (both standard and custom), and modern software development tools (such as debuggers, profilers, and revision control systems)", CourseInstanceId = 4 });
            LOs4.Add(new LearningOutcome { LearningId = 21, Name = "3500", Description = "perform input validation and error handling, as well as employ advanced testing principles and tools to systematically evaluate software", CourseInstanceId = 4 });
            LOs4.Add(new LearningOutcome { LearningId = 22, Name = "3500", Description = "apply the model-view-controller pattern and event handling fundamentals to create a graphical user interface", CourseInstanceId = 4 });
            LOs4.Add(new LearningOutcome { LearningId = 23, Name = "3500", Description = "exercise the client-server model and high-level networking APIs to build a web-based software system", CourseInstanceId = 4 });
            LOs4.Add(new LearningOutcome { LearningId = 24, Name = "3500", Description = "operate a modern relational database to define relations, as well as store and retrieve data", CourseInstanceId = 4 });
            LOs4.Add(new LearningOutcome { LearningId = 25, Name = "3500", Description = "appreciate the collaborative nature of software development by discussing the benefits of peer code reviews", CourseInstanceId = 4 });



            //4400 
            List<LearningOutcome> LOs5 = new List<LearningOutcome>();
            LOs5.Add(new LearningOutcome { LearningId = 26, Name = "4400", Description = "explain the objectives and functions of abstraction layers in modern computing systems, including operating systems, programming languages, compilers, and applications", CourseInstanceId = 5 });
            LOs5.Add(new LearningOutcome { LearningId = 27, Name = "4400", Description = "understand cross-layer communications and how each layer of abstraction is implemented in the next layer of abstraction (such as how C programs are translated into assembly code and how C library allocators are implemented in terms of operating system memory management)", CourseInstanceId = 5 });
            LOs5.Add(new LearningOutcome { LearningId = 28, Name = "4400", Description = "analyze how the performance characteristics of one layer of abstraction affect the layers above it (such as how caching and services of the operating system affect the performance of C programs)", CourseInstanceId = 5 });
            LOs5.Add(new LearningOutcome { LearningId = 29, Name = "4400", Description = "construct applications using operating-system concepts (such as processes, threads, signals, virtual memory, I/O)", CourseInstanceId = 5 });
            LOs5.Add(new LearningOutcome { LearningId = 30, Name = "4400", Description = "synthesize operating-system and networking facilities to build concurrent, communicating applications", CourseInstanceId = 5 });
            LOs5.Add(new LearningOutcome { LearningId = 31, Name = "4400", Description = "implement reliable concurrent and parallel programs using appropriate synchronization constructs", CourseInstanceId = 5 });

            //4540
            List<LearningOutcome> LOs6 = new List<LearningOutcome>();
            LOs6.Add(new LearningOutcome { LearningId = 32, Name = "4540", Description = "Construct web pages using modern HTML and CSS practices, including modern frameworks.", CourseInstanceId = 6 });
            LOs6.Add(new LearningOutcome { LearningId = 33, Name = "4540", Description = "Define accessibility and utilize techniques to create accessible web pages.  ", CourseInstanceId = 6 });
            LOs6.Add(new LearningOutcome { LearningId = 34, Name = "4540", Description = "Outline and utilize MVC technologies across the “full-stack” of web design (including front-end, back-end, and databases) to create interesting web applications. Deploy an application to a “Cloud” provider.", CourseInstanceId = 6 });
            LOs6.Add(new LearningOutcome { LearningId = 35, Name = "4540", Description = "Describe the browser security model and HTTP; utilize techniques for data validation, secure session communication, cookies, single sign-on, and separate roles.  ", CourseInstanceId = 6 });
            LOs6.Add(new LearningOutcome { LearningId = 36, Name = "4540", Description = "Utilize JavaScript for simple page manipulations and AJAX for more complex/complete “single-page” applications.", CourseInstanceId = 6 });
            LOs6.Add(new LearningOutcome { LearningId = 37, Name = "4540", Description = "Demonstrate how responsive techniques can be used to construct applications that are usable at a variety of page sizes.  Define and discuss responsive, reactive, and adaptive.", CourseInstanceId = 6 });
            LOs6.Add(new LearningOutcome { LearningId = 38, Name = "4540", Description = "Construct a simple web-crawler for validation of page functionality and data scraping.", CourseInstanceId = 6 });


            var courses = new Course[]
            {
            new Course{CourseId=1,CourseNumber=2100,Year=2019, Name="Discrete Structures", Description="Introduction to propositional logic, predicate logic, formal logical arguments, finite sets, functions, relations, inductive proofs, recurrence relations, graphs, probability, and their applications to Computer Science.", Department="CS",Semester="Fall", LearningOutcomes=LOs1, UserId="3c694a12-8727-44f5-9f53-2c4e0e63ea5f"},
            new Course{CourseId=2,CourseNumber=2420,Year=2019, Name="Introduction to Algorithms & Data Structures", Description="This course provides an introduction to the problem of engineering computational efficiency into programs. Students will learn about classical algorithms (including sorting, searching, and graph traversal), data structures (including stacks, queues, linked lists, trees, hash tables, and graphs), and analysis of program space and time requirements", Department="CS",Semester="Fall", LearningOutcomes=LOs2,UserId="e727124f-f3be-47c3-9063-398c6cc4cf16"},
            new Course{CourseId=3,CourseNumber=3500,Year=2019, Name="Software Practice I", Description="Practical exposure to the process of creating large software systems, including requirements specifications, design, implementation, testing, and maintenance. Emphasis on software process, software tools (debuggers, profilers, source code repositories, test harnesses), software engineering techniques (time management, code, and documentation standards, source code management, object-oriented analysis and design), and team development practice. Much of the work will be in groups and will involve modifying preexisting software systems.", Department="CS",Semester="Fall", LearningOutcomes=LOs3,UserId="e727124f-f3be-47c3-9063-398c6cc4cf16"},
            new Course{CourseId=4,CourseNumber=3500,Year=2019, Name="Software Practice I", Description="Practical exposure to the process of creating large software systems, including requirements specifications, design, implementation, testing, and maintenance. Emphasis on software process, software tools (debuggers, profilers, source code repositories, test harnesses), software engineering techniques (time management, code, and documentation standards, source code management, object-oriented analysis and design), and team development practice. Much of the work will be in groups and will involve modifying preexisting software systems.", Department="CS",Semester="Fall", LearningOutcomes=LOs4,UserId="3c3d6ea3-22c3-4cfb-8ae0-b1eba2663c61"},
            new Course{CourseId=5,CourseNumber=4400,Year=2019, Name="Computer Systems", Description="Introduction to computer systems from a programmer's point of view.  Machine level representations of programs, optimizing program performance, memory hierarchy, linking, exceptional control flow, measuring program performance, virtual memory, concurrent programming with threads, network programming", Department="CS",Semester="Fall", LearningOutcomes=LOs5,UserId="3c694a12-8727-44f5-9f53-2c4e0e63ea5f"},
            new Course{CourseId=6,CourseNumber=4540,Year=2019, Name="Web Software Architecture", Description="Software architectures, programming models, and programming environments pertinent to developing web applications.  Topics include client-server model, multi-tier software architecture, client-side scripting (JavaScript), server-side programming (Servlets and JavaServer Pages), component reuse (JavaBeans), database connectivity (JDBC), and web servers.", Department="CS",Semester="Fall", LearningOutcomes=LOs6,UserId="e727124f-f3be-47c3-9063-398c6cc4cf16"}
                       };

            foreach (Course s in courses)
            {
                context.Courses.Add(s);
            }
            context.SaveChanges();
        }
    }
}
