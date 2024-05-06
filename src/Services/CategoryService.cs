using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> CreateOne(Category newCategory)
        {
            return _categoryRepository.CreateOne(newCategory);
        } 

        public IEnumerable<Category> FindMany()
        {
            return _categoryRepository.FindMany();
        }


        public Category? FindOne(Guid categoryId)
        {
            return _categoryRepository.FindOne(categoryId);
        }


        public Category UpdateOne(Guid categoryId, Category updatedCategory)
        {
            return _categoryRepository.UpdateOne(categoryId, updatedCategory);
        }

        public IEnumerable<Category>? DeleteCategory(Guid categoryId)
    {
        return _categoryRepository.DeleteCategory(categoryId);
        }
    }
}