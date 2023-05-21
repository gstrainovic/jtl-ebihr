using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonApaUsersetting
{
    public int KUser { get; set; }

    public decimal FApapreisabstand { get; set; }

    public byte? NIstApapreisabstandProzentual { get; set; }

    public int NPlattform { get; set; }

    public int? NApashippingTime { get; set; }

    public int? NApasellerPositiveFeedbackRating { get; set; }

    public decimal FApapreisabstandFba { get; set; }

    public byte? NIstApapreisabstandFbaprozentual { get; set; }
}
