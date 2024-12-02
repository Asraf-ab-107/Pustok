using Pustok_task_1.Models.BaseEntity;

namespace Pustok_task_1.Models
{
    public class ProductImages :BaseClass
    {
        public string ImgUrl { get; set; }
        public string FirstImgUrl { get; set; }
        public int productId { get; set; }
        public Product Products { get; set; }
    }
}
