using System.Threading.Tasks;

namespace LordsExpense.Data;

public interface ILordsExpenseDbSchemaMigrator
{
    Task MigrateAsync();
}
