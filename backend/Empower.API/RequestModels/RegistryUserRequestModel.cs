namespace Empower.API.RequestModels
{
    public record RegistryUserRequestModel(
        string UserName,
        string Email,
        string Password,
        string PasswordConfirmation)
    {
    }
}
