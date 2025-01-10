using Day2InClass.Data;
using Microsoft.AspNetCore.Mvc;

namespace Day2InClass.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = DummyData.GetProducts();
            return View(products); // Trả dữ liệu cho View
        }
        public IActionResult Details(int id)
        {
            var products = DummyData.GetProducts(); // Lấy danh sách sản phẩm
            var product = products.FirstOrDefault(p => p.Id == id); // Tìm sản phẩm theo ID
            if (product == null)
            {
                return NotFound("Không tìm thấy sản phẩm!"); // Xử lý khi không tìm thấy
            }
            return View(product); // Trả sản phẩm đến View
        }
    }
}
