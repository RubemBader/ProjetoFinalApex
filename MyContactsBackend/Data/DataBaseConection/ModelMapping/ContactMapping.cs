using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.DataBaseConection.ModelMapping
{
    public class ContactMapping : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");

            builder.HasKey(Contact => Contact.Id);
            builder.Property(Contact => Contact.Id).ValueGeneratedOnAdd();

            builder.Property(Contact => Contact.Name).IsRequired();
            builder.Property(Contact => Contact.Phone).IsRequired();

            builder.HasOne(contact => contact.User)
                .WithMany(user => user.Contacts)
                .HasForeignKey(contact => contact.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
