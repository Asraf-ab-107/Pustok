using Pustok_task_1.Models;

namespace Pustok_task_1.Helpers
{
    public static class FileExtension
    {
        public static string Upload(this IFormFile file, string rootpath, string folderName)
        {
            string filename = file.FileName;
            string path = Path.Combine(rootpath,folderName,filename);

            using (FileStream stream = new FileStream(path , FileMode.Create))
            {
                file.CopyTo(stream);
            }
           return filename;
        }
    }
}
