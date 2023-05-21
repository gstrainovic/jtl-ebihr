using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSessionId
{
    public int KSessionId { get; set; }

    public string CRechnername { get; set; } = null!;

    public int KBenutzer { get; set; }

    public DateTime DLastAction { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TWorkJob> TWorkJobs { get; set; } = new List<TWorkJob>();
}
