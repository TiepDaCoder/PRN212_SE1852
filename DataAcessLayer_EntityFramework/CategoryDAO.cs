using BusinessObjects_EntityFramework;

namespace DataAccessLayer_EntityFramework
{
    public class CategoryDAO
    {
        MyStoreContext context = new MyStoreContext();
        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
    }
}