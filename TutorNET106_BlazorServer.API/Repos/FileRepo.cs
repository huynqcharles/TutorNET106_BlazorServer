
using Shared;
using TutorNET106_BlazorServer.API.Data;

namespace TutorNET106_BlazorServer.API.Repos
{
    public class FileRepo : IFileRepo
    {
        private readonly MyDbContext _dbContext;
        private readonly IWebHostEnvironment _environment;

        public FileRepo(MyDbContext dbContext, IWebHostEnvironment environment)
        {
            _dbContext = dbContext;
            _environment = environment;
        }

        public async Task<int> UploadFiles(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return -1;
            }

            // luu file vao wwwroot
            var filePath = Path.Combine(_environment.ContentRootPath,
                "wwwroot", "uploads", file.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // luu thong tin file vao db
            var fileUploaded = new FileUpload
            {
                FileName = file.FileName,
                ContentType = file.ContentType,
                Content = await ReadFileContentAsync(filePath)
            };
            _dbContext.FileUploads.Add(fileUploaded);
            await _dbContext.SaveChangesAsync();

            return fileUploaded.Id;
        }

        private async Task<byte[]> ReadFileContentAsync(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                using(var memoryStream = new MemoryStream())
                {
                    await stream.CopyToAsync(memoryStream);
                    return memoryStream.ToArray();
                }
            }
        }
    }
}
