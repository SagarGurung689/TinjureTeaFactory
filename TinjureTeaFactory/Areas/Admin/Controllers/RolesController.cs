﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinjureTeaFactory.Models;

namespace TinjureTeaFactory.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<AppUser> userManager;


        public RolesController(RoleManager<IdentityRole> roleManager,
                                 UserManager<AppUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;

        }


        //GET /admin/roles

        public IActionResult Index() => View(roleManager.Roles);

        //GET /admin/roles/create
        public IActionResult Create() => View();


       
    }
}
