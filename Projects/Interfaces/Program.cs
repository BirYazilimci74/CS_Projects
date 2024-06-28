using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerManager serverManager = new ServerManager();

            serverManager.Add(new SqlServerCodes());         // Fonksiyonların hangi server için olacağını tek seferde değiştirebilirim.
            serverManager.Update(new OracleServerCodes());
            serverManager.Close(new SqlServerCodes());
        }
    }

    class SqlServerCodes : IServerDal      // The sql codes are in here.
    {
        public void Add()
        {
            Console.WriteLine("SqlServer added");
        }

        public void Update()
        {
            Console.WriteLine("SqlServer updated");
        }

        public void Close()
        {
            Console.WriteLine("SqlServer closed");
        }
    }

    class OracleServerCodes : IServerDal   // The oracle codes are in here.
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }

        public void Close()
        {
            Console.WriteLine("Oracle closed");
        }        
    }

    interface IServerDal        // Dal = data access layer. This contains server functions.
    {
        void Add();
        void Update();
        void Close();
    }

    class ServerManager
    {
        public void Add(IServerDal serverDal)
        {
            serverDal.Add();
        }

        public void Update(IServerDal serverDal)
        {
            serverDal.Update();
        }

        public void Close(IServerDal serverDal)
        {
            serverDal.Close();
        }
    }
}