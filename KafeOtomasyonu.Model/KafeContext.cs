namespace KafeOtomasyonu.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KafeContext : DbContext
    {
        public KafeContext()
            : base("name=KafeContext")
        {
        }

        public virtual DbSet<Adisyon> Adisyon { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Masa> Masa { get; set; }
        public virtual DbSet<MasaTip> MasaTip { get; set; }
        public virtual DbSet<MiktarTur> MiktarTur { get; set; }
        public virtual DbSet<OdemeTip> OdemeTip { get; set; }
        public virtual DbSet<Siparis> Siparis { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adisyon>()
                .Property(e => e.adisyonID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Adisyon>()
                .Property(e => e.masaID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Adisyon>()
                .Property(e => e.kullaniciID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Adisyon>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Adisyon>()
                .Property(e => e.odemetipID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Adisyon>()
                .HasMany(e => e.Siparis)
                .WithRequired(e => e.Adisyon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kategori>()
                .Property(e => e.kategoriID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Kategori>()
                .Property(e => e.ustKategoriID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Kategori>()
                .Property(e => e.icerik)
                .IsUnicode(false);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.Urun)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.kullaniciID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.adi)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.soyadi)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.eposta)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.sifre)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.yetki)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.kullaniciTC)
                .HasPrecision(11, 0);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.adres)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.cepTel)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Adisyon)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Masa>()
                .Property(e => e.masaID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Masa>()
                .Property(e => e.masaTipID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Masa>()
                .HasMany(e => e.Adisyon)
                .WithRequired(e => e.Masa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MasaTip>()
                .Property(e => e.masaTipID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<MasaTip>()
                .Property(e => e.resim)
                .IsUnicode(false);

            modelBuilder.Entity<MasaTip>()
                .HasMany(e => e.Masa)
                .WithRequired(e => e.MasaTip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MiktarTur>()
                .Property(e => e.miktarTurID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<MiktarTur>()
                .HasMany(e => e.Siparis)
                .WithRequired(e => e.MiktarTur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OdemeTip>()
                .Property(e => e.odemeTipID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<OdemeTip>()
                .HasMany(e => e.Adisyon)
                .WithRequired(e => e.OdemeTip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Siparis>()
                .Property(e => e.siparisID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Siparis>()
                .Property(e => e.adisyonID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Siparis>()
                .Property(e => e.urunID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Siparis>()
                .Property(e => e.miktarTurID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Urun>()
                .Property(e => e.urunID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Urun>()
                .Property(e => e.kategoriID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Urun>()
                .Property(e => e.adi)
                .IsUnicode(false);

            modelBuilder.Entity<Urun>()
                .Property(e => e.fiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.Siparis)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);
        }
    }
}
