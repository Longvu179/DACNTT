namespace MobiSell.Services
{
    public interface IFileService
    {
        Task<List<string>> SaveFilesAsync(IEnumerable<IFormFile> imgFile);
        Task DeleteFileAsync(string fileName);
    }
    public class FileService : IFileService
    {
        public async Task<List<string>> SaveFilesAsync(IEnumerable<IFormFile> imgFiles)
        {
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
            var savedFileNames = new List<string>();

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            foreach (var imgFile in imgFiles)
            {
                var extension = Path.GetExtension(imgFile.FileName).ToLower();
                if (!allowedExtensions.Contains(extension))
                {
                    throw new Exception($"Invalid file type: {imgFile.FileName}. Only JPG, PNG, JPEG, and GIF are allowed.");
                }

                var fileName = Path.GetRandomFileName() + DateTime.Now.ToString("yyyyMMddHHmmss") + extension;
                var fullPath = Path.Combine(filePath, fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await imgFile.CopyToAsync(stream);
                }

                savedFileNames.Add(fileName);
            }

            return savedFileNames;
        }

        public Task DeleteFileAsync(string fileName)
        {
            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
            var filePath = Path.Combine(uploadsFolder, fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            return Task.CompletedTask;
        }
    }
}
