using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAmazonVersandschnittstellenkonfiguration
{
    public int KAmazonVersandschnittstellenkonfiguration { get; set; }

    public int? KVersandart { get; set; }

    public string CVersandartName { get; set; } = null!;

    public decimal DWeight { get; set; }

    public decimal DHeight { get; set; }

    public decimal DLength { get; set; }

    public decimal DWidth { get; set; }

    public byte NAutoCalcWeight { get; set; }

    public byte NCarrierWillPickUp { get; set; }

    public decimal FMinWeight { get; set; }

    public byte NAdditionalInsurance { get; set; }

    public byte? NUseWarenlagerAdresse { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
