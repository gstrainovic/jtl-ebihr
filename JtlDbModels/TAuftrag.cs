using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftrag
{
    public int KAuftrag { get; set; }

    public int KBenutzer { get; set; }

    public int? KKunde { get; set; }

    public string CAuftragsNr { get; set; } = null!;

    public byte NType { get; set; }

    public DateTime DErstellt { get; set; }

    public int? KShopauftrag { get; set; }

    public byte NBeschreibung { get; set; }

    public string? CInet { get; set; }

    public string? CWaehrung { get; set; }

    public decimal FFaktor { get; set; }

    public int? KShop { get; set; }

    public int KFirmaHistory { get; set; }

    public int? KPlattform { get; set; }

    public int KSprache { get; set; }

    public string? CExterneAuftragsnummer { get; set; }

    public int? NSteuereinstellung { get; set; }

    public string? CEbayUsername { get; set; }

    public string? CShopZahlungsmodul { get; set; }

    public bool NHatUpload { get; set; }

    public decimal FZusatzGewicht { get; set; }

    public string? CVersandlandIso { get; set; }

    public string? CVersandlandBundeslandKuerzel { get; set; }

    public string CVersandlandWaehrung { get; set; } = null!;

    public decimal FVersandlandWaehrungFaktor { get; set; }

    public int? KVersandArt { get; set; }

    public int? NZahlungszielTage { get; set; }

    public DateTime? DVoraussichtlichesLieferdatum { get; set; }

    public DateTime? DAuslieferdatum { get; set; }

    public decimal? FSkonto { get; set; }

    public int? NSkontoTage { get; set; }

    public int? KVorgangsstatus { get; set; }

    public bool NStorno { get; set; }

    public int NKomplettAusgeliefert { get; set; }

    public int NLieferPrioritaet { get; set; }

    public bool NPremiumVersand { get; set; }

    public int? KRueckhaltegrund { get; set; }

    public int? KZahlungsart { get; set; }

    public int? KWarenlager { get; set; }

    public byte NIstExterneRechnung { get; set; }

    public byte NIstReadOnly { get; set; }

    public int? NMaxLiefertage { get; set; }

    public string? COutboundId { get; set; }

    public int? KFulfillmentLieferant { get; set; }

    public string? CUstId { get; set; }

    public bool NArchiv { get; set; }

    public bool NReserviert { get; set; }

    public int? NDebitorennr { get; set; }

    public byte NAuftragStatus { get; set; }

    public string? CKundenAuftragsnummer { get; set; }

    public string? CAmazonServiceLevel { get; set; }

    public DateTime? DExternesErstelldatum { get; set; }

    public int? KFarbe { get; set; }

    public decimal FFinanzierungskosten { get; set; }

    public int? KAuftragQuelle { get; set; }

    public int? NAuftragQuelleAktion { get; set; }

    public int? KArtikelKarton { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CKundenNr { get; set; }

    public int? KKundengruppe { get; set; }

    public DateTime? DErstelltWawi { get; set; }

    public DateTime? DAuslieferungAb { get; set; }

    public int? KAmazonUser { get; set; }

    public string? CKundeUstId { get; set; }

    public bool NPending { get; set; }

    public virtual PfUser? KAmazonUserNavigation { get; set; }

    public virtual TFarbe? KFarbeNavigation { get; set; }

    public virtual TFirmaHistory KFirmaHistoryNavigation { get; set; } = null!;

    public virtual Tkunde? KKundeNavigation { get; set; }

    public virtual TPlattform? KPlattformNavigation { get; set; }

    public virtual TSpracheUsed KSpracheNavigation { get; set; } = null!;

    public virtual ICollection<PfAmazonUmlagerungVersendet> PfAmazonUmlagerungVersendets { get; set; } = new List<PfAmazonUmlagerungVersendet>();

    public virtual ICollection<TAuftragAdresse> TAuftragAdresses { get; set; } = new List<TAuftragAdresse>();

    public virtual ICollection<TAuftragAttribut> TAuftragAttributs { get; set; } = new List<TAuftragAttribut>();

    public virtual ICollection<TAuftragAusgabeDateien> TAuftragAusgabeDateiens { get; set; } = new List<TAuftragAusgabeDateien>();

    public virtual TAuftragEckdaten? TAuftragEckdaten { get; set; }

    public virtual ICollection<TAuftragFile> TAuftragFiles { get; set; } = new List<TAuftragFile>();

    public virtual TAuftragKampagne? TAuftragKampagne { get; set; }

    public virtual TAuftragLabel? TAuftragLabel { get; set; }

    public virtual ICollection<TAuftragPosition> TAuftragPositions { get; set; } = new List<TAuftragPosition>();

    public virtual TAuftragText? TAuftragText { get; set; }

    public virtual TAuftragZahlungsinfo? TAuftragZahlungsinfo { get; set; }

    public virtual ICollection<TOrder> TOrders { get; set; } = new List<TOrder>();

    public virtual ICollection<TOutboundRef> TOutboundRefs { get; set; } = new List<TOutboundRef>();

    public virtual ICollection<TVoucherEinloesungen> TVoucherEinloesungens { get; set; } = new List<TVoucherEinloesungen>();

    public virtual ICollection<TWorkProcessReplenishment> TWorkProcessReplenishments { get; set; } = new List<TWorkProcessReplenishment>();

    public virtual ICollection<TRechnung1> KRechnungs { get; set; } = new List<TRechnung1>();
}
