using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Twebversand
{
    public int? KWebVersand { get; set; }

    public string? CServerUrl { get; set; }

    public string? CBenutzerWeb { get; set; }

    public string? CPasswortWeb { get; set; }

    public string? CServerFtp { get; set; }

    public string? CBenutzerFtp { get; set; }

    public string? CPasswortFtp { get; set; }

    public string? CPasv { get; set; }

    public string? CApikey { get; set; }

    public string? CFtppath { get; set; }

    public byte? NHttpPut { get; set; }

    public byte? NShopAuftragsNr { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
