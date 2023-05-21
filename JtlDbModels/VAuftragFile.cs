using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VAuftragFile
{
    public int KAuftrag { get; set; }

    public int KFile { get; set; }

    public int KBenutzer { get; set; }

    public string? CFilename { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? NDokumentTyp { get; set; }
}
