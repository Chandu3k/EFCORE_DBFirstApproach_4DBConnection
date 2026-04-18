using System;
using System.Collections.Generic;

namespace EFCore_DB_FirstApproach_4DBConnection.MidlandModels;

public partial class MastEmployeeDetail
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public decimal? EmpSalary { get; set; }

    public string? EmpStatus { get; set; }

    public string? EmpDesignation { get; set; }
}
