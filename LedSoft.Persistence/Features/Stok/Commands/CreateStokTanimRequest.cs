using LedSoft.Application.DTOs;
using LedSoft.Application.ResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.Stok.Commands
{
    public class CreateStokTanimRequest :IRequest<ServiceResponse<StokTanimDTO>>
    {
        public long Id { get; set; }

        /// <summary>
        /// Stok Kartı Kodu
        /// </summary>
        public string? Kod { get; set; }

        /// <summary>
        /// Stok Kartı İsmi
        /// </summary>
        public string? Isim { get; set; }

        public int? Tip { get; set; }

        public string? Aciklama { get; set; }

        public decimal? Kdvyuzde { get; set; }

        public string? Kisaisim { get; set; }

        public long? Birimid { get; set; }

        public byte[]? Resim { get; set; }

        public bool? Aktif { get; set; }

        public string? Ozelkod1 { get; set; }

        public string? Ozelkod2 { get; set; }

        public string? Ozelkod3 { get; set; }

        public string? Ozelkod4 { get; set; }

        public string? Ozelkod5 { get; set; }

        public string? MuhasebeAliskod { get; set; }

        public string? MuhasebeSatiskod { get; set; }

        public string? MuhasebeIndirilenkdv { get; set; }

        public string? MuhasebeSatiskdv { get; set; }

        public string? MuhasebeAlisiade { get; set; }

        public string? MuhasebeSatisiade { get; set; }

        public string? MuhasebeKod1 { get; set; }

        public string? MuhasebeKod2 { get; set; }

        public decimal? Fiyat1 { get; set; }

        public decimal? Fiyat2 { get; set; }

        public decimal? Fiyat3 { get; set; }

        public decimal? Fiyat4 { get; set; }

        public decimal? Fiyat5 { get; set; }

        public decimal? Fiyatalis { get; set; }

        public decimal? Fiyatperakende { get; set; }

        public decimal? Iskonto1 { get; set; }

        public decimal? Iskonto2 { get; set; }

        public decimal? Iskonto3 { get; set; }

        public bool? BirimgramajVar { get; set; }

        public decimal? Birimgramaj { get; set; }

        public int? Birimgramajbirim { get; set; }

        public bool? BirimbrutgramajVar { get; set; }

        public decimal? Birimbrutgramaj { get; set; }

        public int? Birimbrutgramajbirim { get; set; }

        public bool? BirimuzunlukVar { get; set; }

        public decimal? Birimuzunluk { get; set; }

        public int? Birimuzunlukbirim { get; set; }

        public bool? BirimalanVar { get; set; }

        public decimal? Birimalan { get; set; }

        public int? Birimalanbirim { get; set; }

        public bool? BirimhacimVar { get; set; }

        public decimal? Birimhacim { get; set; }

        public int? Birimhacimbirim { get; set; }

        public bool? BirimsivihacimVar { get; set; }

        public decimal? Birimsivihacim { get; set; }

        public int? Birimsivihacimbirim { get; set; }

        public bool? BirimeknitelikVar { get; set; }

        public decimal? Birimeknitelikcarpan { get; set; }

        public decimal? Birimeknitelikbolen { get; set; }

        public string? Birimeknitelikbirim { get; set; }

        public decimal? Kdvyuzde2 { get; set; }

        public decimal? Kdvyuzde3 { get; set; }

        public decimal? Otvyuzde { get; set; }

        public decimal? Tevkifatyuzde { get; set; }

        public bool? Ozelmatrahvar { get; set; }

        public decimal? Ozelmatrahfiyat { get; set; }

        public string? Entegrasyonkod { get; set; }

        public string? Programkod { get; set; }

        public int? Vadekullaniliyor { get; set; }

        public decimal? Minfiyat { get; set; }

        public decimal? Minisk1 { get; set; }

        public decimal? Minisk2 { get; set; }

        public decimal? Minisk3 { get; set; }

        public decimal? Maxfiyat { get; set; }

        public decimal? Maxisk1 { get; set; }

        public decimal? Maxisk2 { get; set; }

        public decimal? Maxisk3 { get; set; }

        public int? Urunlistesira { get; set; }

        public decimal? Kritikstok { get; set; }

        public decimal? Maxstok { get; set; }

        public bool? Anastokvar { get; set; }

        public long? Anastokid { get; set; }

        public bool? Varyasyonvar { get; set; }

        public bool? Ambalajvar { get; set; }

        public bool? Partinovar { get; set; }

        public bool? Serinovar { get; set; }

        public string? Dovizcinsi { get; set; }

        public bool? Stokvadekullaniliyor { get; set; }

        public int? Stokvadetip { get; set; }

        public int? Stokvadegun { get; set; }

        public bool? Otvkullaniliyor { get; set; }

        public int? Kategori1id { get; set; }

        public int? Kategori2id { get; set; }

        public int? Kategori3id { get; set; }

        public int? Kategori4id { get; set; }

        public int? Kategori5id { get; set; }

        public byte[]? Resim2 { get; set; }

        public byte[]? Resim3 { get; set; }

        public byte[]? Resim4 { get; set; }

        public decimal? Perakendekdvyuzde { get; set; }

        public bool? PerakendeKullan { get; set; }

        public bool? PerakendeUrunlisteGoster { get; set; }

        public string? PerakendeUrunlisteGrup { get; set; }

        public int? PerakendeUrunlisteSira { get; set; }

        public int? PerakendePluno { get; set; }

        public bool? PerakendeOzelkdv { get; set; }

        public decimal? PerakendeKdvyuzde1 { get; set; }

        public decimal? PerakendeUrunlisteTerazikullan { get; set; }

        public decimal? PerakendeMaxiskonto { get; set; }

        public bool? PerakendeTerazigonder { get; set; }

        public long? BirimidF1 { get; set; }

        public long? BirimidF2 { get; set; }

        public long? BirimidU1 { get; set; }

        public long? BirimidU2 { get; set; }

        public long? BirimidS1 { get; set; }

        public long? BirimidS2 { get; set; }

        public long? Receteid { get; set; }

        public long? BirimidFiyatliste { get; set; }

        public long? BirimidDepohar { get; set; }

        public string? MuhasebeIskontokod { get; set; }

        public decimal? PerakendeHedefkarmarji { get; set; }

        public int? Kategori6id { get; set; }

        public int? Kategori7id { get; set; }

        public int? Kategori8id { get; set; }

        public int? Kategori9id { get; set; }

        public int? Kategori10id { get; set; }

        public string? Uruntip { get; set; }

        public long? PerakendeDepartmanid { get; set; }

        public string? MuhasebeYurtdisialiskod { get; set; }

        public string? MuhasebeYurtdisisatiskod { get; set; }

        public string? MuhasebeYurtdisiindirilenkdv { get; set; }

        public string? MuhasebeYurtdisisatiskdv { get; set; }

        public int? PerakendeSonkullanmagun { get; set; }

        public long? LedmuhAlishesapid { get; set; }

        public long? LedmuhSatishesapid { get; set; }

        public long? LedmuhIndirilenkdvhesapid { get; set; }

        public long? LedmuhSatiskdvhesapid { get; set; }

        public long? LedmuhAlisiadehesapid { get; set; }

        public long? LedmuhSatisiadehesapid { get; set; }

        public long? LedmuhSatisiadekdvhesapid { get; set; }

        public long? LedmuhAlisiadekdvhesapid { get; set; }

        public long? LedmuhYurtdisialishesapid { get; set; }

        public long? LedmuhYurtdisisatishesapid { get; set; }

        public long? LedmuhYurtdisiindirilenkdvhesapid { get; set; }

        public long? LedmuhYurtdisisatiskdvhesapid { get; set; }

        public long? Kategoriagacid { get; set; }

        public string? MuhasebeSatisfiyatfarki { get; set; }

        public string? MuhasebeSatisfiyatfarkikdv { get; set; }

        public string? MuhasebeAlisfiyatfarki { get; set; }

        public string? MuhasebeAlisfiyatfarkikdv { get; set; }

        public long? LedmuhSatisfiyatfarkihesapid { get; set; }

        public long? LedmuhSatisfiyatfarkikdvhesapid { get; set; }

        public long? LedmuhAlisfiyatfarkihesapid { get; set; }

        public long? LedmuhAlisfiyatfarkikdvhesapid { get; set; }

        public string? PerakendeVeresiyeiskontotip { get; set; }

        public decimal? PerakendeVeresiyeiskonto { get; set; }

        public bool? PerakendesiparisKullan { get; set; }

        public string? Mensei { get; set; }

        public string? Gtipno { get; set; }

        public string? MuhasebeIhracatsatiskod { get; set; }

        public string? MuhasebeIthalataliskod { get; set; }

        public string? MuhasebeIthalataliskdv { get; set; }

        public long? LedmuhIhracatsatishesapid { get; set; }

        public long? Rafomru { get; set; }

        public long? LedmuhDigerkdvhesapid { get; set; }

        public string? MuhasebePerakendekdv { get; set; }

        public byte[]? PerakendeUrunlisteGorsel { get; set; }

        public string? MuhasebePerakendekod { get; set; }

        public string? EfaturaStokisim { get; set; }

        public string? Sktkullaniliyor { get; set; }

        public string? Serinokullaniliyor { get; set; }

        public string? MuhasebeTevkifatkdv { get; set; }

        public long? LedmuhTevkifatkdvhesapid { get; set; }

        public long? Recetesablonid { get; set; }

        public decimal? Recetesabloncarpan { get; set; }

        public int? Sktgun { get; set; }

        public string? Icindekiler { get; set; }

        public long? Depozitostokid { get; set; }

        public bool? PerakendeB2ckullan { get; set; }

        public long? Projeid { get; set; }

        public string? MuhasebeStopajkod { get; set; }
    }
}
