using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TFeldTyp
{
    public int KFeldTyp { get; set; }

    public string CName { get; set; } = null!;

    public byte NDatenTyp { get; set; }

    public string? CRegEx { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
