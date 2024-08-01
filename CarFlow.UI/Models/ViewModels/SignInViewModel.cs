#nullable disable

using System.ComponentModel.DataAnnotations;

namespace CarFlow.UI.Models.ViewModels;

public class SignInViewModel
{
    public string Email { get; init; }

    [DataType(DataType.Password)] public string Password { get; init; }
}