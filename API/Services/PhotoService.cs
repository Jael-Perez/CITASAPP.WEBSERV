
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet.Actions;

namespace API.Services;
public class PhotoService : IPhotoService
{
    public Task<ImageUploadResult> AddPhotoAsync(IFormFile file)
    {
        throw new NotImplementedException();
    }
    

    public Task<DeletionResult> DeletePhotoAsync(string publicid)
    {
        throw new NotImplementedException();
    }
}
