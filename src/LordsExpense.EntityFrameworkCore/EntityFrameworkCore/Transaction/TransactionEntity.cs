using LordsExpense.EntityFrameworkCore.Category;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace LordsExpense.EntityFrameworkCore.Transaction
{
    [Table("TRASAC")]
    public class TransactionEntity : FullAuditedEntity<Guid>
    {
        public virtual IdentityUser? UserId { get; set; }
        public Guid USER_ID { get; set; }
        public virtual CategoryEntity? Category { get; set; }
        public Guid CATEGORY_ID { get; set; }
        public string? TRNC_TITLE { get; set; }
        public decimal TRNC_AMOUNT { get; set; }
        public string? TRNC_TYPE { get; set; }
        public DateTime DATE_TIME { get; set; }
    }

}
