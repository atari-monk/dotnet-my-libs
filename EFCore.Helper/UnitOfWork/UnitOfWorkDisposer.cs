using Microsoft.EntityFrameworkCore;

namespace EFCore.Helper;

public abstract class UnitOfWorkDisposer
{
    protected readonly DbContext Context;

    public UnitOfWorkDisposer(DbContext context)
    {
        this.Context = context;
    }

	private bool disposed = false;

    public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			if (disposing)
			{
				Context.Dispose();
			}
		}
		disposed = true;
	}
}
