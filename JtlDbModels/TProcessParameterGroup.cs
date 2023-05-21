using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TProcessParameterGroup
{
    public int KProcessParameterGroup { get; set; }

    public Guid IAssignmentObjectType { get; set; }

    public string? CInternalDescription { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TProcessParameter1> TProcessParameter1s { get; set; } = new List<TProcessParameter1>();

    public virtual ICollection<TProcessParameterGroupLanguage> TProcessParameterGroupLanguages { get; set; } = new List<TProcessParameterGroupLanguage>();
}
