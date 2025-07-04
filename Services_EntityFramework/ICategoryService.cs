using BusinessObjects_EntityFramework;

namespace Services_EntityFramework
{
    public interface ICategoryService
    {
        public List<Category> GetCategories();
    }
}
