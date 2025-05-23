using LordsExpense.EntityFrameworkCore.Category;
using LordsExpense.EntityFrameworkCore.Transaction;
using LordsExpense.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

[ApiController]
[Route("api/Home")]
public class HomeService
{
    #region constraint
    private readonly IRepository<CategoryEntity> _categoryEntity;
    private readonly IRepository<TransactionEntity> _transactionEntity;
    private readonly ILogger<HomeService> _logger;
    #endregion


    #region constructor
    public HomeService(
    IRepository<CategoryEntity> categoryEntity,
    ILogger<HomeService> logger,
    IRepository<TransactionEntity> transactionEntity)
    {
        _categoryEntity = categoryEntity;
        _transactionEntity = transactionEntity;
        _logger = logger;
    }
    #endregion


    #region public method

    #region CreateOrUpdateInExp

    [HttpPost("create-or-update-transaction")]
    public async Task<CreateOrUpdateInExpDto> CreateOrUpdateInExp(CreateOrUpdateInExpDto input)
    {
        try
        {
            if (input.Id == Guid.Empty)
            {
                TransactionEntity newTransaction = new TransactionEntity
                {
                    USER_ID = input.UserId,
                    CATEGORY_ID = input.CategoryId,
                    TRNC_TITLE = input.Title,
                    TRNC_AMOUNT = input.Amount,
                    TRNC_TYPE = input.Type,
                    DATE_TIME = DateTime.Now
                };

                await _transactionEntity.InsertAsync(newTransaction);
                input.Id = newTransaction.Id;
            }
            else
            {
                TransactionEntity existing = await _transactionEntity.FirstOrDefaultAsync(t => t.Id == input.Id);
                if (existing != null)
                {
                    existing.CATEGORY_ID = input.CategoryId;
                    existing.TRNC_TITLE = input.Title;
                    existing.TRNC_AMOUNT = input.Amount;
                    existing.TRNC_TYPE = input.Type;
                    existing.DATE_TIME = DateTime.Now;

                    await _transactionEntity.UpdateAsync(existing);
                }
            }

            return input;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "CreateOrUpdateInExp - error occurred");
            throw;
        }
    }
    #endregion

    #region Delete
    [HttpDelete("delete-transaction")]
    public async Task<Guid> DeleteInExp(Guid delId)
    {
        try
        {
            TransactionEntity existing = await _transactionEntity.FirstOrDefaultAsync(t => t.Id == delId);
            if (existing != null)
            {
                await _transactionEntity.DeleteAsync(existing);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError("DeleteInExp - error Ocuur");
        }
        return delId;
    }
    #endregion

    [HttpDelete("delete-all-transaction")]
    public async Task<Guid> DeleteALLInExp(Guid delId)
    {
        try
        {
            List<TransactionEntity> existing = await _transactionEntity.GetListAsync(t => t.Id == delId);
            if (existing != null)
            {
                await _transactionEntity.DeleteManyAsync(existing);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError("DeleteAllInExp - error Ocuur");
        }
        return delId;
    }

    #region Get All Transactions
    [HttpGet("get-all-transactions")]
    public async Task<List<CreateOrUpdateInExpDto>> GetAllTransactionDetails()
    {
        try
        {
            List<TransactionEntity> transactions = await _transactionEntity.GetListAsync();

            List<CreateOrUpdateInExpDto> result = transactions.Select(t => new CreateOrUpdateInExpDto
            {
                Id = t.Id,
                UserId = t.USER_ID,
                CategoryId = t.CATEGORY_ID,
                Title = t.TRNC_TITLE,
                Amount = t.TRNC_AMOUNT,
                Type = t.TRNC_TYPE,
                DateTime = t.DATE_TIME
            }).ToList();

            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError($"GetAllTransactionDetails - error occurred: {ex.Message}");
            return new List<CreateOrUpdateInExpDto>();
        }
    }
    #endregion

    #endregion

    #region private method

    #endregion







}

