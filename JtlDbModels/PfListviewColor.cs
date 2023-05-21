using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfListviewColor
{
    public int NColorId { get; set; }

    public int NSubColorId { get; set; }

    public int NListViewId { get; set; }

    public string? CRgb { get; set; }
}
