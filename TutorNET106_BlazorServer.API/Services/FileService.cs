
using TutorNET106_BlazorServer.API.Repos;

namespace TutorNET106_BlazorServer.API.Services
{
    public class FileService : IFileService
    {
        private readonly IFileRepo _fileRepo;
        public FileService(IFileRepo fileRepo)
        {
            _fileRepo = fileRepo;
        }

        public async Task<int> UploadFiles(IFormFile file)
        {
            return await _fileRepo.UploadFiles(file);
        }
    }
}
