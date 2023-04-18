using System;
namespace NetcoreData
{
	public interface IUnitOfWork : IDisposable
	{
		Task<int> CommitAync();
		Task<int> CommiAsync(string token, string eventType, string entityName, string entity);
		void RollBack();
	}
}

