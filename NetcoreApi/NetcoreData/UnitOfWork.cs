namespace NetcoreData;
public partial class UnitOfWork:IUnitOfWork
{
    public UnitOfWork()
    {

    }

    public async Task<int> CommitAsync()
    {
        
       return 0;
    }

    public async Task<int> CommitAsync(string token, string eventType, string entityName, object entity)
    {
      
        return 0;
    }

    public void Dispose()
    {
        this.Dispose();
    }

    public void RollBack()
    {
        // Holam mundo
    }

    

    public Task<int> CommitAync()
    {
        throw new NotImplementedException();
    }

    public Task<int> CommiAsync(string token, string eventType, string entityName, string entity)
    {
        throw new NotImplementedException();
    }
}

