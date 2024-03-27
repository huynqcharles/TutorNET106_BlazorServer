using Microsoft.AspNetCore.Components.Forms;

namespace BlazorServer.Services
{
    public interface IFileService
    {
        Task UploadFiles(IBrowserFile file);
    }
}
