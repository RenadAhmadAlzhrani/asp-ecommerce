using CodeCrafters_backend_teamwork.src.DTOs;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Abstractions
{

    public interface ICategoryService
    {
        public IEnumerable<CategoryReadDto> FindMany();
        public Category? FindOne(Guid categoryId);

        public CategoryReadDto CreateOne(CategoryCreateDto newCategory);

        public Category UpdateOne(Guid categoryId, Category updatedCategory);

        public IEnumerable<Category>? DeleteCategory(Guid categoryId);


    }

}