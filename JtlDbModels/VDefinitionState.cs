using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VDefinitionState
{
    public int KDefinition { get; set; }

    public bool? NFormulaReadOnly { get; set; }

    public bool? NDimensionsReadOnly { get; set; }
}
