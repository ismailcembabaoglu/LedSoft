using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Sevkiyateleman
{
    public long Id { get; set; }

    public string? Tckn { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public bool? Aktif { get; set; }

    public string? Plaka { get; set; }

    public long? TasiyiciChid { get; set; }

    public string? TasiyiciVkn { get; set; }

    public string? TasiyiciUnvan { get; set; }

    public string? Gsm { get; set; }
}
