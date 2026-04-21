using System;
using System.Collections.Generic;

namespace EFCore_DB_FirstApproach_4DBConnection.NorthwindDBModels;

public partial class Department
{
    public int Deptid { get; set; }

    public string? Deptname { get; set; }

    public string? Deptlocation { get; set; }
}
