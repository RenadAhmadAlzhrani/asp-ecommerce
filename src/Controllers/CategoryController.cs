using System;
using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Controllers;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;

using Microsoft.AspNetCore.Mvc;



namespace CodeCrafters_backend_teamwork.src.Controller

{


    public class CategoryController : CustomizedController

    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)

        {
            // category = new DatabaseContext().Category; 
            _categoryService = categoryService;

        }



        [HttpGet]
        public IEnumerable<Category> FindMany()
        {

            return _categoryService.FindMany();

        }

        [HttpGet("{categoryId}")]
        public Category? FindOne(Guid categoryId)
        {

            return _categoryService.FindOne(categoryId);

        }


        [HttpPost]
        public IEnumerable<Category> CreateOne([FromBody] Category category)

        {

            return _categoryService.CreateOne(category);

        }



        [HttpDelete("{categoryId}")]
        public IEnumerable<Category> DeleteCategory([FromRoute] Guid categoryId)
        {
            return _categoryService.DeleteCategory(categoryId);
        }

        [HttpPatch("{categoryId}")]
        public Category UpdateOne(Guid categoryId, Category updatedCategory)
        {
            return _categoryService.UpdateOne(categoryId, updatedCategory);
        }



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

