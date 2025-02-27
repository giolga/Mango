using Mango.Web.Models;

namespace Mango.Web.Services.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto);
        Task<ResponseDto?> RegisterAsync(RegistrationRequestDto registrationRequestDto);
        Task<ResponseDto?> AssignAsync(RegistrationRequestDto registrationRequestDto);
    }
}
