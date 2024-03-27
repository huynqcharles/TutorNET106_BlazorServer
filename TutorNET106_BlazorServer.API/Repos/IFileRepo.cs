namespace TutorNET106_BlazorServer.API.Repos
{
    public interface IFileRepo
    {
        Task<int> UploadFiles(IFormFile file);
    }
}
