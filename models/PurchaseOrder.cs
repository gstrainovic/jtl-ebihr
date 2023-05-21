using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PurchaseOrder
{
    /// <summary>
    /// Interne ID der Lieferantenbestellung
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID des Lieferanten
    /// </summary>
    public int SupplierInternalId { get; set; }

    /// <summary>
    /// Interne Rechnungsadresse der Lieferantenbestellung
    /// </summary>
    public int? PurchaseOrderBillToAddressInternalId { get; set; }

    /// <summary>
    /// Interne Lieferantenadresse der Lieferantenbestellung
    /// </summary>
    public int? PurchaseOrderSupplierAddressInternalId { get; set; }

    /// <summary>
    /// Datum der Erstellung der Lieferantenbestellung
    /// </summary>
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Druckdatum der Lieferantenbestellung
    /// </summary>
    public DateTime? PrintingDate { get; set; }

    /// <summary>
    /// Maildatum der Lieferantenbestellung
    /// </summary>
    public DateTime? MailingDate { get; set; }

    /// <summary>
    /// Faxdatum der Lieferantenbestellung
    /// </summary>
    public DateTime? FaxingDate { get; set; }

    /// <summary>
    /// Exportierdatum der Lieferantenbestellung
    /// </summary>
    public DateTime? ExportingDate { get; set; }

    /// <summary>
    /// Währung angegeben in ISO
    /// </summary>
    public string CurrencyIso { get; set; } = null!;

    /// <summary>
    /// Drucktext
    /// </summary>
    public string? PrintingNote { get; set; }

    /// <summary>
    /// Interne ID der Firma
    /// </summary>
    public int? CompanyInternalId { get; set; }

    /// <summary>
    /// Interne ID des Lagers
    /// </summary>
    public int? WarehouseInternalId { get; set; }

    /// <summary>
    /// Interne ID des Kunden
    /// </summary>
    public int? CustomerInternalId { get; set; }

    /// <summary>
    /// Eigene Bestellnummer der Lieferantenbestellung
    /// </summary>
    public string? OwnPurchaseOrderId { get; set; }

    /// <summary>
    /// Auftragsnummer wenn Bezug zu einem Kundenauftrag besteht
    /// </summary>
    public string? ReferenceSalesOrderId { get; set; }

    /// <summary>
    /// Interne ID des Lieferanten für die Lieferantenbestellung
    /// </summary>
    public int? PurchaseOrderSupplierInternalId { get; set; }

    /// <summary>
    /// Interne ID des Benutzers
    /// </summary>
    public int? UserInternalId { get; set; }

    /// <summary>
    /// ID des internen Lieferscheins
    /// </summary>
    public int DeliveryNoteInternalId { get; set; }

    /// <summary>
    /// Faktor zur Umrechnung der Währung
    /// </summary>
    public decimal CurrencyFactor { get; set; }

    /// <summary>
    /// Status der Lieferantenbestellung
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Gibt an, ob Liefer- und Rechnungsadresse unterschiedlich sind
    /// </summary>
    public bool? DifferentAddresses { get; set; }

    /// <summary>
    /// Gesamtnettopreis der Lieferantenbestellung
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// Gesamtbruttopreis der Lieferantenbestellung
    /// </summary>
    public decimal? TotalGrossPrice { get; set; }

    /// <summary>
    /// Rabatt des Gesamtbruttopreises der Lieferantenbestellung
    /// </summary>
    public decimal? TotalGrossPriceDiscount { get; set; }

    /// <summary>
    /// Rabatt des Gesamtnettopreises der Lieferantenbestellung
    /// </summary>
    public decimal? TotalNetPriceDiscount { get; set; }

    /// <summary>
    /// Zeigt an, wie hoch die MwSt der Lieferantenbestellung ist
    /// </summary>
    public decimal? TotalVatprice { get; set; }

    /// <summary>
    /// Auftrags-ID der Lieferantenbestellung
    /// </summary>
    public string? OperationId { get; set; }
}
