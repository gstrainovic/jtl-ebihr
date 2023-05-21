using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tinetbestellung
{
    public int KInetBestellung { get; set; }

    public int? KWarenkorb { get; set; }

    public int? KKunde { get; set; }

    public int? KLieferAdresse { get; set; }

    public int? KVersandart { get; set; }

    public string? CInetBestNr { get; set; }

    public string? CVersandInfo { get; set; }

    public string? DVersandDatum { get; set; }

    public string? CTracking { get; set; }

    public string? CKommentar { get; set; }

    public string? CAbgeholt { get; set; }

    public string? CStatus { get; set; }

    public DateTime? DTimestamp { get; set; }

    public int? KBestellHinweis { get; set; }

    public int KShop { get; set; }

    public int? KWaehrung { get; set; }

    public int? KSprache { get; set; }

    public decimal FGutschein { get; set; }

    public string? CModulId { get; set; }

    public int? NZahlungsTyp { get; set; }

    public int? NHatUpload { get; set; }

    public string? CPuizahlungsdaten { get; set; }

    public string? CKampagne { get; set; }

    public string? CKampagneParam { get; set; }

    public string? CKampagneName { get; set; }

    public string? CUserAgent { get; set; }

    public string? CReferrer { get; set; }

    public int? NMaxLiefertage { get; set; }

    public decimal? FFaktor { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CHinweis { get; set; }

    public int? NLongestMinDelivery { get; set; }

    public int? KRechnungsadresse { get; set; }
}
