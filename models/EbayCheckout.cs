using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayCheckout
{
    public int KEbayCheckout { get; set; }

    public int? KEbayBuyer { get; set; }

    public int? KEbayUser { get; set; }

    public string? CVerwendungszweck { get; set; }

    public string? CLieferAnrede { get; set; }

    public string? CLieferVorname { get; set; }

    public string? CLieferNachname { get; set; }

    public string? CLieferNamenszusatz { get; set; }

    public string? CLieferStrasse { get; set; }

    public string? CLieferAdresszusatz { get; set; }

    public string? CLieferPlz { get; set; }

    public string? CLieferOrt { get; set; }

    public string? CLieferOrtszusatz { get; set; }

    public string? CLieferLand { get; set; }

    public string? CLieferTel { get; set; }

    public string? CLieferFax { get; set; }

    public string? CLieferHandy { get; set; }

    public string? CZahlungsart { get; set; }

    public string? CZahlungBankName { get; set; }

    public string? CZahlungBlz { get; set; }

    public string? CZahlungKontoNr { get; set; }

    public string? CZahlungKartenNr { get; set; }

    public string? CZahlungGueltigkeit { get; set; }

    public string? CZahlungCvv { get; set; }

    public string? CZahlungKartenTyp { get; set; }

    public string? CZahlungInhaber { get; set; }

    public decimal FVersandkosten { get; set; }

    public DateTime? DErstelltAm { get; set; }

    public DateTime? DAbgeschlossenAm { get; set; }

    public byte? NStatus { get; set; }

    public byte? NAnzahlPos { get; set; }

    public decimal FSumme { get; set; }

    public string? CVersandArt { get; set; }

    public string? CTel { get; set; }

    public string? CFax { get; set; }

    public string? CMobil { get; set; }

    public string? CEmail { get; set; }

    public string? CComment { get; set; }

    public string? CFirma { get; set; }

    public string? CLieferFirma { get; set; }

    public string? CUstId { get; set; }

    public string? CAdresszusatz { get; set; }

    public string? CAnrede { get; set; }

    public string? CVorname { get; set; }

    public string? CNachname { get; set; }

    public byte? NCheckoutType { get; set; }

    public string? CPaymentStatus { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CLand { get; set; }

    public int? NNeu { get; set; }

    public string? CStrasse { get; set; }

    public string? CPaypalTransactionId { get; set; }

    public string? CPuizahlungsdaten { get; set; }

    public byte? NInBearbeitung { get; set; }

    public string? COrderId { get; set; }
}
