using Microsoft.AspNetCore.Mvc;

namespace ABCRetailproject.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> FeaturedProducts { get; set; } = new List<Product>();
        public int CustomerCount { get; set; }
        public int ProductCount { get; set; }
        public int OrderCount { get; set; }
    }
}
