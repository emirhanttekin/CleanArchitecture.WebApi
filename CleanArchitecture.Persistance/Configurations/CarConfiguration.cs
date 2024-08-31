using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistance.Configurations;

//HER BİR ENTİTY İÇİN  AYRI BİR CONFİGURATİON AYARLARINI AYRI Bİ DOSYADA YAPABİLİRİZ   DBCONTEXTE DE YAPABİLİRİZ AMA HER BİR ENTTİY KENDİ KLASÖRÜ OLURSA  YÖNETMESİ DAHA KOLAY
public sealed class CarConfiguration : IEntityTypeConfiguration<Car>

{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars"); //Veritabanında gözükcek isim
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.Name);  //Indexleme yapıyorsun armaa yaptığında ciddi  artıları oluyor

    }
}
