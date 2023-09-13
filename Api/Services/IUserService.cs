using Api.Dtos;

namespace ApiIncidencias.Services;

public interface IUserService
{
    Task<string> RegisterAsync(RegisterDto model);
    Task<DatosUsuarioDto> GetTokenAsync(LoginDto model);
    Task<string> AddRoleAsync(AddRolDto model);
}
