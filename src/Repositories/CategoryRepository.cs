using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private IEnumerable<Category> _categories = [];
        private DatabaseContext _databaseContext;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _categories = databaseContext.Category;
        }

        public IEnumerable<Category> CreateOne(Category newCategory)
        {
            _categories = _categories.Append(newCategory);
            return _categories;
        }

        public Category? FindOne(Guid categoryId) //doesn't work
        {
            return _categories.FirstOrDefault((category) => category.Id == categoryId);
        }

        public IEnumerable<Category> FindMany()
        {
            return _categories;
        }

        public IEnumerable<Category>? DeleteCategory(Guid categoryId)
        {

            _categories.Where((c) => c.Id != categoryId);
            return _categories;

        }


        public Category UpdateOne(Guid categoryId, Category updatedCategory)
        {

            Category? category = _categories.FirstOrDefault(category => category.Id == categoryId);
            if (category != null)
            {
                category.Id = updatedCategory.Id;
                return category;
            }

            return updatedCategory;

        }
    }
}