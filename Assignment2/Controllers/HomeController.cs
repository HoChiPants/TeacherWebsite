/**
    Author:    [Austin Stephens]
    Partner:   [None]
    Date:      [08/26/2019]
    Course:    CS 4540, University of Utah, School of Computing
    Copyright: CS 4540 and [Austin Stephens] - This work may not be copied for use in Academic Coursework.


    I, Austin Stephens, certify that I wrote this code from scratch and did not copy it in part or whole from
  another source.  Any references used in the completion of the assignment are cited in my README file.

  File Contents

    Inside this file is the controller for the website made. The index is the home, Privacy is nothing, Course is
    the professor view, and Overview is the department head view.
 
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;
using Assignment3.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        private readonly LearningModel _context;

        public HomeController(LearningModel context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Courses.ToListAsync());
        }

        public async Task<IActionResult> Course(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course course = await _context.Courses.Include(o => o.LearningOutcomes)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //this is for the raw text file view. Takes in an it for the course id and creates a webpage from the string.
        public async Task<IActionResult> RawCourse(int? id)
        {
            Course course = await _context.Courses.Include(o => o.LearningOutcomes).FirstOrDefaultAsync(m => m.CourseId == id);

            string page = "";

            page = @"<body>
    <div class='jumbotron text-center' id='jumbotronStyle'>
        <ul class='list-inline'>
            <li class='list-inline-item'><h2>Welcome to " + course.CourseNumber + @"</h2></li>
        </ul>
    </div>
    <article>
        <div>
            <h2>Professor</h2> <a href = '#' class='btn btn-primary btn-lg active' role='button' aria-pressed='true'>Add Learning Outcome</a>
            <a href = '#' class='btn btn-secondary btn-lg active' role='button' aria-pressed='true'>Delete Learning Outcome</a>
        </div>
        <table class='table'>

            <thead>
                <tr>
                    <th scope = 'col' > Learning Outcomes</th>
                    <th scope = 'col' > Description </th>
                    <th scope='col'>Example</th>
                    <th scope = 'col' > Assignment / Exam </th>
                    <th scope='col'> </th>
                </tr>
            </thead>";
            foreach(var l in course.LearningOutcomes)
        {
                page +=
        @"<tbody>
            <tr>
                <td scope = 'row'> Learning Outcome:" + l.LearningId + @"</td>
                <td scope = 'row'>" + l.Description + @"</td>
                <td scope='row'>
                    <a href = '../../DummyFiles/student_work.pdf' target= '_blank' type= 'button' class='btn btn-outline-success'>Great Example</a>
                    <a href = '../../DummyFiles/student_work.pdf' target= '_blank' type= 'button' class='btn btn-outline-primary'>Good Example</a>
                    <a href = '../../DummyFiles/student_work.pdf' target= '_blank' type= 'button' class='btn btn-outline-secondary'>Bad Example</a>
                </td>
                <td scope = 'row' colspan= '3'>
                    <a href= '../../DummyFiles/assignment_definition.pdf' class='button btn btn-light' target='_blank'>View Assignment</a>
                    <a href= '../../DummyFiles/exam_definition.pdf' class='button btn btn-light' target='_blank'>View Exam</a>
                </td>
                <td scope='row' colspan='4'>
                    <a href = '#' class='btn btn-info btn-md active' role='button' aria-pressed='true'>Edit Learning Outcome</a>
                </td>
            </tr>
        </tbody>";
        }
            page += 
        @"</table>
    </article>
    </body>";
            ViewData["page"] = page;
            return View();
        }
    }
}