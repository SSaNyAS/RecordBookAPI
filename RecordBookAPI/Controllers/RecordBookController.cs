using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecordBookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecordBookAPI.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RecordBookAPI.DataLoader.RecordBookDataManagers;

namespace RecordBookAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecordBookController : ControllerBase
    {
        private RecordBookDataManager DataManager { get; }
        private readonly ILogger<RecordBookController> _logger;
        public RecordBookController(RecordBookContext context,ILogger<RecordBookController> logger)
        {
            DataManager = new RecordBookDataManager(context);
            _logger = logger;
        }
        [HttpGet("/departments")]
        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await DataManager.DepartmentLoader.GetAllAsync();
        }
        [HttpGet("/exambooks")]
        public async Task<IEnumerable<ExamBook>> GetExamBooks()
        {
            return await DataManager.ExamBookLoader.GetAllAsync();
        }
        [HttpGet("/students")]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await DataManager.StudentLoader.GetAllAsync();
        }

        [HttpPost("/createDepartment")]
        public async Task<IActionResult> AddDepartment(Department department)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await DataManager.AddItem(department))
                        return Created("/createDepartment", department);
                }
            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Error adding Department", department);
                return this.Conflict(error);
            }
            return this.Conflict();
        }
    }
}
