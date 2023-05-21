using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRmretoure
{
    public int KRmretoure { get; set; }

    public int KRmstatus { get; set; }

    public int KKunde { get; set; }

    public int KBenutzer { get; set; }

    public string CRetoureNr { get; set; } = null!;

    public string? CAnsprechpartner { get; set; }

    public DateTime DErstellt { get; set; }

    public string? CKommentarExtern { get; set; }

    public int KRmretoureAbholAdresse { get; set; }

    public int? KWarenlager { get; set; }

    public int KFirma { get; set; }

    public byte NHerkunft { get; set; }

    public string? CKommentarIntern { get; set; }

    public decimal FKorrekturBetrag { get; set; }

    public byte NVersandkostenErstatten { get; set; }

    public string? CKorrekturBetragKommentar { get; set; }

    public int? KBestellungUmtausch { get; set; }

    public int? KGutschrift { get; set; }

    public int? KBestellung { get; set; }

    public string? CFfnReturnId { get; set; }

    public string? CExternalNumber { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NKuponGutschriftGutschreiben { get; set; }

    public virtual TReturnRef? TReturnRef { get; set; }
}
