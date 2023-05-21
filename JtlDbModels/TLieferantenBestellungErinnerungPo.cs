using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLieferantenBestellungErinnerungPo
{
    public int KLieferantenBestellungErinnerung { get; set; }

    public int KLieferantenBestellung { get; set; }

    public int KLieferantenBestellungPos { get; set; }

    public decimal FAnzahl { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
