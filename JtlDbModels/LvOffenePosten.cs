using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvOffenePosten
{
    public byte NMahnstopp { get; set; }

    public string? CKundenNr { get; set; }

    public bool MahnstopKunde { get; set; }

    public string? CRechnungsNr { get; set; }

    public DateTime? Rechnungsdatum { get; set; }

    public DateTime? RechnungZahlungsZiel { get; set; }

    public decimal? MahnBetrag { get; set; }

    public string? CVorname { get; set; }

    public string? CName { get; set; }

    public string? CMail { get; set; }

    public string? CFirma { get; set; }

    public string? Mahnstufe { get; set; }

    public string? CKommentar { get; set; }

    public int? KBenutzer { get; set; }

    public decimal? Betrag { get; set; }

    public decimal? OffenerPosten { get; set; }

    public decimal? Gesamt { get; set; }

    public DateTime? MahnungErstellt { get; set; }

    public DateTime? NaechstesZahlungsziel { get; set; }

    public int Zahlungsstatus { get; set; }

    public int? KKundenGruppe { get; set; }

    public int? KFirmaHistory { get; set; }

    public int KFirma { get; set; }

    public int? KMahnstufe { get; set; }

    public int? KZahlungsErinnerung { get; set; }

    public int KRechnung { get; set; }

    public int KKunde { get; set; }

    public int KBestellung { get; set; }

    public decimal? FBruttoBetrag { get; set; }

    public decimal? Mahngebuehr { get; set; }

    public int? KZahlungsart { get; set; }

    public string? CBestellNr { get; set; }

    public DateTime? Versanddatum { get; set; }

    public int? Karenzzeit { get; set; }

    public bool NIstEntwurf { get; set; }
}
