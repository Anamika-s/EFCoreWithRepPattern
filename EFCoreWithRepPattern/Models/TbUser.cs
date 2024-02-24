using System;
using System.Collections.Generic;

namespace EFCoreWithRepPattern.Models;

public partial class TbUser
{
    public int Email { get; set; }

    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Password { get; set; } = null!;

    public int Age { get; set; }
}
