using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TEbayAbgleichLogsitzung
{
    public int KEbayAbgleichLogsitzung { get; set; }

    public int NTyp { get; set; }

    public int KBenutzer { get; set; }

    public string CRechnername { get; set; } = null!;

    public DateTime DStart { get; set; }

    public DateTime? DEnde { get; set; }

    public byte? NStatus { get; set; }

    public string? CStatusMeldung { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TEbayAbgleichLogeintrag> TEbayAbgleichLogeintrags { get; set; } = new List<TEbayAbgleichLogeintrag>();
}
