using System.Threading.Tasks;
using User_Management_System.Data;
using Microsoft.EntityFrameworkCore;

/*
 * Name: IUnitOfWork
 * Author: Namchok Singhachai
 * Description: The class for control all.
 */

namespace User_Management_System.Controllers
{
    public class UnitOfWork : IUnitOfWork
    {
        private AuthDbContext _context;
        public ILogsRepository Logs { get; private set; }
        public IAccountRepository Account { get; private set; }
        /*
         * Name: UnitOfWork
         * Parameter: context(AuthDbContext)
         * Author: Namchok Singhachai
         */
        public UnitOfWork(AuthDbContext context)
        {
            this._context = context;
            this.Logs = new LogsRepository(_context);
            this.Account = new AccountRepository(_context);
        } // End Constructor

        /*
         * Name: Commit
         * Author: Namchok Singhachai
         * Description: Saving changes.
         */
        public int Commit()
        {
            return this._context.SaveChanges();
        } // End commit

        /*
         * Name: CommitAsync
         * Author: Namchok Singhachai
         * Description: Saving changes.
         */
        public async Task<int> CommitAsync()
        {
            return await this._context.SaveChangesAsync();
        } // End CommitAsync

        /*
         * Name: Dispose
         * Author: Namchok Singhachai
         * Description: Discardation all operation.
         */
        public void Dispose()
        {
            this._context.Dispose();
        } // End Dispose

        /*
         * Name: DisposeAsync
         * Author: Namchok Singhachai
         * Description: Discardation all operation.
         */
        public async Task DisposeAsync()
        {
            await this._context.DisposeAsync();
        } // End DisposeAsync
    } // End UnitOfWork
}