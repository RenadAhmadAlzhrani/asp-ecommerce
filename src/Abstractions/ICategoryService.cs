using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Entities;


namespace CodeCrafters_backend_teamwork.src.Abstractions

{

    public interface ICategoryService

    {
        public IEnumerable<Category> FindMany();
        public Category? FindOne(Guid id);

        public IEnumerable<Category> CreateOne(Category newCategory);

        public Category UpdateOne(Guid categoryId,Category updatedCategory);

        public IEnumerable<Category>? DeleteCategory(Guid categoryId);

    }

}