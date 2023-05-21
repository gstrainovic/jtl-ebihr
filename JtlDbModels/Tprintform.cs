using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tprintform
{
    public string? CKopfzeichnen { get; set; }

    public string? CFusszeichnen { get; set; }

    public decimal FKalinks { get; set; }

    public decimal FKaoben { get; set; }

    public decimal FFdlinks { get; set; }

    public decimal FFdoben { get; set; }

    public string? CFirmendatenklein { get; set; }

    public string? CFirmendatendrucken { get; set; }

    public string? CFuss { get; set; }

    public string? CKdNrDrucken { get; set; }

    public string? CbzglAuftragDrucken { get; set; }

    public string? CRechnungZzglMwst { get; set; }

    public decimal FGlinks { get; set; }

    public decimal FGrechts { get; set; }

    public string? CAngebotsText { get; set; }

    public string? CAuftragsText { get; set; }

    public string? CRechnungsText { get; set; }

    public string? CMwStAusweisen { get; set; }

    public string? CFdrucken { get; set; }

    public decimal FFunten { get; set; }

    public decimal FFmitte { get; set; }

    public decimal FFoben { get; set; }

    public string? CZahlungsziel { get; set; }

    public decimal FFbreite { get; set; }

    public byte? NZwischensumme { get; set; }

    public string? CEinheit { get; set; }

    public string? CLieferText { get; set; }

    public byte? NVariationAufpreis { get; set; }

    public byte? NLadrDrucken { get; set; }

    public byte? NTelDrucken { get; set; }

    public byte? NPixelFont { get; set; }

    public string? CIgltext { get; set; }

    public string? CUstFreiText { get; set; }

    public string? CReverseCharge { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
