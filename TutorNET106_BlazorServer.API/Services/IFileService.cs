namespace TutorNET106_BlazorServer.API.Services
{
    public interface IFileService
    {
        Task<int> UploadFiles(IFormFile file);
    }
}
