using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPicklisteVorlageArtikelLabel
{
    public int KPicklisteVorlage { get; set; }

    public int KLabel { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
