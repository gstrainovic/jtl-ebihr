using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWidgetTemplateSetting
{
    public int KWidgetTemplateSettings { get; set; }

    public int? KWidgetTemplate { get; set; }

    public string? CTitel { get; set; }

    public string? CBeschreibung { get; set; }

    public int? NType { get; set; }

    public string? CKey { get; set; }

    public string? CValue { get; set; }

    public int? NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
