using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Assignment11_EFcore.Repositories;

public class EntityDatabaseTransaction : IDatabaseTransaction
{
    private readonly IDbContextTransaction  _transaction;

    public EntityDatabaseTransaction(DbContext context)
    {
        _transaction = context.Database.BeginTransaction();
    }

    public void Commit()
    {
        _transaction.Commit();
    }

    public void Rollback()
    {
        _transaction.Rollback();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}