using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class DeliveryNotePosition
{
    /// <summary>
    /// Interne ID der Lieferscheinposition
    /// </summary>
    public int InternalId { get; set; }

    /// <summary>
    /// Interne ID des Lieferscheins der Positionen
    /// </summary>
    public int DeliveryNoteInternalId { get; set; }

    /// <summary>
    /// Anzahl pro Position auf dem Lieferschein
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Hinweisfeld zur Lieferscheinposition
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Artikelnummer
    /// </summary>
    public string? Sku { get; set; }

    public string? Jfsku { get; set; }

    /// <summary>
    /// Drucktext der Bestellposition
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Artikebeschreibung ausführlich
    /// </summary>
    public string? ItemDescriptionDetailed { get; set; }

    /// <summary>
    /// Artikelbeschreibung kurz
    /// </summary>
    public string? ItemDescriptionBrief { get; set; }

    /// <summary>
    /// Einheit pro Position
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// Typ der Position im Lieferschein
    /// </summary>
    public string PositionType { get; set; } = null!;

    /// <summary>
    /// Gibt an, ob Stücklistenkomponente oder Stücklistenvaterartikel
    /// </summary>
    public string ConfiguratorPosition { get; set; } = null!;

    /// <summary>
    /// Position der Stücklisten
    /// </summary>
    public string BillOfMaterialsPosition { get; set; } = null!;

    /// <summary>
    /// Interne ID Konfigurationsartikel
    /// </summary>
    public int? ConfigurationItemInternalId { get; set; }

    /// <summary>
    /// Vater-ID der Position der Stücklisten
    /// </summary>
    public int? BillOfMaterialsPositionParentId { get; set; }

    /// <summary>
    /// Vater-ID der Position der Konfigurationsartikel
    /// </summary>
    public int ConfiguratorPositionParentId { get; set; }

    /// <summary>
    /// Interne Id des Artikels der Lieferscheinposition
    /// </summary>
    public int ProductInternalId { get; set; }

    /// <summary>
    /// Internationale Artikelnummer
    /// </summary>
    public string? Ean { get; set; }

    /// <summary>
    /// Sortierung der Lieferscheinpositonen
    /// </summary>
    public int Sorting { get; set; }

    /// <summary>
    /// Nettopreis pro Einheit der Lieferscheinposition
    /// </summary>
    public decimal NetPricePerUnit { get; set; }

    /// <summary>
    /// Gesamtnettopreis der Lieferscheinpositionen
    /// </summary>
    public decimal? TotalNetPrice { get; set; }

    /// <summary>
    /// Gewichte der einzelnen Lieferscheinpositionen
    /// </summary>
    public decimal? IndividualWeight { get; set; }

    /// <summary>
    /// Gesamtversandgewicht der Lieferung
    /// </summary>
    public decimal? TotalShippingWeight { get; set; }

    public bool? IsAmazonCustomPosition { get; set; }

    public string? AmazonCustomJson { get; set; }
}
