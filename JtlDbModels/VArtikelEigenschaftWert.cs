﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelEigenschaftWert
{
    public int KEigenschaftWert { get; set; }

    public int KEigenschaft { get; set; }

    public string? CName { get; set; }

    public decimal FAufpreisNetto { get; set; }

    public decimal FGewichtDiff { get; set; }

    public string? CArtNr { get; set; }

    public int? NSort { get; set; }

    public decimal FLagerbestand { get; set; }

    public decimal FPackeinheit { get; set; }

    public decimal FAufpreis { get; set; }

    public string? CBarcode { get; set; }

    public string? CAktiv { get; set; }

    public string? CInet { get; set; }

    public int KSprache { get; set; }
}
