using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VAuftragAusgabeDateien
{
    public int KAuftrag { get; set; }

    public DateTime DAusgabeDatum { get; set; }

    public int NAusgabeArt { get; set; }

    public string? CErrorCode { get; set; }

    public int KBenutzer { get; set; }

    public int? KVorlage { get; set; }
}
