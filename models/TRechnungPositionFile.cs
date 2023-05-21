using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungPositionFile
{
    public int KRechnungPositionFile { get; set; }

    public int KRechnungPosition { get; set; }

    public int KRechnung { get; set; }

    public int KFile { get; set; }

    public int KBenutzer { get; set; }

    public string? CFilename { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TFile KFileNavigation { get; set; } = null!;

    public virtual TRechnung1 KRechnungNavigation { get; set; } = null!;

    public virtual TRechnungPosition KRechnungPositionNavigation { get; set; } = null!;
}
