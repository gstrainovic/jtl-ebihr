using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Parcel1
{
    /// <summary>
    /// Interne ID des Pakets
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID des Lieferscheins
    /// </summary>
    public int DeliveryNoteInternalId { get; set; }

    /// <summary>
    /// IdentCode des Pakets
    /// </summary>
    public string? IdentCode { get; set; }

    /// <summary>
    /// Erstelldatum des Pakets
    /// </summary>
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Hinweis zum Paket
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Gewicht des Pakets
    /// </summary>
    public decimal Weight { get; set; }

    /// <summary>
    /// Name des Logistikers
    /// </summary>
    public string? ShippingServiceProviderName { get; set; }

    /// <summary>
    /// Datum des Versands des Pakets
    /// </summary>
    public DateTime? ShippingDate { get; set; }

    /// <summary>
    /// Sendungsreferenz
    /// </summary>
    public string? ShipmentReference { get; set; }

    /// <summary>
    /// Kundenreferenz
    /// </summary>
    public string? CustomerReference { get; set; }

    /// <summary>
    /// Tracking-URL
    /// </summary>
    public string? TrackingUrl { get; set; }

    /// <summary>
    /// Gibt an, ob es sich um ein Shippingpaket handelt
    /// </summary>
    public bool? IsShippingParcel { get; set; }

    /// <summary>
    /// Interne ID der Versandart des Pakets
    /// </summary>
    public int? ShippingMethodInternalId { get; set; }
}
