using LordsExpense.EntityFrameworkCore.Transaction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace LordsExpense.EntityFrameworkCore.Category
{
    [Table("CATGRY")]
    public class CategoryEntity : FullAuditedEntity<Guid>
    {
        public virtual IdentityUser? UserId { get; set; }
        public Guid USER_ID { get; set; }
        public virtual CategoryEntity? Parent { get; set; }
        public Guid? PARENT_ID { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<CategoryEntity>? ChildrenEntity { get; set; }
        public virtual ICollection<TransactionEntity>? TransactionEntity { get; set; }
    }
}
