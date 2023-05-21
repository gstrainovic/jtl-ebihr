using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWidgetBenutzer
{
    public int KWidgetBenutzer { get; set; }

    public int? KWidgetTemplate { get; set; }

    public int? KBenutzer { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
