using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLieferantenBestellungLock
{
    public int KLieferantenBestellung { get; set; }

    public int KBenutzer { get; set; }

    public byte NSperreDurch { get; set; }

    public DateTime DZeitstempel { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
