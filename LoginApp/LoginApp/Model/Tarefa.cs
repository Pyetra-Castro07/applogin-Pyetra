using SQLite;

namespace LoginApp.Model
{
    class Tarefa
    {
        [PrimaryKey]
        public Guid Id { get; set; }
        public string Descritivo { get; set; }

        public Tarefa()
        {
            Id = Guid.NewGuid();
        }
    }
}
