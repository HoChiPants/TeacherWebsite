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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        private readonly LearningModel _context;
        private readonly RoleManager<IdentityRole> _rolecontext;
        private readonly UserManager<IdentityUser> _usercontext;

        public HomeController(LearningModel context, RoleManager<IdentityRole> rolecontext, UserManager<IdentityUser> usercontext)
        {
            _context = context;
            _rolecontext = rolecontext;
            _usercontext = usercontext;
        }

        public async Task<IActionResult> Index()
        {
            var id = (await _usercontext.GetUserAsync(HttpContext.User))?.Id.ToString();
            ViewData["name"] = id;
            return View();
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditRole(string id)
        {
            ViewData["roles"] = string.Join(",", _rolecontext.Roles.ToList());
            ViewData["users"] = string.Join(",", _usercontext.Users.ToList());

            Dictionary<string, List<string>> tempDic = new Dictionary<string, List<string>>();

            foreach (var user in _usercontext.Users.ToList())
            {
                List<string> tempString = new List<string>();
                foreach (string w in await _usercontext.GetRolesAsync(user))
                {
                    tempString.Add(w);
                }
                tempDic.Add(user.Email, tempString);
            }
            ViewData["usersroles"] = tempDic;
            return View();
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int? id)
        {
            return View(await _context.Courses.ToListAsync());
        }
        


        [Authorize(Roles ="Admin")]
        public async Task<IActionResult>editCourse(int? id)
        {
            if (id == null)
                return NotFound();
            Course course = await _context.Courses.Include(o => o.LearningOutcomes).FirstOrDefaultAsync(m => m.CourseId == id);
            if (course == null)
                return NotFound();
            return View(course);
 
        }


        [Authorize(Roles = "Chair")]
        public async Task<IActionResult> Department()
        {
            return View(await _context.Courses.ToListAsync());
        }


        [Authorize(Roles = "Instructor, Chair")]
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

        [Authorize(Roles = "Instructor")]
        public async Task<IActionResult> PersonalCourse(string id)
        {
            if (id == null)
                return NotFound();

            return View(await _context.Courses.Where(courses => courses.UserId == id).ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}