using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TCsvSetting
{
    public string CKey { get; set; } = null!;

    public string CDelmiter { get; set; } = null!;

    public string CQuote { get; set; } = null!;

    public string CEscape { get; set; } = null!;

    public string CComment { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
