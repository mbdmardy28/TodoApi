using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Model;

namespace TodoApi.Data
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Task");

            builder.Property(s => s.Id)
                .ValueGeneratedOnAdd();

            builder.Property(s => s.Title)
                .IsRequired(true);
         
            builder.HasData
            (
                 new Task
                 {
                     Id = 1,
                     Title = "Create Task Database",
                     Description = "Prepare Demo Database",
                     Status = Enum.GetName(typeof(Status), 3) // 0 = New
                 },
                 new Task
                 {
                     Id = 2,
                     Title = "Create Demo App",
                     Description = "Prepare Demo App",
                    Status = Enum.GetName(typeof(Status),1) // 0 = New
                 },
                 new Task
                 {
                     Id = 3,
                     Title = "Test Demo App",
                     Description = "Conduct Regression Testing",
                     Status = Enum.GetName(typeof(Status),0) // 0 = New
                 },
                 new Task
                 {
                     Id = 4,
                     Title = "Create Task Database",
                     Description = "Prepare Demo Database",
                     Status = Enum.GetName(typeof(Status),0) // 0 = New
                 }
            );
        }
    }
}
