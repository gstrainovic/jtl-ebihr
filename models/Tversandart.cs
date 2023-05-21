using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tversandart
{
    public int KVersandArt { get; set; }

    public string? CName { get; set; }

    public decimal FPrice { get; set; }

    public string? CAktiv { get; set; }

    public string? CInet { get; set; }

    public string? CZahlungsInfo { get; set; }

    public decimal FMwSt { get; set; }

    public string? CDruckText { get; set; }

    public decimal FVkfreiAb { get; set; }

    public string? CAuftragsText { get; set; }

    public decimal FZusatzGewicht { get; set; }

    public byte? NEigeneVersandart { get; set; }

    public int? KMainVersandart { get; set; }

    public byte? NVerwiegePflicht { get; set; }

    public byte? NTrackingIdeingabePflicht { get; set; }

    public byte NExpress { get; set; }

    public string? CTrackingIdregex { get; set; }

    public byte NTrackingIdvon { get; set; }

    public byte NTrackingIdbis { get; set; }

    public int NPrioritaet { get; set; }

    public byte? NEtikettenDrucken { get; set; }

    public byte? NEtikettenStartRueckfrage { get; set; }

    public int? KEtikettenFormular { get; set; }

    public byte NVersandMailSenden { get; set; }

    public byte NVersandSchnittstelle { get; set; }

    public string? CTrackingUrlTemplate { get; set; }

    public string? CAmazonCarrierCode { get; set; }

    public string? CEbayCarrierCode { get; set; }

    public int? KVersanddatenImportVorlage { get; set; }

    public int KVersanddatenExportVorlage { get; set; }

    public byte? KShippingServiceProviderType { get; set; }

    public byte NAmazonPrime { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KSteuerklasse { get; set; }

    public decimal FEkpreis { get; set; }

    public string? CMarktplatzLieferservice { get; set; }

    public virtual ICollection<PfAmazonMappingVersandartVersanddienstleister> PfAmazonMappingVersandartVersanddienstleisters { get; set; } = new List<PfAmazonMappingVersandartVersanddienstleister>();

    public virtual ICollection<TRechnung1> TRechnung1s { get; set; } = new List<TRechnung1>();

    public virtual ICollection<TSfpversand> TSfpversands { get; set; } = new List<TSfpversand>();

    public virtual ICollection<TShippingMethodMapping> TShippingMethodMappings { get; set; } = new List<TShippingMethodMapping>();

    public virtual TTrackAndTraceConfiguration? TTrackAndTraceConfiguration { get; set; }

    public virtual TTrackAndTraceDpdConfiguration? TTrackAndTraceDpdConfiguration { get; set; }
}
