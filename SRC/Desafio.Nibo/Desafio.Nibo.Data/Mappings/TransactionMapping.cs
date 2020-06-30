using Desafio.Nibo.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.Nibo.Data.Mappings
{
    public class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Type)
                .IsRequired()
                .HasColumnType("char(1)");

            builder.Property(p => p.DatePosted)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.TransactionAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.Description)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("Transactions");
        }
    }
}
