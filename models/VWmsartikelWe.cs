using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VWmsartikelWe
{
    public int KArtikel { get; set; }

    public string CArtNr { get; set; } = null!;

    public string? CName { get; set; }

    public string? CBeschreibung { get; set; }

    public decimal? FVkbrutto { get; set; }

    public decimal FVknetto { get; set; }

    public decimal FUvp { get; set; }

    public string? CAnmerkung { get; set; }

    public string CPreisliste { get; set; } = null!;

    public string CAktiv { get; set; } = null!;

    public decimal NLagerbestand { get; set; }

    public decimal? FMwSt { get; set; }

    public string? CEinheit { get; set; }

    public decimal NMindestbestellmaenge { get; set; }

    public string? CBarcode { get; set; }

    public string CErloeskonto { get; set; } = null!;

    public int FVkhaendlerBrutto { get; set; }

    public int FVkhaendlerNetto { get; set; }

    public string? CTopArtikel { get; set; }

    public string CInet { get; set; } = null!;

    public string? CDelInet { get; set; }

    public decimal FGewicht { get; set; }

    public string CNeu { get; set; } = null!;

    public string? CKurzBeschreibung { get; set; }

    public string? CLagerArtikel { get; set; }

    public string? CTeilbar { get; set; }

    public string CLagerAktiv { get; set; } = null!;

    public string CLagerKleinerNull { get; set; } = null!;

    public decimal NMidestbestand { get; set; }

    public decimal FEknetto { get; set; }

    public string? CHersteller { get; set; }

    public decimal FEbayPreis { get; set; }

    public string CLagerVariation { get; set; } = null!;

    public byte? NDelete { get; set; }

    public DateTime? DMod { get; set; }

    public decimal FPackeinheit { get; set; }

    public byte? NVpe { get; set; }

    public decimal FVpewert { get; set; }

    public string? CVpeeinheit { get; set; }

    public string? CLieferstatus { get; set; }

    public string? CSuchbegriffe { get; set; }

    public string? CTaric { get; set; }

    public string? CHerkunftsland { get; set; }

    public int KSteuerklasse { get; set; }

    public DateTime? DErstelldatum { get; set; }

    public string? CSeo { get; set; }

    public DateTime? DErscheinungsdatum { get; set; }

    public int? NSort { get; set; }

    public int? KVersandklasse { get; set; }

    public decimal FArtGewicht { get; set; }

    public string? CHan { get; set; }

    public string? CSerie { get; set; }

    public string? CIsbn { get; set; }

    public string? CUnnummer { get; set; }

    public string? CGefahrnr { get; set; }

    public string? CAsin { get; set; }

    public int KEigenschaftKombi { get; set; }

    public int KVaterArtikel { get; set; }

    public byte NIstVater { get; set; }

    public byte? NIstMindestbestand { get; set; }

    public decimal FAbnahmeintervall { get; set; }

    public int KStueckliste { get; set; }

    public string? CUpc { get; set; }

    public int KWarengruppe { get; set; }

    public string? CEpid { get; set; }

    public byte NMhd { get; set; }

    public byte NCharge { get; set; }

    public byte NNichtBestellbar { get; set; }

    public decimal FAmazonVk { get; set; }

    public byte? NPufferTyp { get; set; }

    public int NPuffer { get; set; }

    public byte NProzentualePreisStaffelAktiv { get; set; }

    public byte NSeriennummernVerfolgung { get; set; }

    public decimal FLetzterEk { get; set; }

    public DateTime? DletzterEk { get; set; }

    public int KZustand { get; set; }

    public byte NIstTeilmengenArtikel { get; set; }

    public decimal FLaenge { get; set; }

    public decimal FBreite { get; set; }

    public decimal FHoehe { get; set; }

    public int NIsGutschein { get; set; }
}
