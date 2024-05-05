 
updateCategoryFeature
using CodeCrafters_backend_teamwork.src.Entities; 

namespace CodeCrafters_backend_teamwork.src.Abstractions 

{ 
    public interface ICategoryRepository 
    { 
        public Category? FindOne(Guid categoryId); 

        public IEnumerable<Category> FindMany(); 

        public IEnumerable<Category> CreateOne(Category newCategory); 

        public Category UpdateOne( Guid categoryId,Category updatedCategory); 

        public IEnumerable<Category>? DeleteCategory(Guid categoryId);
    
using System; 
using System.Collections.Generic; 


// using System.Linq; 

// using System.Threading.Tasks; 

// using CodeCrafters_backend_teamwork.src.Entities; 

 

// namespace CodeCrafters_backend_teamwork.src.Abstractions 

// { 

//     public interface ICategoryRepository 

//     { 

//         public Category FindOne (Guid id); 

//         public Category FindAll (Category name); 

//         public Category CreateOne (Category newCategory); 

//         public Category UpdateOne (Category newCategory); 



        public Category DeleteOne (Guid Id); 
main
    } 


// } 