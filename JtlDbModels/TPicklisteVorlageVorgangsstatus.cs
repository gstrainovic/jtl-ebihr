using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPicklisteVorlageVorgangsstatus
{
    public int KPicklisteVorlage { get; set; }

    public int KVorgangsstatus { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
