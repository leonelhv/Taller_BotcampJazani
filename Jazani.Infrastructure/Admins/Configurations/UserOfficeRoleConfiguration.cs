﻿using Jazani.Domain.Admins.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jazani.Infrastructure.Admins.Configurations
{
    public class UserOfficeRoleConfiguration
    {
        public class PeriocityConfiguration : IEntityTypeConfiguration<UserOfficeRole>
        {
            public void Configure(EntityTypeBuilder<UserOfficeRole> builder)
            {
                builder.ToTable("userofficerole", "adm");
                builder.HasKey(t => new { t.UserId, t.OfficeId, t.RoleId });
                builder.Property(t => t.UserId).HasColumnName("userid");
                builder.Property(t => t.OfficeId).HasColumnName("officeid");
                builder.Property(t => t.RoleId).HasColumnName("roleid");
                builder.Property(t => t.RegistrationDate).HasColumnName("registrationdate");
                builder.Property(t => t.State).HasColumnName("state");



                builder.HasOne(t => t.User)
                    .WithMany(m => m.UserOfficeRoles)
                    .HasForeignKey(t => t.UserId);

                builder.HasOne(t => t.Office)
                    .WithMany(m => m.UserOfficeRoles)
                    .HasForeignKey(t => t.OfficeId);

                builder.HasOne(t => t.Role)
                    .WithMany(m => m.UserOfficeRoles)
                    .HasForeignKey(t => t.RoleId);
            }
        }
    }
}
