using HomeCareObjects.Model;

namespace ProjectWebApp.ViewModels
{
    public class CategoriesIndexViewModel
    {
        public IEnumerable<Category>? Categories { get; set; }
        
        public string SearchString { get; set; }
    }
}
