using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TZahlungsabgleichModul
{
    public int KZahlungsabgleichModul { get; set; }

    public string CModulId { get; set; } = null!;

    public string CEinstellungen { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
