using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VRechnungFile
{
    public int KRechnungFile { get; set; }

    public int KRechnung { get; set; }

    public int KFile { get; set; }

    public int KBenutzer { get; set; }

    public string? CFilename { get; set; }

    public int? NDokumentTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
