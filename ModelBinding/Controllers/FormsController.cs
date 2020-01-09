﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class FormsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // When user clicks "submit" and sends form data
        [HttpPost] // When you post data to the server
        public IActionResult Index(IFormCollection data)
        {
            // Validate all form data

            // Map form data to C# object

            Student s = new Student();
            s.FullName = data["full-name"];
            s.DateOfBirth = Convert.ToDateTime(data["dob"]);
            s.FavoriteNumber = Convert.ToInt32(data["fav-number"]);

            // Add to database

            ViewData["Message"] = "Student added successfully";

            return View();
        }
    }
}