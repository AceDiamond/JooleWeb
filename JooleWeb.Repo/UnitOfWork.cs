using System;
using System.Data.Entity;

namespace JooleWeb.Repo
{
    public class UnitOfWork:IDisposable
    {
        DbContext context;
        public ICategory category;
        public IChair chair;
        public IConsumer consumer;
        public ICustomer customer;
        public IHomeTheater theater;
        public IProduct product;
        public ISubCategory subCategory;
        public ITable table;
        public ITV tv;
        public IUSersRepo user;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
            category = new CategoryRepo(context);
            chair = new ChairRepo(context);
            consumer = new ConsumerRepo(context);
            customer = new CustomerRepo(context);
            theater = new HomeTheaterRepo(context);
            product = new ProductRepo(context);
            subCategory = new SubCategoryRepo(context);
            table = new TableRepo(context);
            tv = new TVRepo(context);
            user = new UserRepo(context);

        }

        public void SaveChanges()
        {
            context.SaveChanges();

        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}

