using Cloudinary.Actions

namespace API.Interfaces;

public interface IPhotoService
{
     Task<ImageUploadResult>AddPhotoAsync(IFormFile file);
     Task<DeletionResult>DeletePhotosAsync(string publicId);

}
