using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class FulfilmentOrderPosition
{
    /// <summary>
    /// Interne ID des Artikels
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID der Fulfillmentauftragspositionen
    /// </summary>
    public int? FulfilmentOrderInternalId { get; set; }

    /// <summary>
    /// Artikelnummer des Artikels auf der Position
    /// </summary>
    public string Sku { get; set; } = null!;

    /// <summary>
    /// Anzahl pro Position
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Status der Fulfillmentauftragsposition
    /// </summary>
    public int? Status { get; set; }

    /// <summary>
    /// Geschenktext für den Artikel
    /// </summary>
    public string? ItemGiftText { get; set; }

    /// <summary>
    /// Hinweis zum Artikel in der Position
    /// </summary>
    public string? ItemNote { get; set; }

    /// <summary>
    /// Interne ID der Lieferscheinposition
    /// </summary>
    public int? DeliveryNotePositionInternalId { get; set; }

    /// <summary>
    /// Drucktext zur Fulfillmentauftragsposition
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Interne ID zur verwendeten Sprache
    /// </summary>
    public int? LanguageInternalId { get; set; }

    /// <summary>
    /// Sortierung der Fulfillmentauftragspositionen
    /// </summary>
    public int? Sorting { get; set; }

    /// <summary>
    /// Gewicht des Artikels
    /// </summary>
    public decimal? IndividualWeight { get; set; }

    /// <summary>
    /// Gewicht der Menge in der Position
    /// </summary>
    public decimal? TotalWeight { get; set; }

    /// <summary>
    /// Einheit des Artikels
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// Hinweis der Lieferscheinposition zur Fulfillmentauftragsposition
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Lange Artikelbeschreibung
    /// </summary>
    public string? ItemDescriptionDetailed { get; set; }

    /// <summary>
    /// Kurze Artikelbeschreibung
    /// </summary>
    public string? ItemDescriptionShort { get; set; }
}
