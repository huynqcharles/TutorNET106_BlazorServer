using BlazorServer.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorServer.Pages
{
    public class UploadFileBase : ComponentBase
    {
        [Inject]
        public IFileService FileService { get; set; }

        public IBrowserFile file { get; set; }
        protected async Task InputFileChange(InputFileChangeEventArgs e)
        {
            file = e.File;
        }

        protected async Task Upload()
        {
            await FileService.UploadFiles(file);
        }
    }
}
