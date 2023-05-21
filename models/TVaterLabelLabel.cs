using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVaterLabelLabel
{
    public int KVaterLabelLabel { get; set; }

    public int KVater { get; set; }

    public int KLabel { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TLabel KLabelNavigation { get; set; } = null!;

    public virtual TLabel KVaterNavigation { get; set; } = null!;
}
