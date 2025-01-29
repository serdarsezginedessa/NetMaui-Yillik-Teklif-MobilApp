

using SQLite;

namespace MauiApp5
{
    public class Data
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string? OkulAdi { get; set; }
        public string? Yetkili { get; set; }
        public string? OkulTuru { get; set; }
        public string? OkulTipi { get; set; }
        public string? Sehir { get; set; }
        public string? YapimSekli { get; set; }
        public string? KapakModeli { get; set; }
        public string? KapakSekli { get; set; }
        public string? KpkGvdRengi { get; set; }
        public string? KpkFtCrvRengi { get; set; }
        public string? KepRengi { get; set; }
        public string? KliseTuru { get; set; }
        public string? KpkEkleri { get; set; }
        public string? Sayfasablonu { get; set; }
        public string? CkmYeri { get; set; }
        public int YlkKulFtsay { get; set; }
        public string? KgtGr { get; set; }
        public int OgrSyfSay { get; set; }
        public int OgrSay { get; set; }
        public int KslFtSay { get; set; }
        public int EtkFtSay { get; set; }
        public int SyfSayisi { get; set; }
        public int MgzSyfSay { get; set; }
        public int SinifSayisi { get; set; }


    }
}
