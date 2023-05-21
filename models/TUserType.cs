using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TUserType
{
    public int KUserType { get; set; }

    public string CId { get; set; } = null!;

    public virtual ICollection<TVorgangType> TVorgangTypes { get; set; } = new List<TVorgangType>();
}
