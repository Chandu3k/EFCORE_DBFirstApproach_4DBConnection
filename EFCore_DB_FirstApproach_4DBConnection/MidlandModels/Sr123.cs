using System;
using System.Collections.Generic;

namespace EFCore_DB_FirstApproach_4DBConnection.MidlandModels;

public partial class Sr123
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
