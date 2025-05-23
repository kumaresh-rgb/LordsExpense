using LordsExpense.Samples;
using Xunit;

namespace LordsExpense.EntityFrameworkCore.Applications;

[Collection(LordsExpenseTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<LordsExpenseEntityFrameworkCoreTestModule>
{

}
