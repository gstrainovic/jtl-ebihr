using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPicklisteVorlageVorgangsTypen
{
    public int KPicklisteVorlage { get; set; }

    public int NVorgangsTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
