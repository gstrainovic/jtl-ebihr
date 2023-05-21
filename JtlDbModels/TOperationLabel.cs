using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TOperationLabel
{
    public int KOperation { get; set; }

    public int KLabel { get; set; }

    public virtual TOperation KOperationNavigation { get; set; } = null!;
}
