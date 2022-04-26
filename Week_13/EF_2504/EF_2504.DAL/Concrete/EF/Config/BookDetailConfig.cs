using EF_2504.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EF_2504.DAL.Concrete.EF.Config
{
    public class BookDetailConfig : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(bd => bd.BookDetailId);
            builder.Property(bd => bd.BookDetailIsbn).HasDefaultValue("0000-0000-0000");
            builder.Property(bd => bd.BookDetailYear).HasDefaultValue(DateTime.Now.Year);

            builder
                //Bir kitabın bir datayı olacak.
                .HasOne(bd => bd.Book)
                .WithOne(b => b.BookDetail)
                .HasForeignKey<BookDetail>(bd => bd.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new BookDetail {BookDetailId=1, BookDetailCity="İstanbul", 
                BookId=1},
                new BookDetail {BookDetailId=2, BookDetailCity="Ankara",
                BookId=2},
                new BookDetail {BookDetailId=3, BookDetailCity="İzmir",
                BookId =3}
                );
        }
    }
}
