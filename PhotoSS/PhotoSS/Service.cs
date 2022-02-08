using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using Nito.AsyncEx;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace PhotoSS
{
    public class Service
    {

        private bool isInitialized = false;
        private readonly AsyncLock initializationLock = new AsyncLock();

        private MobileServiceClient mClient;
        private IMobileServiceTable<People> mTable;
        //private IMobileServiceSyncTable<TodoItem> mTable;
        //private MobileServiceSQLiteStore mStore;
        private readonly IAppContext mContext;

        public Service(IAppContext context)
        {
            mContext = context;
            InitializeAsync().ConfigureAwait(false);
            //mClient = new MobileServiceClient(Constants.BackendUrl/*, new LoggingHandler()*/);
            //mTable = mClient.GetTable<People>();
            //IMobileServiceTable table = mClient.GetTable("People");
            //IMobileServiceTable<People> table = mClient.GetTable<People>();
        }

        private async Task InitializeAsync()
        {
            using (await initializationLock.LockAsync())
            {
                if (!isInitialized)
                {
                    mClient = new MobileServiceClient(Constants.BackendUrl/*, new LoggingHandler()*/);
                    mTable = mClient.GetTable<People>();
                    // mTable = mClient.GetSyncTable<TodoItem>();
                    List<People> items = await mTable.Where(p => p.Id == 5).ToListAsync();
                    isInitialized = true;

                    //// Create the client.
                    //mClient = new MobileServiceClient(Constants.BackendUrl, new LoggingHandler());

                    //// Define the offline store.
                    //mStore = new MobileServiceSQLiteStore("todoitems.db");
                    //mStore.DefineTable<TodoItem>();
                    //await mClient.SyncContext.InitializeAsync(mStore).ConfigureAwait(false);

                    //// Get a reference to the table.
                    //mTable = mClient.GetSyncTable<TodoItem>();
                    //isInitialized = true;
                }
            }
        }
    }
}
