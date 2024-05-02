// using System;
// using System.Collections.Generic;

// using System.Linq;

// using System.Threading.Tasks;
// using CodeCrafters_backend_teamwork.src.Databases;
// using CodeCrafters_backend_teamwork.src.Entities;

// using Microsoft.AspNetCore.Mvc;



// namespace CodeCrafters_backend_teamwork.src.Controller

// {

//     [ApiController]

//     [Route("api/[controller]")]

//     public class CategoryController : ControllerBase

//     {

//         public IEnumerable<CategoryController> category;



//         public CategoryController()

//         {

//             category = new DatabaseContext().Category;

//         }



//         [HttpGet]

//         public IEnumerable<CategoryController> FindAll()

//         {

//             return category;

//         }



//         [HttpGet("{productId}")]

//         public CategoryController FindOne(CategoryController category)

//         {

//             return category;

//         }



//         [HttpPost]

//         public CategoryController CreateOne(CategoryController category)

//         {

//             return category;

//         }









//     }
// }