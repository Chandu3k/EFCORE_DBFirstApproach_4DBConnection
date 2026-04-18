using System;
using System.Collections.Generic;

namespace EFCore_DB_FirstApproach_4DBConnection.MidlandModels;

public partial class MastUser
{
    public string? TxnId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Userroll { get; set; }
}
