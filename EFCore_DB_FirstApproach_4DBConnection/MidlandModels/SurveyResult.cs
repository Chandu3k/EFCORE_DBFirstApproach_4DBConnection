using System;
using System.Collections.Generic;

namespace EFCore_DB_FirstApproach_4DBConnection.MidlandModels;

public partial class SurveyResult
{
    public string? UserSurveyId { get; set; }

    public string? Name { get; set; }

    public string? Timestamp { get; set; }

    public string? UserId { get; set; }
}
