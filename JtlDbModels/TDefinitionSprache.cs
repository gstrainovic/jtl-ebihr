using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TDefinitionSprache
{
    public int KDefinition { get; set; }

    public int KSprache { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TDefinition KDefinitionNavigation { get; set; } = null!;
}
