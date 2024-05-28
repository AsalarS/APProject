using HomeCareObjects.Model;

namespace HomeCareWebApp.ViewModels
{
    public class TechniciansServicesViewModel
    {
        public Service Service { get; set; }
        public IEnumerable<User> Technicians { get; set; }
    }
}
