using Pustok_task_1.Models.BaseEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok_task_1.Models
{
    public class Slider: BaseClass
    {
        public string Author { get; set; }
        public string Author2 { get; set; }
        public string info { get; set; }
        public string buttonText { get; set; }
        public string? ImgUrl { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
