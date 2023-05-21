using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Picture
{
    public int ObjectId { get; set; }

    public string ObjectType { get; set; } = null!;

    public byte[] PictureData { get; set; } = null!;

    public byte[] LastChange { get; set; } = null!;
}
