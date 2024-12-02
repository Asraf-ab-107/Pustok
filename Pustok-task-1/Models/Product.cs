using Pustok_task_1.Models.BaseEntity;
using System.ComponentModel.DataAnnotations;

namespace Pustok_task_1.Models
{
    public class Product:BaseClass
    {
        public string Tags { get; set; }
        [Required,StringLength(30,ErrorMessage ="maksimum simvaol sayi 30")]
        public string ProductTitle { get; set; }
        public string Author { get; set; }
        public string ExTax { get; set; }
        public string Brands { get; set; }
        public string ProductCode { get; set; }
        public string RewardPoints { get; set; }
        public string Availability { get; set; }
        public int price { get; set; }
        [Required, StringLength(300, ErrorMessage = "maksimum simvaol sayi 300")]
        public string description { get; set; }
        public Catagory Catagory {  get; set; }
        public List<TagProducts> TagProducts { get; set; }
        public List<ProductImages> ProductImages { get; set; }

    }
}
