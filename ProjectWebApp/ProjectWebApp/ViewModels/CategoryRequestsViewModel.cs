using HomeCareObjects.Model;

namespace HomeCareWebApp.ViewModels
{
    public class CategoryRequestsViewModel
    {
        public int ActiveRequests { get; set; }
        public int PendingRequests { get; set; }
        public int CompletedRequests { get; set; }
        public int OverdueRequests { get; set; }
        public Category Category { get; set; }
    }
}
