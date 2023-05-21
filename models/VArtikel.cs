using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VArtikel
{
    public int KArtikel { get; set; }

    public int KHersteller { get; set; }

    public int KLieferstatus { get; set; }

    public string? CEinheit { get; set; }

    public int KEinheit { get; set; }

    public int KSteuerklasse { get; set; }

    public int KVpeeinheit { get; set; }

    public int? KVersandklasse { get; set; }

    public string CArtNr { get; set; } = null!;

    public string? CName { get; set; }

    public string? CSeo { get; set; }

    public string? CBeschreibung { get; set; }

    public string? CAnmerkung { get; set; }

    public decimal? FLagerbestand { get; set; }

    public decimal? FMwSt { get; set; }

    public decimal FStandardpreisNetto { get; set; }

    public decimal FMindestbestellmenge { get; set; }

    public string? CBarcode { get; set; }

    public string? CTopArtikel { get; set; }

    public decimal FGewicht { get; set; }

    public decimal FArtikelgewicht { get; set; }

    public string CNeu { get; set; } = null!;

    public string? CKurzBeschreibung { get; set; }

    public decimal FUvp { get; set; }

    public string CLagerKleinerNull { get; set; } = null!;

    public string CLagerVariation { get; set; } = null!;

    public string CLagerBeachten { get; set; } = null!;

    public string? CTeilbar { get; set; }

    public decimal FPackeinheit { get; set; }

    public string CVpe { get; set; } = null!;

    public decimal FVpewert { get; set; }

    public string? CVpeeinheit { get; set; }

    public string? CSuchbegriffe { get; set; }

    public int? NSort { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? DErscheinungsdatum { get; set; }

    public string? CHan { get; set; }

    public string? CSerie { get; set; }

    public string? CIsbn { get; set; }

    public string? CAsin { get; set; }

    public string? CUnnummer { get; set; }

    public string? CGefahrnr { get; set; }

    public string? CTaric { get; set; }

    public byte NIstVater { get; set; }

    public int KEigenschaftKombi { get; set; }

    public int KVaterArtikel { get; set; }

    public decimal FAbnahmeintervall { get; set; }

    public int KStueckliste { get; set; }

    public string? CUpc { get; set; }

    public string? CHerkunftsland { get; set; }

    public string? CEpid { get; set; }

    public int KWarengruppe { get; set; }

    public DateTime? DMhd { get; set; }

    public int KMassEinheit { get; set; }

    public decimal FMassMenge { get; set; }

    public int KGrundPreisEinheit { get; set; }

    public decimal FGrundpreisMenge { get; set; }

    public decimal FBreite { get; set; }

    public decimal FHoehe { get; set; }

    public decimal FLaenge { get; set; }

    public int NLiefertageWennAusverkauft { get; set; }

    public int KVerkaufsEinheit { get; set; }

    public DateTime? DZulaufVerfuegbarAm { get; set; }

    public byte NAutomatischeLiefertageberechnung { get; set; }

    public int NBearbeitungszeit { get; set; }

    public string CAktiv { get; set; } = null!;

    public string CInet { get; set; } = null!;

    public string? CDelInet { get; set; }

    public byte? NPufferTyp { get; set; }

    public int NPuffer { get; set; }

    public decimal? FVerfuegbar { get; set; }

    public int KShop { get; set; }

    public decimal NZulaufVerfuegbarMenge { get; set; }

    public int KLiefArtikel { get; set; }

    public decimal FLiefArtikelLagerbestand { get; set; }

    public int NLieferzeit { get; set; }

    public byte NNichtRabattfaehig { get; set; }

    public int NGoogleCondition { get; set; }
}
