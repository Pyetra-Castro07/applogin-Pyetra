using LoginApp.Model;
using SQLite;

namespace LoginApp.Data
{
    class TarefaData
    {
        private SQLiteAsyncConnection _conexaoDB;

        public TarefaData(SQLiteAsyncConnection conexaoDB)
        {
            _conexaoDB = conexaoDB;
        }
        public Task<Tarefa> ObtemIdTarefa(Guid id)
        {
            var tarefa = _conexaoDB
                .Table<Tarefa>()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return tarefa;
        }
        public async Task<int> SalvarUsuario(Tarefa tarefa)
        {
            var novaTarefa = await ObtemIdTarefa(tarefa.Id);

            if (novaTarefa == null)
            {
                return await _conexaoDB.InsertAsync(tarefa);
            }
            else
            {
                return await _conexaoDB.UpdateAsync(tarefa);
            }
        }
    }
}
