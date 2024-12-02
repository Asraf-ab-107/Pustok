using Pustok_task_1.Models.BaseEntity;

namespace Pustok_task_1.Models
{
    public class Tag:BaseClass
    {
        public string Name { get; set; }
        public List<TagProducts> tagProducts { get; set; }
    }
}