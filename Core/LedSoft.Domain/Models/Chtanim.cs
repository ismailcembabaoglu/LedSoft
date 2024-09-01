using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Chtanim
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Tip { get; set; }

    public string? Dovizcinsi { get; set; }

    public bool? Aktif { get; set; }

    public int? Subeid { get; set; }

    public virtual ICollection<Carihareket> CarihareketChes { get; set; } = new List<Carihareket>();

    public virtual ICollection<Carihareket> CarihareketChid2Navigations { get; set; } = new List<Carihareket>();

    public virtual ICollection<Cek> CekChes { get; set; } = new List<Cek>();

    public virtual ICollection<Cek> CekPortfoys { get; set; } = new List<Cek>();

    public virtual ICollection<Ceksenetbordro> Ceksenetbordros { get; set; } = new List<Ceksenetbordro>();

    public virtual ICollection<Senet> SenetChes { get; set; } = new List<Senet>();

    public virtual ICollection<Senet> SenetPortfoys { get; set; } = new List<Senet>();
}
