using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Country
{
    public string CountryId { get; set; } = null!;

    public byte[] LastChange { get; set; } = null!;
}
