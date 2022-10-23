namespace Assignment11_EFcore.Repositories;

public interface IDatabaseTransaction : IDisposable
{
    void Commit();
    void Rollback();
}