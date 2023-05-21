using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvRetoureBearbeiten
{
    public int KRmretoure { get; set; }

    public int KRmstatus { get; set; }

    public int KFirma { get; set; }

    public int KKunde { get; set; }

    public int? KWarenlager { get; set; }

    public decimal FKorrekturBetrag { get; set; }

    public int? KGutschrift { get; set; }

    public byte NHerkunft { get; set; }

    public string? CKorrekturBetragKommentar { get; set; }

    public int? KBestellung { get; set; }

    public int? KBestellungUmtausch { get; set; }

    public string CRetoureNr { get; set; } = null!;

    public string? CAnsprechpartner { get; set; }

    public DateTime DErstellt { get; set; }

    public string? CKommentarExtern { get; set; }

    public string? CKommentarIntern { get; set; }

    public string? CFfnReturnId { get; set; }

    public string? CExternalNumber { get; set; }

    public byte NVersandkostenErstatten { get; set; }

    public int KRmretoureAbholAdresse { get; set; }

    public string? CFirma { get; set; }

    public string? CAnrede { get; set; }

    public string? CTitel { get; set; }

    public string? CVorname { get; set; }

    public string? CName { get; set; }

    public string? CStrasse { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CLand { get; set; }

    public string? CTel { get; set; }

    public string? CZusatz { get; set; }

    public string? CAdressZusatz { get; set; }

    public string? CPostId { get; set; }

    public string? CMobil { get; set; }

    public string? CMail { get; set; }

    public string? CFax { get; set; }

    public string? CBundesland { get; set; }

    public string? CIso { get; set; }

    public string? CKundenNr { get; set; }

    public byte NFulfillment { get; set; }

    public bool? NJtlFulfillment { get; set; }

    public byte NKuponGutschriftGutschreiben { get; set; }
}
