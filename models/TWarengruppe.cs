using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWarengruppe
{
    public int KWarengruppe { get; set; }

    public string? CName { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TAttributWarengruppe> TAttributWarengruppes { get; set; } = new List<TAttributWarengruppe>();
}
