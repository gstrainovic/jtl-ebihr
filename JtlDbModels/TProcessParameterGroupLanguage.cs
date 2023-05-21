using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProcessParameterGroupLanguage
{
    public int KProcessParameterGroup { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProcessParameterGroup KProcessParameterGroupNavigation { get; set; } = null!;
}
