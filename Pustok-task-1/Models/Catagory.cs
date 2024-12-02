using Pustok_task_1.Models.BaseEntity;
using System.ComponentModel.DataAnnotations;

namespace Pustok_task_1.Models
{
    public class Catagory:BaseClass
    {
        [Required,StringLength(15,ErrorMessage ="Max 15 simvol"),
            MinLength(3,ErrorMessage ="min 3 simvol")]

        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
