using System;
using System.Collections.Generic;

namespace EFCore_DB_FirstApproach_4DBConnection.NorthwindDBModels;

public partial class SummaryOfSalesByYear
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
