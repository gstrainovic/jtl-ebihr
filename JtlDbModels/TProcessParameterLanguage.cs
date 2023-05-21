using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProcessParameterLanguage
{
    public int KProcessParameter { get; set; }

    public int KSprache { get; set; }

    public string CDisplayName { get; set; } = null!;

    public string? CUnit { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProcessParameter KProcessParameterNavigation { get; set; } = null!;
}
