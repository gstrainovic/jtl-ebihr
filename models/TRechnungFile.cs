using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungFile
{
    public int KRechnungFile { get; set; }

    public int KRechnung { get; set; }

    public int KFile { get; set; }

    public int KBenutzer { get; set; }

    public string? CFilename { get; set; }

    public int? NDokumentTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TFile KFileNavigation { get; set; } = null!;

    public virtual TRechnung1 KRechnungNavigation { get; set; } = null!;
}
