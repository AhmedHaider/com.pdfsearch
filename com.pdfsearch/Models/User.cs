using System.ComponentModel;

namespace com.pdfsearch.Models;

public class User
{
    public int Id { get; set; }

    [DisplayName("User Name")]
    public string Username { get; set; }

    [DisplayName("Password")]
    public string Password { get; set; } = string.Empty;

    [DisplayName("Authorization")]
    public bool IsAuthorized { get; set; } = true;

    [DisplayName("Created At")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
