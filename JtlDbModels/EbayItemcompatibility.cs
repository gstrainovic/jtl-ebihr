using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayItemcompatibility
{
    public int KItemCompatibility { get; set; }

    public int KItem { get; set; }

    public long? KType { get; set; }

    public string? CMarke { get; set; }

    public string? CModell { get; set; }

    public string? CTyp { get; set; }

    public string? CPlattform { get; set; }

    public string? CBaujahr { get; set; }

    public string? CMotor { get; set; }

    public string? CHsntsn { get; set; }

    public string? CCompatibilityNote { get; set; }
}
