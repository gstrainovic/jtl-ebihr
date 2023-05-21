using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvKundenDaten
{
    public int? KInetKunde { get; set; }

    public int? KKundenKategorie { get; set; }

    public string? CKundenNr { get; set; }

    public DateTime? DErstellt { get; set; }

    public decimal FRabatt { get; set; }

    public string? CNewsletter { get; set; }

    public string? CEbayName { get; set; }

    public int? KBuyer { get; set; }

    public string? CGeburtstag { get; set; }

    public string? CWww { get; set; }

    public string? CSperre { get; set; }

    public int? KKundenGruppe { get; set; }

    public int? NZahlungsziel { get; set; }

    public int? KSprache { get; set; }

    public string? CHerkunft { get; set; }

    public string? CKassenKunde { get; set; }

    public string? CHrnr { get; set; }

    public int? KZahlungsart { get; set; }

    public int? NDebitorennr { get; set; }

    public string? CSteuerNr { get; set; }

    public int? NKreditlimit { get; set; }

    public int? KKundenDrucktext { get; set; }

    public byte NMahnstopp { get; set; }

    public int NMahnrhythmus { get; set; }

    public byte KFirma { get; set; }

    public decimal? FProvision { get; set; }

    public byte NVertreter { get; set; }

    public decimal FSkonto { get; set; }

    public bool? NUstiderfolgreichGeprüft { get; set; }

    public DateTime? DDatumUstiderfolgreichGeprüft { get; set; }

    public int NSkontoInTagen { get; set; }

    public int KAdresse { get; set; }

    public int? KInetAdresse { get; set; }

    public int? KKunde { get; set; }

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

    public byte? NStandard { get; set; }

    public byte NTyp { get; set; }

    public string? CUstid { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
