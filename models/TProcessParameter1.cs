using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TProcessParameter1
{
    public int KProcessParameter { get; set; }

    public int KProcessParameterGroup { get; set; }

    public string CId { get; set; } = null!;

    public int NValueType { get; set; }

    public string? CInternalDescription { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TProcessParameterGroup KProcessParameterGroupNavigation { get; set; } = null!;

    public virtual ICollection<TProcessParameterActualValueObjectType> TProcessParameterActualValueObjectTypes { get; set; } = new List<TProcessParameterActualValueObjectType>();

    public virtual ICollection<TProcessParameterAssignment1> TProcessParameterAssignment1s { get; set; } = new List<TProcessParameterAssignment1>();

    public virtual ICollection<TProcessParameterLanguage1> TProcessParameterLanguage1s { get; set; } = new List<TProcessParameterLanguage1>();

    public virtual ICollection<TProcessParameterTargetValueObjectType> TProcessParameterTargetValueObjectTypes { get; set; } = new List<TProcessParameterTargetValueObjectType>();
}
