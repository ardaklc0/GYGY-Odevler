using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class DataService
    {
        private readonly IDataAccess dataAccess;

        public DataService(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public void SaveData(string data)
        {
            dataAccess.SaveData(data);
        }

    }

    interface IDataAccess
    {
        void SaveData(string data);
    }

    public class SqlDataAccess : IDataAccess
    {
        public void SaveData(string data)
        {
            Console.WriteLine($"{data} SQL'e kaydedildi.");
        }
    }

    public class MongoDbDataAccess : IDataAccess
    {
        public void SaveData(string data)
        {
            Console.WriteLine($"{data} Mongo DB'ye kaydedildi.");
        }
    }

    public class LocalDataAccess : IDataAccess
    {
        public void SaveData(string data)
        {
            Console.WriteLine($"{data} C:// dizinine kaydedildi");
        }
    }
}
