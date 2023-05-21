using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TRechnungAusgabeDateien
{
    public int KRechnung { get; set; }

    public DateTime DAusgabedatum { get; set; }

    public int NAusgabeart { get; set; }

    public string? CFehlermeldung { get; set; }

    public int KBenutzer { get; set; }

    public int? KVorlage { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int KRechnungAusgabeDateien { get; set; }

    public virtual TRechnung1 KRechnungNavigation { get; set; } = null!;
}
