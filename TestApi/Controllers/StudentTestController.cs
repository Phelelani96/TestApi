using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApi.Data;
using TestApi.Models;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentTestController : ControllerBase
    {
        private readonly TestApiContext _context;

        public StudentTestController(TestApiContext context)
        {
            _context = context;
        }
        public static List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                FirstName = "First",
                LastName = "User",
                Age = 30,
            },
            new Student()
            {
                Id = 2 ,
                FirstName = "Second",
                LastName = "User",
                Age = 30,
            },
            new Student()
            {
                Id = 3,
                FirstName = "Third",
                LastName = "User",
                Age = 30,
            },
            new Student()
            {
                Id = 4,
                FirstName = "Fourth",
                LastName = "User",
                Age = 30,
            }
        };

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudent()
        {
            try
            {
                if (students == null)
                {
                    return NotFound();
                }
                return Ok(students);
            } catch (Exception ) 
            {
                return BadRequest();
            }
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            try
            {
                var student = students.Find(s => s.Id == id);
                if(student == null)
                {
                    return NotFound();
                }

                return Ok(student);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            try
            {
                if (id != student.Id)
                {
                    return BadRequest();
                }

                var s = students.Find(s => s.Id == id);
                if (s == null)
                {
                    return NotFound();
                }
                s.FirstName = student.FirstName;
                s.LastName = student.LastName;
                s.Age = student.Age;
                return NoContent();
            }
            catch(Exception)
            {
                return BadRequest();
            }
            
        }

        // POST: api/Students
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            try
            {
                students.Add(student);
                return CreatedAtAction("GetStudent", new { id = student.Id }, student);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            try
            {
                var student = students.Find(s => s.Id == id);
                if (student == null)
                {
                    return NotFound();
                }

                students.Remove(student);

                return NoContent();
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }
    }
}
