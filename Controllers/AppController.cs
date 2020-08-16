﻿using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IDutchRepository _repository;

        public AppController(IMailService mailService, IDutchRepository  repository )
        {
            _mailService = mailService;
            _repository = repository;
        }

        public IActionResult Index()
        {
         //   var results = _ctx.Products.ToList();
            return View();
        }


        [HttpGet("contact")]
        public IActionResult Contact()
        {
           return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {

            if (ModelState.IsValid)
            {
                // send the email
                _mailService.SendMessage("oshan.m@yahoo.com", model.Subject, $"Form: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            else
            {
                // show the error
            }
            return View();
        }
        
        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }


        public IActionResult Shop()
        {

            return View();
        }
    }
}
