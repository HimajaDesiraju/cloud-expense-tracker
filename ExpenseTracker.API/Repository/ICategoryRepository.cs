using System;
using Models;
namespace Repository{
    public interface ICategoryRepository{
        bool AddCategory(Category categorydata);
        bool UpdateCategory(Category categorydata);
        bool DeleteCategory(string CategoryId);
        IList<Category> GetCategories();
        Category GetCategoryById(string CategoryId);
    }
}