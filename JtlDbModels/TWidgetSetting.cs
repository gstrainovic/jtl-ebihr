using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWidgetSetting
{
    public int KWidgetSettings { get; set; }

    public int? KWidget { get; set; }

    public string? CKey { get; set; }

    public string? CValue { get; set; }

    public string? CArbeitsplatz { get; set; }

    public int? NApplikation { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
