using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAuftragPosition
{
    public int KAuftragPosition { get; set; }

    public int? KArtikel { get; set; }

    public int KAuftrag { get; set; }

    public string? CArtNr { get; set; }

    public bool NReserviert { get; set; }

    public string? CName { get; set; }

    public string? CHinweis { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FEkNetto { get; set; }

    public decimal FVkNetto { get; set; }

    public decimal FRabatt { get; set; }

    public decimal FMwSt { get; set; }

    public int NSort { get; set; }

    public string? CNameStandard { get; set; }

    public int? KSteuerklasse { get; set; }

    public byte NType { get; set; }

    public string? CEinheit { get; set; }

    public bool NHatUpload { get; set; }

    public int? KKonfigVater { get; set; }

    public int? KKonfigItem { get; set; }

    public int? KAmazonBestellungPos { get; set; }

    public int? KAuftragStueckliste { get; set; }

    public int? KEbayTransaction { get; set; }

    public decimal FFaktor { get; set; }

    public int? KSteuerschluessel { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public decimal? FWertNettoGesamtFixiert { get; set; }

    public decimal? FWertBruttoGesamtFixiert { get; set; }

    public string? CFnsku { get; set; }

    public virtual PfAmazonBestellungpo? KAmazonBestellungPosNavigation { get; set; }

    public virtual TAuftrag KAuftragNavigation { get; set; } = null!;

    public virtual EbayTransaction? KEbayTransactionNavigation { get; set; }

    public virtual Tkonfigitem? KKonfigItemNavigation { get; set; }

    public virtual TSteuerklasse? KSteuerklasseNavigation { get; set; }

    public virtual TSteuerschluessel? KSteuerschluesselNavigation { get; set; }

    public virtual TAuftragPositionEckdaten? TAuftragPositionEckdaten { get; set; }

    public virtual ICollection<TAuftragPositionEigenschaft> TAuftragPositionEigenschafts { get; set; } = new List<TAuftragPositionEigenschaft>();

    public virtual ICollection<TAuftragPositionFile> TAuftragPositionFiles { get; set; } = new List<TAuftragPositionFile>();

    public virtual TAuftragPositionIntervall? TAuftragPositionIntervall { get; set; }

    public virtual TAuftragPositionTeilmengen? TAuftragPositionTeilmengen { get; set; }

    public virtual ICollection<TAuftragPositionTeilmengenKonfiguration> TAuftragPositionTeilmengenKonfigurations { get; set; } = new List<TAuftragPositionTeilmengenKonfiguration>();

    public virtual ICollection<TAuftragkosten> TAuftragkostens { get; set; } = new List<TAuftragkosten>();

    public virtual ICollection<TExternerBelegPosition> TExternerBelegPositions { get; set; } = new List<TExternerBelegPosition>();

    public virtual ICollection<TOrderItem> TOrderItems { get; set; } = new List<TOrderItem>();

    public virtual ICollection<TOutboundItemRef> TOutboundItemRefs { get; set; } = new List<TOutboundItemRef>();

    public virtual ICollection<TRechnungPosition> TRechnungPositions { get; set; } = new List<TRechnungPosition>();

    public virtual ICollection<TVoucherEinloesungen> TVoucherEinloesungens { get; set; } = new List<TVoucherEinloesungen>();
}
