using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class InvoiceCorrectionPosition
{
    /// <summary>
    /// Interne ID der Rechnungskorrektur
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID der Rechnungskorrektur
    /// </summary>
    public int InvoiceCorrectionInternalId { get; set; }

    /// <summary>
    /// Artikelnummer des Artikels in der Position
    /// </summary>
    public string? Sku { get; set; }

    /// <summary>
    /// Drucktext der Position
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Einheit der Rechnungskorrekturposition
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// Hinweis in den Rechnungskorrekturpositionen
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Ausführliche Artikelbeschreibung der Position der Rechnungskorrektur
    /// </summary>
    public string? ItemDescriptionDetailed { get; set; }

    /// <summary>
    /// Kurze Beschreibung der Position der Rechnungskorrektur
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
    /// Bruttopreis Einzel pro Artikel
    /// </summary>
    public decimal? GrossPricePerUnit { get; set; }

    /// <summary>
    /// Nettopreis Einzel pro Artikel
    /// </summary>
    public decimal NetPricePerUnit { get; set; }

    /// <summary>
    /// Bruttopreis Gesamt über die Anzahl der Artikel in der Position
    /// </summary>
    public decimal? TotalGrossPrice { get; set; }

    /// <summary>
    /// Nettopreis Gesamt über die Anzahl der Artikel in der Position
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// MwSt Betrag pro Position
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
    /// Interne ID für Stücklistenpositionen
    /// </summary>
    public string BillOfMaterialsPosition { get; set; } = null!;

    /// <summary>
    /// Interne ID des Konfigurationsartikels in der Rechnungskorrekturposition
    /// </summary>
    public int? ConfigurationItemInternalId { get; set; }

    /// <summary>
    /// Einzelgewicht des Artikels
    /// </summary>
    public decimal? IndividualWeight { get; set; }

    /// <summary>
    /// Gesamtgewicht über die Anzahl des Artikels in der Position
    /// </summary>
    public decimal? TotalWeight { get; set; }

    /// <summary>
    /// Einzel Versandgewicht des Artikels
    /// </summary>
    public decimal? IndividualShippingWeight { get; set; }

    /// <summary>
    /// Gesamt Versandgewicht des Artikels über die Anzahl in der Position
    /// </summary>
    public decimal? TotalShippingWeight { get; set; }

    /// <summary>
    /// Sortierung Rechnungskorrekturposition
    /// </summary>
    public int? Sorting { get; set; }

    /// <summary>
    /// Typ der Vaterartikel-ID des Stücklistenangebots der Rechnungskorrekturposition
    /// </summary>
    public int BillOfMaterialsPositionParentId { get; set; }

    /// <summary>
    /// Typ der Vaterartikel-ID des Konfigurationsangebots der Rechnungskorrekturposition
    /// </summary>
    public int ConfiguratorPositionParentId { get; set; }

    /// <summary>
    /// Internationale Artikelnummer
    /// </summary>
    public string? Ean { get; set; }

    /// <summary>
    /// Interne ID des Artikels der Position
    /// </summary>
    public int? ProductInternalId { get; set; }
}
