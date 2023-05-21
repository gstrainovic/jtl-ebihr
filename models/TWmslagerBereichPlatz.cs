using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWmslagerBereichPlatz
{
    public int KWmslagerBereichPlatz { get; set; }

    public int KWmslagerBereich { get; set; }

    public int KWarenLagerPlatz { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
