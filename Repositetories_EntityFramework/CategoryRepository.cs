using BusinessObjects_EntityFramework;
using DataAccessLayer_EntityFramework;

namespace Repositories_EntityFramework
{
    public class CategoryRepository : ICategoryRepository
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        public List<Category> GetCategories()
        {
            return categoryDAO.GetCategories();
        }
    }
}