using System.Collections.Generic;
using System.Threading.Tasks;
using SocialApp_API.Helpers;
using SocialApp_API.Models;

namespace SocialApp_API.Data
{
    public interface ISocialRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<PagedList<User>> GetUsers(UserParams userParams);
        Task<User> GetUser(int id);
        Task<Photo> GetPhoto(int id);
        Task<Photo> GetMainPhotoForUser(int userId);
        Task<Like> GetLike(int userId, int recipientId);
    }
}