using System;
using System.Collections.Generic;

namespace EFCore_DB_FirstApproach_4DBConnection.NorthwindDBModels;

public partial class CustomerAndSuppliersByCity
{
    public string? City { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ContactName { get; set; }

    public string Relationship { get; set; } = null!;
}
