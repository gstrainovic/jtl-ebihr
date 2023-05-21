using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TScopeType
{
    public int KScopeType { get; set; }

    public string CId { get; set; } = null!;

    public virtual ICollection<TVorgangType> TVorgangTypes { get; set; } = new List<TVorgangType>();
}
