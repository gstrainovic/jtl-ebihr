using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TInkassoUser
{
    public int KInkassoUser { get; set; }

    public string? CUsername { get; set; }

    public string? CPasswort { get; set; }

    public int? KFirma { get; set; }

    public string? CAktiv { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
