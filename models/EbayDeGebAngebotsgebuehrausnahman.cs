using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayDeGebAngebotsgebuehrausnahman
{
    public int KEbayDeGebAngebotsgebuehrAusnahmen { get; set; }

    public int? CategoryId { get; set; }

    public byte? NurFestpreis { get; set; }

    public decimal Gebuehr { get; set; }
}
