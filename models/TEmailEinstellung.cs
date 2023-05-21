using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TEmailEinstellung
{
    public int KEmailEinstellungen { get; set; }

    public int KFirma { get; set; }

    public string CServerSmtp { get; set; } = null!;

    public int NPortSmtp { get; set; }

    public string CNutzernameSmtp { get; set; } = null!;

    public string CPasswortSmtp { get; set; } = null!;

    public string? CAbsender { get; set; }

    public string? CBcc { get; set; }

    public int NSecurity { get; set; }

    public byte NSigPortalAktiv { get; set; }

    public string CSigPortalKdNummer { get; set; } = null!;

    public string CSigPortalNutzername { get; set; } = null!;

    public string CSigPortalPasswort { get; set; } = null!;

    public byte NSigPortalVerifizierung { get; set; }

    public string CSigPortalPfad { get; set; } = null!;

    public byte NSigBefehlAktiv { get; set; }

    public string CSigBefehlDateiname { get; set; } = null!;

    public string CSigBefehlParameter { get; set; } = null!;

    public byte NSmimeaktiv { get; set; }

    public string CSmimepasswort { get; set; } = null!;

    public byte[]? BSmimezertifikatData { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KOauthToken { get; set; }
}
