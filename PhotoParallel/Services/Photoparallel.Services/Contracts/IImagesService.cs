namespace Photoparallel.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public interface IImagesService
    {
        Task<IEnumerable<string>> UploadImagesAsync(IList<IFormFile> formImages, int count, string template, int id);
    }
}
