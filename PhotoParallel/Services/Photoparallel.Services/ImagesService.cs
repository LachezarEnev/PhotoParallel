namespace Photoparallel.Services
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;
    using Photoparallel.Common;
    using Photoparallel.Services.Contracts;

    public class ImagesService : IImagesService
    {
        public async void UploadImageAsync(IFormFile formImage, string path)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await formImage.CopyToAsync(stream);
            }
        }

        public async Task<IEnumerable<string>> UploadImagesAsync(IList<IFormFile> formImages, int images, string template, int id)
        {
            var imageUrls = new List<string>();

            for (int i = 0; i < formImages.Count; i++)
            {
                var urlName = $"Id{id}_{images + i}";

                var imagePath = string.Format(template, urlName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await formImages[i].CopyToAsync(stream);
                }

                var imageRoot = imagePath.Replace(GlobalConstants.Wwwroot, string.Empty);
                imageUrls.Add(imageRoot);
            }

            return imageUrls;
        }
    }
}
