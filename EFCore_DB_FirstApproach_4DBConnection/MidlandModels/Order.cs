using System;
using System.Collections.Generic;

namespace EFCore_DB_FirstApproach_4DBConnection.MidlandModels;

public partial class Order
{
    public int Orderid { get; set; }

    public string? Ordername { get; set; }

    public string? Orderlocation { get; set; }
}
