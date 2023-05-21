using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class InvoicePosition
{
    /// <summary>
    /// Interne ID der Rechnung
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID der Rechnung zur Rechnungsposition
    /// </summary>
    public int InvoiceInternalId { get; set; }

    /// <summary>
    /// Artikelnummer zu der Position
    /// </summary>
    public string? Sku { get; set; }

    /// <summary>
    /// Text zur Artikelposition
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Einheit des Artikels der Position
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// Hinweis zur Rechnungsposition
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Erlöskonto zur Rechnungsposition
    /// </summary>
    public string? RevenueAccount { get; set; }

    /// <summary>
    /// Lange Artikelbeschreibung
    /// </summary>
    public string? ItemDescriptionDetailed { get; set; }

    /// <summary>
    /// Kurze Artikelbeschreibung
    /// </summary>
    public string? ItemDescriptionBrief { get; set; }

    /// <summary>
    /// Anzahl pro Position
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// MwSt Satz in Prozent
    /// </summary>
    public decimal Vatrate { get; set; }

    /// <summary>
    /// Netto Einkaufspreis der Position
    /// </summary>
    public decimal? PurchaseNetPrice { get; set; }

    /// <summary>
    /// Einzelbruttopreis der Position
    /// </summary>
    public decimal? GrossPricePerUnit { get; set; }

    /// <summary>
    /// Einzelnettopreis der Position
    /// </summary>
    public decimal NetPricePerUnit { get; set; }

    /// <summary>
    /// Gesamtbruttopreis über die Anzahl in der Position
    /// </summary>
    public decimal? TotalGrossPrice { get; set; }

    /// <summary>
    /// Gesamtnettopreis über die Anzahl in der Position
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// Betrag der MwSt
    /// </summary>
    public decimal? Vatvalue { get; set; }

    /// <summary>
    /// Betrag des Rabatts
    /// </summary>
    public decimal? DiscountValue { get; set; }

    /// <summary>
    /// Rabatt in Prozent
    /// </summary>
    public decimal DiscountRate { get; set; }

    /// <summary>
    /// Gibt den Positionstyp an
    /// </summary>
    public string PositionType { get; set; } = null!;

    /// <summary>
    /// Gibt den Typ der Konfiguratorposition an
    /// </summary>
    public string ConfiguratorPosition { get; set; } = null!;

    /// <summary>
    /// Stücklistenposition
    /// </summary>
    public string BillOfMaterialsPosition { get; set; } = null!;

    /// <summary>
    /// Interne ID des Konfigurationsartikels
    /// </summary>
    public int? ConfigurationItemInternalId { get; set; }

    /// <summary>
    /// Einzelgewicht des Artikels
    /// </summary>
    public decimal? IndividualWeight { get; set; }

    /// <summary>
    /// Gesamtgewicht der Position
    /// </summary>
    public decimal? TotalWeight { get; set; }

    /// <summary>
    /// Einzelversandgewicht des Artikels
    /// </summary>
    public decimal? IndividualShippingWeight { get; set; }

    /// <summary>
    /// Gesamtversandgewicht der Position
    /// </summary>
    public decimal? TotalShippingWeight { get; set; }

    /// <summary>
    /// Gibt die Sortierung der Positionen an
    /// </summary>
    public int Sorting { get; set; }

    /// <summary>
    /// Typ der Vaterartikel-ID des Stücklistenangebots der Rechnungskorrekturposition
    /// </summary>
    public int? BillOfMaterialsPositionParentId { get; set; }

    /// <summary>
    /// Typ der Vaterartikel-ID des Konfigurationsangebots derRechnungskorrekturposition
    /// </summary>
    public int ConfiguratorPositionParentId { get; set; }

    /// <summary>
    /// Internationale Artikelnummer der Rechnungskorrekturposition
    /// </summary>
    public string? Ean { get; set; }

    /// <summary>
    /// Interne ID des Artikels der Position
    /// </summary>
    public int? ProductInternalId { get; set; }

    public bool? IsAmazonCustomPosition { get; set; }

    public string? AmazonCustomJson { get; set; }
}
