using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class SalesQuotationPosition
{
    /// <summary>
    /// Interne ID des Angebots
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Nummer des Artikels in der Position
    /// </summary>
    public string? Sku { get; set; }

    /// <summary>
    /// Drucktext
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Einheit des Artikels
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// Hinweis zur Angebotsposition
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Interne Angebots-ID der Angebotsposition
    /// </summary>
    public int SalesQuotationInternalId { get; set; }

    /// <summary>
    /// Lange Artikelbeschreibung
    /// </summary>
    public string? ItemDescriptionDetailed { get; set; }

    /// <summary>
    /// Kurze Artikelbeschreibung
    /// </summary>
    public string? ItemDescriptionBrief { get; set; }

    /// <summary>
    /// Anzahl des Artikels in der Position
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// MwSt in Prozent
    /// </summary>
    public decimal Vatrate { get; set; }

    /// <summary>
    /// Nettoeinkaufspreis des Artikels
    /// </summary>
    public decimal PurchasePriceNet { get; set; }

    /// <summary>
    /// Bruttopreis Einzel des Artikels
    /// </summary>
    public decimal? GrossPricePerUnit { get; set; }

    /// <summary>
    /// Nettopreis Einzel des Artikels
    /// </summary>
    public decimal NetPricePerUnit { get; set; }

    /// <summary>
    /// Bruttpreis Gesamt über die Anzahl des Artikels in der Position
    /// </summary>
    public decimal? TotalGrossPrice { get; set; }

    /// <summary>
    /// Nettopreis Gesamt über die Anzahl des Artikels in der Position
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// Betrag der MwSt
    /// </summary>
    public decimal? Vatvalue { get; set; }

    /// <summary>
    /// Rabattbetrag
    /// </summary>
    public decimal? DiscountValue { get; set; }

    /// <summary>
    /// Rabatt in Prozent
    /// </summary>
    public decimal DiscountRate { get; set; }

    /// <summary>
    /// Typ der Position
    /// </summary>
    public string PositionType { get; set; } = null!;

    /// <summary>
    /// Gibt den Typ der Konfiguratorposition an
    /// </summary>
    public string ConfiguratorPosition { get; set; } = null!;

    /// <summary>
    /// Typ des Stücklistenangebots
    /// </summary>
    public string BillOfMaterialsPosition { get; set; } = null!;

    /// <summary>
    /// Interne ID des Konfigurationsartikels im Angebot
    /// </summary>
    public int? ConfigurationItemInternalId { get; set; }

    /// <summary>
    /// Einzelgewicht des Artikels
    /// </summary>
    public decimal? IndividualWeight { get; set; }

    /// <summary>
    /// Gesamtgewicht des Artikels über die Anzahl in der Position
    /// </summary>
    public decimal? TotalWeight { get; set; }

    /// <summary>
    /// Einzel-Versandgewicht des Artikels
    /// </summary>
    public decimal? IndividualShippingWeight { get; set; }

    /// <summary>
    /// Gesamt-Versandgewicht des Artikels über die Anzahl in der Position
    /// </summary>
    public decimal? TotalShippingWeight { get; set; }

    /// <summary>
    /// Sortierung der Positionen innerhalb eines Angebots
    /// </summary>
    public int Sorting { get; set; }

    /// <summary>
    /// Typ der Vaterartikel-ID des Stücklistenangebots der Angebotsposition
    /// </summary>
    public int? BillOfMaterialsPositionParentId { get; set; }

    /// <summary>
    /// Typ der Vaterartikel-ID des Konfigurationsangebots der Angebotsposition
    /// </summary>
    public int ConfiguratorPositionParentId { get; set; }

    /// <summary>
    /// Internationale Artikelnummer
    /// </summary>
    public string? Ean { get; set; }

    /// <summary>
    /// Interne ID des Artikels in der Position
    /// </summary>
    public int? ProductInternalId { get; set; }
}
