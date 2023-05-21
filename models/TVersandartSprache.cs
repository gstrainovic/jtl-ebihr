using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVersandartSprache
{
    public int KVersandart { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public string? CDruckText { get; set; }

    public string? CAuftragsText { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
