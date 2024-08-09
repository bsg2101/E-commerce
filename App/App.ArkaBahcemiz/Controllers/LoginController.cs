using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.ArkaBahcemiz.Data;
using App.ArkaBahcemiz.Models.DTOs;
using App.ArkaBahcemiz.Services;

namespace App.ArkaBahcemiz.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserService _userService;

        public LoginController(UserService userService)
        {
            _userService = userService;
        }


        // GET: Login
       
        public  IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserDTO userDTO)
        {
            if (userDTO != null)
            {
                var User = await _userService.GetOrderByEmail(userDTO);
                if (User != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }


        //// POST: Login/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Name,Email,Password")] UserDTO userDTO)
        //{
        //    if (ModelState.IsValid)
        //    {

        //    }
        //    return View(userDTO);
        //}

        //// GET: Login/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{

        //    return View();
        //}

        //// POST: Login/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Password")] UserDTO userDTO)
        //{


        //    return View();
        //}

        //// GET: Login/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{


        //    return View();
        //}

        //// POST: Login/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{

        //    return RedirectToAction(nameof(Index));
        //}

    }
}
