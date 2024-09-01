using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wsubeayar
{
    public long Kasaid { get; set; }

    public long? Subeid { get; set; }

    public string? Ipadres { get; set; }

    public string? Kasakod { get; set; }

    public string? Kasaisim { get; set; }

    public string? Subekod { get; set; }

    public string? Subeisim { get; set; }

    public string? Terazitip { get; set; }

    public string? Terazicomport { get; set; }

    public string? Teraziserbestmiktar { get; set; }

    public string? Bilgiekrancomport { get; set; }

    public string? Hariciterazitip { get; set; }

    public string? Sabitfisyazici { get; set; }

    public string? Sabitfaturayazici { get; set; }

    public bool Tahsilatkullan { get; set; }

    public bool Gunsonukullan { get; set; }

    public bool Dogrudanalimkullan { get; set; }

    public string? Satiskullanimtip { get; set; }

    public long? FrxFiscikti { get; set; }

    public long? FrxBeklemefiscikti { get; set; }

    public long? FrxSipariscikti { get; set; }

    public long? FrxCekmececikti { get; set; }

    public long? FrxOturumsonucikti { get; set; }

    public long? FrxMalkabulcikti { get; set; }

    public long? FrxVeresiyetahsilatfiscikti { get; set; }

    public long? FrxVeresiyeekstrecikti { get; set; }

    public long? FrxFaturacikti { get; set; }

    public long? FrxTahsilatcikti { get; set; }

    public bool? TahsilatciktiText { get; set; }

    public bool? FaturaciktiText { get; set; }

    public long? DllPerakendemodul { get; set; }

    public long? GorselLogo { get; set; }

    public long? GorselMusteriekran { get; set; }

    public bool? MusteriekranKullan { get; set; }

    public string? MusteriekranVideolink { get; set; }

    public bool? MusteriekranVideolinkAyri { get; set; }

    public long? FrxFaturaciktiEfatura { get; set; }

    public long? FrxFaturaciktiEarsivfatura { get; set; }

    public string? HashFrxFiscikti { get; set; }

    public string? HashFrxBeklemefiscikti { get; set; }

    public string? HashFrxSipariscikti { get; set; }

    public string? HashFrxCekmececikti { get; set; }

    public string? HashFrxOturumsonucikti { get; set; }

    public string? HashFrxMalkabulcikti { get; set; }

    public string? HashFrxVeresiyetahsilatfiscikti { get; set; }

    public string? HashFrxVeresiyeekstrecikti { get; set; }

    public string? HashFrxFaturacikti { get; set; }

    public string? HashFrxTahsilatcikti { get; set; }

    public string? HashDllPerakendemodul { get; set; }

    public string? HashGorselLogo { get; set; }

    public string? HashGorselMusteriekran { get; set; }

    public string? HashFrxFaturaciktiEfatura { get; set; }

    public string? HashFrxFaturaciktiEarsivfatura { get; set; }

    public string? VeresiyeKredilimitasimi { get; set; }

    public string? VeresiyeMusteriara { get; set; }

    public string? VeresiyeAciklamavar { get; set; }

    public string? VeresiyeMusteribaglisubedecalisir { get; set; }

    public string? FaturaCaribakiyegoster { get; set; }

    public string? FaturaKdvdahil { get; set; }

    public string? SiparisStokfiyatgoster { get; set; }

    public string? MalkabulStokfiyatgoster { get; set; }

    public string? SubetransferStokfiyatgoster { get; set; }

    public string? SayimStokfiyatgoster { get; set; }

    public string? VeresiyeIskontoyuzde { get; set; }

    public string? VeresiyeSatisfisiyazdirilsin { get; set; }

    public string? VeresiyeTahsilatgoster { get; set; }

    public string? SatisTutardegistirme { get; set; }

    public string? Barkodokumasesi { get; set; }

    public string? Varyasyonkullan { get; set; }

    public string? SayimSatisfisyukle { get; set; }

    public string? SevkiyatSatisfisyukle { get; set; }

    public string? SatisMaxkusurat { get; set; }

    public string? SatisBarkoddaarama { get; set; }

    public string? Favkullan { get; set; }

    public string? Oncekifislercalismasekli { get; set; }

    public string? SatisPossorulsun { get; set; }

    public string? SatisSatisdanismancalismasekli { get; set; }

    public string? SatisUrunlisteButtonboyut { get; set; }

    public string? Firmaunvan { get; set; }

    public bool Faturakullan { get; set; }

    public bool Irsaliyekullan { get; set; }

    public bool Masahesapkullan { get; set; }

    public string Bagliyazarkasa { get; set; } = null!;

    public string Baglicekmece { get; set; } = null!;

    public string Baglicekmeceport { get; set; } = null!;

    public string? Fisbekletkullan { get; set; }

    public bool? Yazarkasagiderpusulasikullan { get; set; }

    public bool? Yazarkasafaturakullan { get; set; }

    public bool? B2ckullan { get; set; }
}
