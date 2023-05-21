using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TZahlungsabgleichLogeintrag
{
    public int KZahlungsabgleichLogeintrag { get; set; }

    public int KZahlungsabgleichLogsitzung { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public byte NSchweregrad { get; set; }

    public string CMeldung { get; set; } = null!;

    public int KZahlungsabgleichModul { get; set; }

    public string CKontoIdentifikation { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;

    public virtual TZahlungsabgleichLogsitzung KZahlungsabgleichLogsitzungNavigation { get; set; } = null!;
}
