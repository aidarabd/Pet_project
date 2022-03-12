using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspInAction.Interfaces;
using AspInAction.Middlewares.Filters;
using DBAccess.Models;
using DBAccess.Services;
using DBAccess.Services.Base;
using Microsoft.Extensions.Configuration;

namespace AspInAction.Controllers
{
    [LogControllerFilter, ExceptionHandler]
    public class UserController : Controller
    {
        private IConfiguration _conf;
        private UnitOfWork _uow;
        public UserController(AppDbContext dbContext, UnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public IActionResult Calldi([FromServices] IEmailSender emailSender, string mes)
        {
            
            var hash = emailSender.GetHashCode();
            emailSender.sendMessage();
            return StatusCode(200);
        }

        public IActionResult Calldit([FromServices] IConfiguration conf)
        {
            _conf = conf;
            var s = conf["Logging:LogLevel:Default"];
            return StatusCode(200);
        }

        public IActionResult Session()
        {
            return StatusCode(200);
        }

        //[LogActionFilter]
        public IActionResult Uow()
        {
            //int a = 2;
            //int b = a - 2;
            //int c = a / b;
            //_uow.Recipes.Add(new Recipe()
            //{
            //    IsDeleted = false,
            //    IsVegetarian = false,
            //    Method = 3,
            //    Name = "gulyaj",
            //    TimeToCook = new TimeSpan(12)
            //});

            //var recipeId = _uow.Save();
            //_uow.Ingredients.Add(new Ingredient()
            //{
            //    Name = "Tomato",
            //    Quantity = 3,
            //    Unit = "Piece",
            //    RecipeId = recipeId
            //});

            var res = _uow.Ingredients.Get(2);

            //return Json(res);

            //_uow.Save();
            return StatusCode(200);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
