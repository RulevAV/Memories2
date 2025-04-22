using System;
using System.Collections.Generic;

namespace Memories2.Server.Model;

public partial class User
{
    public Guid? Id { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public string? Mail { get; set; }
}
