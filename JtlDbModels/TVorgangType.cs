using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVorgangType
{
    public int KVorgangType { get; set; }

    public string CId { get; set; } = null!;

    public int KUserType { get; set; }

    public int KScopeType { get; set; }

    public string CWawiKeyType { get; set; } = null!;

    public string CFfnKeyType { get; set; } = null!;

    public virtual TScopeType KScopeTypeNavigation { get; set; } = null!;

    public virtual TUserType KUserTypeNavigation { get; set; } = null!;

    public virtual ICollection<TVorgang> TVorgangs { get; set; } = new List<TVorgang>();
}
