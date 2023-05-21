using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvZahlungsabgleichLogeintrag
{
    public int KZahlungsabgleichLogeintrag { get; set; }

    public int KZahlungsabgleichLogsitzung { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public byte NSchweregrad { get; set; }

    public string CMeldung { get; set; } = null!;

    public int KZahlungsabgleichModul { get; set; }

    public string CKontoIdentifikation { get; set; } = null!;
}
