using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tfirma
{
    public int KFirma { get; set; }

    public string? CName { get; set; }

    public string? CUnternehmer { get; set; }

    public string? CStrasse { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CLand { get; set; }

    public string? CTel { get; set; }

    public string? CFax { get; set; }

    public string? CEmail { get; set; }

    public string? CWww { get; set; }

    public string? CBlz { get; set; }

    public string? CKontoNr { get; set; }

    public string? CBank { get; set; }

    public string? CSteuerNr { get; set; }

    public string? CInet { get; set; }

    public string? CIntrashipKdNr { get; set; }

    public string? CUpskdNr { get; set; }

    public string? CIban { get; set; }

    public string? CBic { get; set; }

    public string? CKopfGrafik { get; set; }

    public string? CFusszeile { get; set; }

    public string? CKontoInhaber { get; set; }

    public string? CAktiv { get; set; }

    public string? CGlaeubigerId { get; set; }

    public string? CLandIso { get; set; }

    public string? CPayPalEmail { get; set; }

    public bool NKleinunternehmer { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public string? CObfuskierung { get; set; }
}
