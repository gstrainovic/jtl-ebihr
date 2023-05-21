using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TCondition
{
    public int KCondition { get; set; }

    public string CCondition { get; set; } = null!;

    public virtual ICollection<TZustand> TZustands { get; set; } = new List<TZustand>();
}
