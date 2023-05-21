using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFirmaUstIdNr
{
    public int KFirmaUstIdNr { get; set; }

    public int KFirma { get; set; }

    public string CLandIso { get; set; } = null!;

    public string CUstId { get; set; } = null!;

    public byte NAuchAlsVersandlandBetrachten { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
