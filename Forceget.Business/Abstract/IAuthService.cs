using Forceget.Core.Entities;
using Forceget.Core.Utilities.Results;
using Forceget.Core.Utilities.Security.JWT;
using Forceget.Entities.Dtos;

namespace Forceget.Business.Abstract
{
    public interface IAuthService
    {
        Task<IResult> RegisterAsync(UserForRegisterDto userForRegisterDto, string password);
        Task<IDataResult<User>> LoginAsync(UserForLoginDto userForLoginDto);
        Task<IResult> UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
