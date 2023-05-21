using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAmazonAngebote
{
    public string? KAmazonAngebot { get; set; }

    public string? CItemname { get; set; }

    public string? CAsin1 { get; set; }

    public DateTime? DOpendate { get; set; }

    public string CSellerSku { get; set; } = null!;

    public decimal FPrice { get; set; }

    public string? CFulfillmentChannel { get; set; }

    public int NPlattform { get; set; }

    public int KUser { get; set; }

    public byte? NChangedQuantity { get; set; }

    public byte? NChangedPrice { get; set; }

    public int? NDefaultFulfillmentChannelQuantity { get; set; }

    public byte? NCondition { get; set; }

    public decimal? FAbstandPrice { get; set; }

    public int NSwitchFulfillmentTo { get; set; }

    public DateTime? DLastSwitchFulfillmentTo { get; set; }

    public string CFulfilledNetwork { get; set; } = null!;

    public byte? NIstVater { get; set; }

    public int NLagerAktiv { get; set; }

    public int NLagerKleinerNull { get; set; }

    public decimal? FLagerbestand { get; set; }

    public string? CArtikelName { get; set; }

    public string? CEinheit { get; set; }

    public string? CBarcode { get; set; }

    public decimal? FGewicht { get; set; }

    public string? CHan { get; set; }

    public string? CIsbn { get; set; }

    public string? CUpc { get; set; }

    public decimal? FReserviert { get; set; }

    public decimal? FVkNetto { get; set; }

    public decimal? FEbayPreis { get; set; }

    public string? CHersteller { get; set; }

    public decimal? FEkNetto { get; set; }

    public string? CArtNr { get; set; }

    public decimal? FAmazonVk { get; set; }

    public decimal? FVerfuegbar { get; set; }

    public decimal? FVerfuegbarExtern { get; set; }

    public decimal? FVerfuegbarExternOhneFba { get; set; }

    public int? KArtikel { get; set; }

    public string? CConditiontype { get; set; }

    public string? CWarehouseConditiontype { get; set; }

    public decimal? FVersandkosten { get; set; }

    public int? NBearbeitungszeit { get; set; }

    public DateTime? DRestockdate { get; set; }

    public DateTime? DSaleStart { get; set; }

    public DateTime? DSaleEnd { get; set; }

    public decimal? FSalePrice { get; set; }

    public decimal? FApaminPreis { get; set; }

    public decimal? FApamaxPreis { get; set; }

    public decimal? FApaPreisabstand { get; set; }

    public int? NRepricerStrategie { get; set; }

    public byte? NApaNutzen { get; set; }

    public byte? NIstApaPreisabstandProzentual { get; set; }

    public decimal? FApaMinPreisAufschlagProzent { get; set; }

    public decimal? FApaMaxPreisAufschlagProzent { get; set; }

    public byte? NApaMargensteigerungAktiv { get; set; }

    public int? NApaMargensteigerungBestandAb { get; set; }

    public decimal? FApaMargensteigerungAenderungMinPreis { get; set; }

    public decimal? FApaMargensteigerungAenderungMaxPreis { get; set; }

    public byte? FApaMargensteigerungAenderungMinPreisTyp { get; set; }

    public byte? FApaMargensteigerungAenderungMaxPreisTyp { get; set; }

    public byte? NApaAbverkaufAktiv { get; set; }

    public int? NApaAbverkaufBestandBis { get; set; }

    public decimal? FApaAbverkaufAenderungMinPreis { get; set; }

    public decimal? FApaAbverkaufAenderungMaxPreis { get; set; }

    public byte? FApaAbverkaufAenderungMinPreisTyp { get; set; }

    public byte? FApaAbverkaufAenderungMaxPreisTyp { get; set; }

    public string? CApaVorlageName { get; set; }

    public decimal? FPreisseller1 { get; set; }

    public decimal? FVersandseller1 { get; set; }

    public DateTime? DSellerdaten { get; set; }

    public string? CConditionnote { get; set; }

    public bool? NB2bpreiseSenden { get; set; }

    public string? CFnsku { get; set; }

    public decimal? FVolume { get; set; }

    public int? NFfbaQuantity { get; set; }

    public int? NQuantityWarehouse { get; set; }

    public int? NQuantityUnsellable { get; set; }

    public int? NQuantityReserved { get; set; }

    public int? NQuantityInboundWorking { get; set; }

    public int? NQuantityInboundShipped { get; set; }

    public int? NQuantityReceiving { get; set; }

    public int? NQuantityTotal { get; set; }

    public decimal? FPreis { get; set; }

    public byte? NDelete { get; set; }

    public int? KSteuercode { get; set; }

    public string? CSteuercodeName { get; set; }

    public int NHasPrice { get; set; }

    public int? NQuantity { get; set; }

    public int? NMaxBestand { get; set; }

    public string? CWaehrung { get; set; }

    public decimal? FFactor { get; set; }

    public string? CPlattformname { get; set; }

    public string? CPfUsername { get; set; }

    public int? NLagerSenden { get; set; }

    public byte NBearbeitungszeitAnpassen { get; set; }

    public string? CVersandgruppe { get; set; }

    public int? NAngebotFehlerAnzahl { get; set; }

    public byte? NApaPreisabstandKalkulation { get; set; }

    public string? CApaPreisabstandMinFormel { get; set; }

    public string? CApaPreisabstandMaxFormel { get; set; }

    public bool? NPreisUndBestandsaenderungenAusschliessen { get; set; }
}
