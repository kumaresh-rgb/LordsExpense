using LordsExpense.Samples;
using Xunit;

namespace LordsExpense.EntityFrameworkCore.Domains;

[Collection(LordsExpenseTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<LordsExpenseEntityFrameworkCoreTestModule>
{

}
