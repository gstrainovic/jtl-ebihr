using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragAusgabeDateien
{
    public int KAuftrag { get; set; }

    public DateTime DAusgabeDatum { get; set; }

    public int NAusgabeArt { get; set; }

    public string? CErrorCode { get; set; }

    public int KBenutzer { get; set; }

    public int? KVorlage { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int KAuftragAusgabeDateien { get; set; }

    public virtual TAuftrag KAuftragNavigation { get; set; } = null!;
}
