using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonAngebotExt
{
    public string CSellerSku { get; set; } = null!;

    public int KUser { get; set; }

    public decimal? FPreis { get; set; }

    public int? NMaxBestand { get; set; }

    public decimal? FVersandkosten { get; set; }

    public byte? NDelete { get; set; }

    public decimal? FApaminPreis { get; set; }

    public decimal? FApamaxPreis { get; set; }

    public decimal? FApapreisabstand { get; set; }

    public byte? NIstApapreisabstandProzentual { get; set; }

    public byte? NApaupdate { get; set; }

    public DateTime? DLetztePreisAenderung { get; set; }

    public DateTime? DLetzteBestandAenderung { get; set; }

    public DateTime? DLetzteVersandAenderung { get; set; }

    public DateTime? DLetztesApaupdate { get; set; }

    public DateTime? DRestockDate { get; set; }

    public int? NBearbeitungsZeit { get; set; }

    public string? CFulfillmentChannel { get; set; }

    public DateTime? DSaleStart { get; set; }

    public DateTime? DSaleEnd { get; set; }

    public decimal? FSalePrice { get; set; }

    public byte? NApanutzen { get; set; }

    public string? CNameSeller1 { get; set; }

    public decimal? FPreisSeller1 { get; set; }

    public decimal? FVersandSeller1 { get; set; }

    public byte? NVerkaufsrang { get; set; }

    public DateTime? DSellerdaten { get; set; }

    public int NPlattform { get; set; }

    public string? CConditionNote { get; set; }

    public byte? NConditionNoteChanged { get; set; }

    public int? NApapruefIntervall { get; set; }

    public int? NApashippingTime { get; set; }

    public int? NApasellerPositiveFeedbackRating { get; set; }

    public decimal? FApapreisabstandFba { get; set; }

    public byte? NIstApapreisabstandFbaprozentual { get; set; }

    public byte? NUseApaglobal { get; set; }

    public DateTime? DLetzteBearbeitungszeitAenderung { get; set; }

    public int? KSteuercode { get; set; }

    public DateTime? DLetzteTaxShippingAenderung { get; set; }

    public bool NB2bpreiseSenden { get; set; }

    public int NSwitchFulfillmentTo { get; set; }

    public DateTime? DLastSwitchFulfillmentTo { get; set; }

    public int NLetzteBearbeitungsZeit { get; set; }

    public int KAmazonVersandgruppe { get; set; }

    public int NDeleteB2bpreis { get; set; }

    public byte NSendeBestand { get; set; }

    public bool NPreisUndBestandsaenderungenAusschliessen { get; set; }

    public DateTime? DDeaktiviertUtc { get; set; }
}
