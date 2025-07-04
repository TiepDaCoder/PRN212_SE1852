using BusinessObjects_EntityFramework;
using Repositories_EntityFramework;

namespace Services_EntityFramework
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository repository;
        public CategoryService()
        {
            repository = new CategoryRepository();
        }
        public List<Category> GetCategories()
        {
            return repository.GetCategories();
        }
    }
}