using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PurchaseOrderPosition
{
    /// <summary>
    /// Interne ID der Lieferantenbestellungsposition
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID der Lieferantenbestellung
    /// </summary>
    public int PurchaseOrderInternalId { get; set; }

    /// <summary>
    /// Interne ID des Artikels in der Position
    /// </summary>
    public int ProductInternalId { get; set; }

    /// <summary>
    /// Nummer des Artikels in der Position
    /// </summary>
    public string? Sku { get; set; }

    /// <summary>
    /// Artikelnummer des Lieferanten in der Position
    /// </summary>
    public string? Skusupplier { get; set; }

    /// <summary>
    /// Bezeichnung der Position
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Bezeichnung des Lieferanten
    /// </summary>
    public string? SupplierName { get; set; }

    /// <summary>
    /// MwSt in Prozent
    /// </summary>
    public decimal Vatrate { get; set; }

    /// <summary>
    /// Anzahl pro Position (Menge?)
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Einzel-Nettopreis des Artikels
    /// </summary>
    public decimal PurchasePriceNetPerUnit { get; set; }

    /// <summary>
    /// Einzel-Bruttopreis des Artikels
    /// </summary>
    public decimal? GrossPricePerUnit { get; set; }

    /// <summary>
    /// Gesamt-Bruttopreis des Artikel über die Anzahl in der Position
    /// </summary>
    public decimal? TotalGrossPrice { get; set; }

    /// <summary>
    /// Gesamt-Nettopreis des Artikel über die Anzahl in der Position
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// MwSt.-Betrag
    /// </summary>
    public decimal? Vatvalue { get; set; }

    /// <summary>
    /// Hinweis zur Position
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Typ der Position
    /// </summary>
    public string? PositionType { get; set; }

    /// <summary>
    /// Name des Lieferanten
    /// </summary>
    public string? NameOfSupplier { get; set; }

    /// <summary>
    /// Anzahl der Liefertage
    /// </summary>
    public int? DeliveryDays { get; set; }

    /// <summary>
    /// Interne Id der Lieferscheinposition
    /// </summary>
    public int? DeliveryNotePositionInternalId { get; set; }

    /// <summary>
    /// Menge der gelieferten Artikel pro Position
    /// </summary>
    public decimal DeliveredQuantity { get; set; }

    /// <summary>
    /// Anzahl noch ausstehender Artikel pro Position
    /// </summary>
    public decimal OpenQuantity { get; set; }
}
