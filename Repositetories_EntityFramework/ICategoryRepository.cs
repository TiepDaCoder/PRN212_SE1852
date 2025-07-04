using BusinessObjects_EntityFramework;

namespace Repositories_EntityFramework
{
    public interface ICategoryRepository
    {
        public List<Category> GetCategories();
    }
}