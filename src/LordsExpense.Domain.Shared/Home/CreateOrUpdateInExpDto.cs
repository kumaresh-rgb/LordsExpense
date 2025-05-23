using System;

using Volo.Abp.Application.Dtos;

namespace LordsExpense.Home
{
    public class CreateOrUpdateInExpDto : EntityDto<Guid>
    {
        public Guid UserId { get; set; }
        public string? UserName { get; set; } 
        public Guid CategoryId { get; set; }
        public string? CategoryName { get; set; } 
        public string? Title { get; set; }
        public decimal Amount { get; set; }
        public string? Type { get; set; }
        public DateTime DateTime { get; set; }
    }
}
