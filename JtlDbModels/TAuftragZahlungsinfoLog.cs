using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragZahlungsinfoLog
{
    public int KAuftragZahlungsinfoLog { get; set; }

    public int? KBenutzerLog { get; set; }

    public DateTime DLog { get; set; }

    public int NActionLog { get; set; }

    public int KAuftrag { get; set; }

    public string? CKontoInhaber { get; set; }

    public string? CBankname { get; set; }

    public string? CIban { get; set; }

    public string? CBic { get; set; }

    public string? CPuiZahlungsinfo { get; set; }

    public byte NTyp { get; set; }

    public string? CMandatsReferenz { get; set; }

    public string? CVerwendungszweck { get; set; }

    public DateTime? DFaelligkeitsdatum { get; set; }

    public string? CGlaeubigerId { get; set; }

    public string? CEndToEndId { get; set; }

    public string? CReferenzEmail { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
