using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungZahlungsinfo
{
    public int KRechnung { get; set; }

    public string? CKontoInhaber { get; set; }

    public string? CBankname { get; set; }

    public string? CIban { get; set; }

    public string? CBic { get; set; }

    public string? CPuiZahlungsinfo { get; set; }

    public byte NTyp { get; set; }

    public DateTime? DFaelligkeitsdatum { get; set; }

    public string? CVerwendungszweck { get; set; }

    public string? CReferenzEmail { get; set; }

    public string? CMandatsReferenz { get; set; }

    public string? CEndToEndId { get; set; }

    public string? CGlaeubigerId { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TRechnung1 KRechnungNavigation { get; set; } = null!;
}
