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
 *    Controller for the Database information.
 */
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    public class LearningModel : DbContext
    {
        public LearningModel(DbContextOptions<LearningModel> options)
            : base(options)
        { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<LearningOutcome> LearningOutcomes { get; set; }

    }
    //These are all the fields of the courses table in the database
	public class Course
	{
        [Key]
		public int CourseId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Department { get; set; }
		public int CourseNumber { get; set; }
		public string Semester { get; set; }
		public int Year { get; set; }

		public List<LearningOutcome> LearningOutcomes { get; set; }
	}

    //these are all the fields for the learning outcomes in the database
	public class LearningOutcome
    {
        [Key]
        public int LearningId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseInstanceId { get; set; }
    }
}
