using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Binaryfile
{
    public int Id { get; set; }

    public string? Filename { get; set; }

    public byte[]? Filebinary { get; set; }

    public DateTime? Createtime { get; set; }

    public DateTime? Changetime { get; set; }

    public string? Ownertype { get; set; }

    public string? Ownercode { get; set; }

    public long? Ownerid { get; set; }

    public string? Description { get; set; }

    public long? Size { get; set; }

    public long? Userid { get; set; }

    public string? Filehash { get; set; }
}
