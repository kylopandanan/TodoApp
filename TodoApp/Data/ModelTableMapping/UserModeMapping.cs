using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data.ModelTableMapping
{
    public static class UserModeMapping
    {
        public static void UserModel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
               .ToTable("People")
               .Property("Name")
               .HasColumnName("First_Name")
               .HasColumnType("ntext");
        }
    }
}
