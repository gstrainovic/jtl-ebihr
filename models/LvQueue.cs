using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvQueue
{
    public int KQueue { get; set; }

    public string? CFehler { get; set; }

    public string CJson { get; set; } = null!;

    public byte NCount { get; set; }

    public int NFailedStep { get; set; }

    public int KAuftrag { get; set; }

    public string CAuftragsNr { get; set; } = null!;

    public string? CExterneAuftragsnummer { get; set; }

    public int KShop { get; set; }

    public string? CFiliale { get; set; }

    public string? CKasse { get; set; }

    public bool NInBearbeitung { get; set; }

    public int KShopSubshop { get; set; }
}
