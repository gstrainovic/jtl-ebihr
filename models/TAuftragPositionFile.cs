using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAuftragPositionFile
{
    public int KAuftragPositionFile { get; set; }

    public int KAuftragPosition { get; set; }

    public int KAuftrag { get; set; }

    public int KFile { get; set; }

    public int KBenutzer { get; set; }

    public string? CFilename { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAuftragPosition KAuftragPositionNavigation { get; set; } = null!;

    public virtual TFile KFileNavigation { get; set; } = null!;
}
