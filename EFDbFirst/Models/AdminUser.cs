using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class AdminUser
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Surname { get; set; }
}
