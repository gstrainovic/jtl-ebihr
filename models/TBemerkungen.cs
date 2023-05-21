using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBemerkungen
{
    public int KBemerkungen { get; set; }

    public string? CName { get; set; }

    public string? CString { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
