using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TUmsatzSteuerPruefung
{
    public int KKunde { get; set; }

    public string CUstid { get; set; } = null!;

    public DateTime? DErfolgreichGerpueft { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CPruefdaten { get; set; }
}
