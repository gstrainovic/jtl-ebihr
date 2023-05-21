using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TOperationLabel
{
    public int KOperation { get; set; }

    public int KLabel { get; set; }

    public virtual TOperation KOperationNavigation { get; set; } = null!;
}
