using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLog
{
    public DateTime? DDatum { get; set; }

    public int? KBenutzer { get; set; }

    public string? CLog { get; set; }

    public int? NTyp { get; set; }

    public int? NVorgang { get; set; }
}
