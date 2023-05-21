using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class FulfilmentOrder
{
    /// <summary>
    /// Interne ID des Fulfillmentauftrags
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID der Firma
    /// </summary>
    public int CompanyInternalId { get; set; }

    /// <summary>
    /// Nummer des Lieferscheins
    /// </summary>
    public string? DeliveryNoteId { get; set; }

    /// <summary>
    /// Interne ID des Kunden
    /// </summary>
    public int? CustomerInternalId { get; set; }

    /// <summary>
    /// Interne ID des Warenlagers
    /// </summary>
    public int? WarehouseInternalId { get; set; }

    /// <summary>
    /// Interne ID des Benutzers
    /// </summary>
    public int? UserInternalId { get; set; }

    /// <summary>
    /// Interne ID der Bestellung
    /// </summary>
    public int SalesOrderInternalId { get; set; }

    /// <summary>
    /// Interne ID des Lieferscheins
    /// </summary>
    public int? DeliveryNoteInternalId { get; set; }

    /// <summary>
    /// Status des Fulfillmentauftrags
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// ISO-Code der Währung
    /// </summary>
    public string? CurrencyIso { get; set; }

    /// <summary>
    /// Nummer der Bestellung
    /// </summary>
    public string? SalesOrderId { get; set; }

    /// <summary>
    /// Erstelldatum des Fulfillmentauftrags
    /// </summary>
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Druckdatum des Fulfillmentauftrags
    /// </summary>
    public DateTime? PrintingDate { get; set; }

    /// <summary>
    /// Maildatum des Fulfillmentauftrags
    /// </summary>
    public DateTime? MailingDate { get; set; }

    /// <summary>
    /// Datum des Faxversands
    /// </summary>
    public DateTime? FaxingDate { get; set; }

    /// <summary>
    /// Datum der Übertragung zum Fulfiller
    /// </summary>
    public DateTime? ApiShippingDate { get; set; }

    /// <summary>
    /// Datum an dem der Fulfillmentauftrag in Bearbeitung ging
    /// </summary>
    public DateTime? InProcessDate { get; set; }

    /// <summary>
    /// Lieferpriorität des Fulfillmentauftrags
    /// </summary>
    public string? DeliveryProperty { get; set; }

    /// <summary>
    /// Auftragsdrucktext
    /// </summary>
    public string? SalesOrderText { get; set; }

    /// <summary>
    /// Auftrags-ID des Fulfillmentauftragvorgangs
    /// </summary>
    public string? OperationId { get; set; }
}
