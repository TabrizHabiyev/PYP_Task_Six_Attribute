using ConsoleApp5.Atributes;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp5.models;

public class User
{
    public string Name { get; set; }

    [EmailValidate]
    public string Email { get; set; }

    [PasswordValidate]
    public string Password { get; set; }
}

