namespace Day2InClass.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal? OriginalPrice { get; set; } // Giá gốc (có thể null)
        public int Stock { get; set; } // Số lượng sản phẩm hiện có
        public int TotalStock { get; set; } // Tổng số lượng sản phẩm
        public string Image { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string DetailedDescription { get; set; } = string.Empty;
        public string Screen { get; set; } = string.Empty;
        public string OS { get; set; } = string.Empty;
        public string Camera { get; set; } = string.Empty;
        public string RAM { get; set; } = string.Empty;
        public string Storage { get; set; } = string.Empty;
        public string Warranty { get; set; } = string.Empty;
    }
}
