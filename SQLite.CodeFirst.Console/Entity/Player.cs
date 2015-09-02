using System.ComponentModel.DataAnnotations.Schema;
using SQLite.CodeFirst.Attributes;

namespace SQLite.CodeFirst.Console.Entity
{
    [Table("TeamPlayer")]
    public class Player : Person
    {
        [Index] // Automatically named 'IX_TeamPlayer_Number
        [Unique]
        public int Number { get; set; }

        public virtual Team Team { get; set; }
    }
}