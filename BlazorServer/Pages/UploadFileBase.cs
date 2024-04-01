using BlazorServer.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorServer.Pages
{
    public class UploadFileBase : ComponentBase
    {
        [Inject]
        public IFileService FileService { get; set; }

        //public IBrowserFile file { get; set; }
        public List<IBrowserFile> files { get; set; } = new List<IBrowserFile>();
        protected async Task InputFileChange(InputFileChangeEventArgs e)
        {
            //file = e.File;
            files.Clear();
            files.AddRange(e.GetMultipleFiles(e.FileCount));
        }

        protected async Task Upload()
        {
            foreach (var file in files)
            {
                await FileService.UploadFiles(file);
            }

        }
    }
}
