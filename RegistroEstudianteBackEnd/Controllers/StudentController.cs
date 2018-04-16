using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistroEstudianteBackEnd.Models;
using Newtonsoft.Json;

namespace RegistroEstudianteBackEnd.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string getAllStudents()
        {

            List<StudentModel> lstStudent = StudentModel.getAllStudents();

            return JsonConvert.SerializeObject(lstStudent);

        }
    }
}