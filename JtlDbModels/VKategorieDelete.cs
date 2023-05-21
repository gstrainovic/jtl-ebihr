using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VKategorieDelete
{
    public int? KKategorie { get; set; }

    public int? KShop { get; set; }

    public byte? NInBearbeitung { get; set; }

    public int NType { get; set; }
}
