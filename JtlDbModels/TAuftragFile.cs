using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragFile
{
    public int KAuftragFile { get; set; }

    public int KAuftrag { get; set; }

    public int KFile { get; set; }

    public int KBenutzer { get; set; }

    public string? CFilename { get; set; }

    public int? NDokumentTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAuftrag KAuftragNavigation { get; set; } = null!;

    public virtual TFile KFileNavigation { get; set; } = null!;
}
