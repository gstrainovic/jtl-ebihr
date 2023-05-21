using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class SalesOrderPosition
{
    /// <summary>
    /// Interne ID der Auftragsposition
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID des Auftrags
    /// </summary>
    public int SalesOrderInternalId { get; set; }

    /// <summary>
    /// Artikelnummer
    /// </summary>
    public string? Sku { get; set; }

    /// <summary>
    /// Bezeichnung für den Druck, Speichern oder E-Mail senden
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Einheit des Artikels
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// Hinweis zur Position
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Lange Artikelbeschreibung
    /// </summary>
    public string? ItemDescriptionDetailed { get; set; }

    /// <summary>
    /// Kurze Artikelbeschreibung
    /// </summary>
    public string? ItemDescriptionBrief { get; set; }

    /// <summary>
    /// Anzahl des Artikels in einer Position
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// MwSt. in Prozent
    /// </summary>
    public decimal Vatrate { get; set; }

    /// <summary>
    /// Netto Einkaufspreis des Artikels
    /// </summary>
    public decimal PurchasePriceNet { get; set; }

    /// <summary>
    /// Einzelbruttopreis des Artikels
    /// </summary>
    public decimal? GrossPricePerUnit { get; set; }

    /// <summary>
    /// Einzelnettopreis des Artikels
    /// </summary>
    public decimal NetPricePerUnit { get; set; }

    /// <summary>
    /// Gesamtbruttopreis über die Anzahl des Artikels in der Position
    /// </summary>
    public decimal? TotalGrossPrice { get; set; }

    /// <summary>
    /// Gesamtnettopreis über die Anzahl des Artikels in der Position
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// Betrag der MwSt.
    /// </summary>
    public decimal? Vatvalue { get; set; }

    /// <summary>
    /// Rabattbetrag
    /// </summary>
    public decimal? DiscountValue { get; set; }

    public decimal DiscountRate { get; set; }

    /// <summary>
    /// Typ der Position
    /// </summary>
    public string PositionType { get; set; } = null!;

    /// <summary>
    /// Internationale Artikelnummer
    /// </summary>
    public string? Ean { get; set; }

    /// <summary>
    /// Wert zu Sortierung der Position innerhalb des Auftrags
    /// </summary>
    public int Sorting { get; set; }

    /// <summary>
    /// Gibt den Typ der Konfiguratorposition an
    /// </summary>
    public string ConfiguratorPosition { get; set; } = null!;

    /// <summary>
    /// Komponente der Stückliste
    /// </summary>
    public string BillOfMaterialsPosition { get; set; } = null!;

    /// <summary>
    /// Vaterartikel-ID der Stücklistenposition
    /// </summary>
    public int? BillOfMaterialsPositionParentId { get; set; }

    /// <summary>
    /// Position des Vaterartikels des Konfigurationsartikels
    /// </summary>
    public int ConfiguratorPositionParentId { get; set; }

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
    /// Interne ID des Artikels in der Position
    /// </summary>
    public int? ProductInternalId { get; set; }

    /// <summary>
    /// Amazon Custom-Position
    /// </summary>
    public bool? IsAmazonCustomPosition { get; set; }

    /// <summary>
    /// Amazon Custom JSON-Datei
    /// </summary>
    public string? AmazonCustomJson { get; set; }
}
