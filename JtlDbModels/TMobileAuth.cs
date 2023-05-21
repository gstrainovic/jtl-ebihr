using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMobileAuth
{
    public int KAuthCode { get; set; }

    public int? KMandant { get; set; }
}
