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
 *    Controller for the Learning Outcomes. Handles the webpages under LearningOutcome
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class LearningOutcomeController : Controller
    {
        private readonly LearningModel _context;

        public LearningOutcomeController(LearningModel context)
        {
            _context = context;
        }

        // GET: LearningOutcome
        public async Task<IActionResult> Index()
        {
            return View(await _context.LearningOutcomes.ToListAsync());
        }

        // GET: LearningOutcome/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var learningOutcome = await _context.LearningOutcomes
                .FirstOrDefaultAsync(m => m.LearningId == id);
            if (learningOutcome == null)
            {
                return NotFound();
            }

            return View(learningOutcome);
        }

        // GET: LearningOutcome/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LearningOutcome/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LearningId,Name,Description,CourseInstanceId")] LearningOutcome learningOutcome)
        {
            if (ModelState.IsValid)
            {
                _context.Add(learningOutcome);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(learningOutcome);
        }

        // GET: LearningOutcome/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var learningOutcome = await _context.LearningOutcomes.FindAsync(id);
            if (learningOutcome == null)
            {
                return NotFound();
            }
            return View(learningOutcome);
        }

        // POST: LearningOutcome/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LearningId,Name,Description,CourseInstanceId")] LearningOutcome learningOutcome)
        {
            if (id != learningOutcome.LearningId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(learningOutcome);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LearningOutcomeExists(learningOutcome.LearningId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(learningOutcome);
        }

        // GET: LearningOutcome/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var learningOutcome = await _context.LearningOutcomes
                .FirstOrDefaultAsync(m => m.LearningId == id);
            if (learningOutcome == null)
            {
                return NotFound();
            }

            return View(learningOutcome);
        }

        // POST: LearningOutcome/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var learningOutcome = await _context.LearningOutcomes.FindAsync(id);
            _context.LearningOutcomes.Remove(learningOutcome);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LearningOutcomeExists(int id)
        {
            return _context.LearningOutcomes.Any(e => e.LearningId == id);
        }
    }
}
