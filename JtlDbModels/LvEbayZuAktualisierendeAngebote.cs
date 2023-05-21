using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvEbayZuAktualisierendeAngebote
{
    public int KEbayItem { get; set; }

    public string? CItemId { get; set; }

    public string? CTitle { get; set; }

    public int KEbayUser { get; set; }

    public string CEbayUserName { get; set; } = null!;

    public int NSiteId { get; set; }

    public byte? NVariationenAktiv { get; set; }

    public string CPlattform { get; set; } = null!;

    public string? CArtikelnummer { get; set; }

    public int NFehler { get; set; }

    public int NRest { get; set; }

    public int NPreise { get; set; }

    public int NAngebotsmenge { get; set; }

    public int NKategorie { get; set; }

    public int NVersand { get; set; }

    public int NRueckgabe { get; set; }

    public int NZahlungsarten { get; set; }

    public int NBilderOderBeschreibung { get; set; }

    public int NVarkombisPreis { get; set; }

    public int NVarkombisNichtPreis { get; set; }

    public int NFahrzeugverwendungsliste { get; set; }

    public int? KArtikel { get; set; }
}
