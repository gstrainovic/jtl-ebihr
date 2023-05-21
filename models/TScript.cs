using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TScript
{
    public int KScript { get; set; }

    public string CName { get; set; } = null!;

    public byte[] CData { get; set; } = null!;

    public int NSort { get; set; }

    public bool NDebug { get; set; }

    public bool NVerbose { get; set; }

    public int? KDirectory { get; set; }

    public int KBenutzer { get; set; }

    public DateTime DCreated { get; set; }

    public DateTime DModified { get; set; }

    public bool NEnabled { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TDirectory? KDirectoryNavigation { get; set; }
}
