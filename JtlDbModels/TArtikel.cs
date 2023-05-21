using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikel
{
    public int KArtikel { get; set; }

    public string CArtNr { get; set; } = null!;

    public decimal FVknetto { get; set; }

    public decimal FUvp { get; set; }

    public string? CAnmerkung { get; set; }

    public string CPreisliste { get; set; } = null!;

    public string CAktiv { get; set; } = null!;

    public decimal NLagerbestand { get; set; }

    public decimal NMindestbestellmaenge { get; set; }

    public string? CBarcode { get; set; }

    public string? CTopArtikel { get; set; }

    public string CInet { get; set; } = null!;

    public string? CDelInet { get; set; }

    public decimal FGewicht { get; set; }

    public string CNeu { get; set; } = null!;

    public string? CLagerArtikel { get; set; }

    public string? CTeilbar { get; set; }

    public string CLagerAktiv { get; set; } = null!;

    public string CLagerKleinerNull { get; set; } = null!;

    public decimal NMidestbestand { get; set; }

    public decimal FEknetto { get; set; }

    public decimal FEbayPreis { get; set; }

    public string CLagerVariation { get; set; } = null!;

    public byte? NDelete { get; set; }

    public DateTime? DMod { get; set; }

    public decimal FPackeinheit { get; set; }

    public byte? NVpe { get; set; }

    public decimal FVpewert { get; set; }

    public string? CSuchbegriffe { get; set; }

    public string? CTaric { get; set; }

    public string? CHerkunftsland { get; set; }

    public int KSteuerklasse { get; set; }

    public DateTime? DErstelldatum { get; set; }

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

    public int? KHersteller { get; set; }

    public int? KLieferStatus { get; set; }

    public int? KMassEinheit { get; set; }

    public decimal FMassMenge { get; set; }

    public int? KGrundPreisEinheit { get; set; }

    public decimal FGrundpreisMenge { get; set; }

    public decimal FBreite { get; set; }

    public decimal FHoehe { get; set; }

    public decimal FLaenge { get; set; }

    public int? KVpeeinheit { get; set; }

    public int? NLiefertageWennAusverkauft { get; set; }

    public int? KVerkaufsEinheit { get; set; }

    public DateTime? DZulaufVerfuegbarAm { get; set; }

    public byte? NAutomatischeLiefertageberechnung { get; set; }

    public int? NBearbeitungszeit { get; set; }

    public decimal FLetzterEk { get; set; }

    public DateTime? DLetzterEk { get; set; }

    public int? KBenutzerLetzteAenderung { get; set; }

    public decimal NZulaufVerfuegbarMenge { get; set; }

    public DateTime? DNeuImSortiment { get; set; }

    public byte NEbayAbgleich { get; set; }

    public int KZustand { get; set; }

    public string? CAmazonFnsku { get; set; }

    public string? CJfsku { get; set; }

    public byte NSonderTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NNichtRabattfaehig { get; set; }

    public string? CLabelNamen { get; set; }

    public int? KDefinition { get; set; }

    public byte NIstTeilmengenArtikel { get; set; }

    public virtual ICollection<TArtikelAsin> TArtikelAsins { get; set; } = new List<TArtikelAsin>();

    public virtual ICollection<TArtikelDimension> TArtikelDimensions { get; set; } = new List<TArtikelDimension>();

    public virtual ICollection<TArtikelEpid> TArtikelEpids { get; set; } = new List<TArtikelEpid>();

    public virtual ICollection<TArtikelLabel> TArtikelLabels { get; set; } = new List<TArtikelLabel>();

    public virtual TArtikelMehrzweckGutschein? TArtikelMehrzweckGutschein { get; set; }

    public virtual ICollection<TArtikelMindestLagerbestandProLager> TArtikelMindestLagerbestandProLagers { get; set; } = new List<TArtikelMindestLagerbestandProLager>();

    public virtual ICollection<TArtikelStateNotification> TArtikelStateNotifications { get; set; } = new List<TArtikelStateNotification>();

    public virtual TArtikelTeilmengen? TArtikelTeilmengen { get; set; }

    public virtual ICollection<TArtikelType> TArtikelTypes { get; set; } = new List<TArtikelType>();

    public virtual ICollection<TArtikelVerkaufskanalFeldWert> TArtikelVerkaufskanalFeldWerts { get; set; } = new List<TArtikelVerkaufskanalFeldWert>();

    public virtual TArtikelkosten? TArtikelkosten { get; set; }

    public virtual ICollection<TBillOfMaterialComponent> TBillOfMaterialComponents { get; set; } = new List<TBillOfMaterialComponent>();

    public virtual ICollection<TExterneReservierung> TExterneReservierungs { get; set; } = new List<TExterneReservierung>();

    public virtual ICollection<TExternerBelegPosition> TExternerBelegPositions { get; set; } = new List<TExternerBelegPosition>();

    public virtual ICollection<TNachrichtArtikel> TNachrichtArtikels { get; set; } = new List<TNachrichtArtikel>();

    public virtual ICollection<TPlattformUeberverkaeufeMoeglich> TPlattformUeberverkaeufeMoegliches { get; set; } = new List<TPlattformUeberverkaeufeMoeglich>();

    public virtual ICollection<TPrei> TPreis { get; set; } = new List<TPrei>();

    public virtual TProdItem? TProdItem { get; set; }

    public virtual ICollection<TProductRef> TProductRefs { get; set; } = new List<TProductRef>();

    public virtual ICollection<TShopUeberverkaeufeMoeglich> TShopUeberverkaeufeMoegliches { get; set; } = new List<TShopUeberverkaeufeMoeglich>();

    public virtual ICollection<TStockRef> TStockRefs { get; set; } = new List<TStockRef>();

    public virtual ICollection<TVerkaufskanalArtikelDatum> TVerkaufskanalArtikelData { get; set; } = new List<TVerkaufskanalArtikelDatum>();

    public virtual ICollection<TVoucher> TVouchers { get; set; } = new List<TVoucher>();

    public virtual ICollection<Tartikelkonfiggruppe> Tartikelkonfiggruppes { get; set; } = new List<Tartikelkonfiggruppe>();

    public virtual ICollection<Tliefartikel> Tliefartikels { get; set; } = new List<Tliefartikel>();
}
