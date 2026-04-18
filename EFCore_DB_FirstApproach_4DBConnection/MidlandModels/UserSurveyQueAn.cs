using System;
using System.Collections.Generic;

namespace EFCore_DB_FirstApproach_4DBConnection.MidlandModels;

public partial class UserSurveyQueAn
{
    public int? QuestionOrder { get; set; }

    public int? QuestionId { get; set; }

    public string? QuestionText { get; set; }

    public string? ResponseValue { get; set; }
}
