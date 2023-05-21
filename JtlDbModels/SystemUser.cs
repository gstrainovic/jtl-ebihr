using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class SystemUser
{
    public int SystemUserId { get; set; }

    public string? SystemUserName { get; set; }

    public byte[]? LastChange { get; set; }
}
