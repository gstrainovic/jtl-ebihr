using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTextbausteinGruppe
{
    public int KTextbausteinGruppe { get; set; }

    public string CName { get; set; } = null!;

    public virtual ICollection<TTextbaustein> TTextbausteins { get; set; } = new List<TTextbaustein>();
}
