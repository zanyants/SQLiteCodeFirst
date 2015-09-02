
namespace SQLite.CodeFirst.Statement.ColumnConstraint
{
    internal class UniqueConstraint : IColumnConstraint
    {
        public int? MaxLength { get; set; }

        public string CreateStatement()
        {
            return "UNIQUE";
        }
    }
}
