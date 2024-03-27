using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutorNET106_BlazorServer.API.Services;

namespace TutorNET106_BlazorServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IFileService _fileService;
        public FilesController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            var fileId = await _fileService.UploadFiles(file);

            if (fileId == -1)
            {
                return BadRequest("No file uploaded.");
            }
            else
            {
                return Ok(fileId);
            }
        }
    }
}
