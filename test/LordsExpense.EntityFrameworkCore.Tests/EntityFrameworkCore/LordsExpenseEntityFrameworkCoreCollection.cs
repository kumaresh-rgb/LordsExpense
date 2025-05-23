using Xunit;

namespace LordsExpense.EntityFrameworkCore;

[CollectionDefinition(LordsExpenseTestConsts.CollectionDefinitionName)]
public class LordsExpenseEntityFrameworkCoreCollection : ICollectionFixture<LordsExpenseEntityFrameworkCoreFixture>
{

}
