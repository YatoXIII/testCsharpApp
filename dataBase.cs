using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ЦВД_тестовоеЗадание
{
    class dataBase
    {
        private string connectionString = "";
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = createConnectionString(value);
            }
        }

        private static OleDbConnection connection;

        public dataBase(string sourceString)
        {
            checkExistOrCreateFile(sourceString);

            ConnectionString = sourceString;

            if (connectionString != string.Empty)
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
            }
        }

        private void checkExistOrCreateFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("Не удалось найти файл базы данных с именем " + path + " в папке с приложением!");
            }
        }

        public bool containsTable(string tableName)
        {
            return connection.GetSchema("Tables").Select($"TABLE_NAME='{tableName}'").Count() > 0;
        }

        public void executeQuery(string query)
        {
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public OleDbDataReader executeQueryReader(string query)
        {
            OleDbCommand command = new OleDbCommand(query, connection); 
            return command.ExecuteReader();
        }

        private string createConnectionString(string sourceString)
        {
            DataTable table = new OleDbEnumerator().GetElements();

            foreach (DataRow row in table.Rows)
            {
                string rowValue = row["SOURCES_NAME"].ToString();
                if (rowValue == "Microsoft.Jet.OLEDB.4.0" || rowValue == "Microsoft.ACE.OLEDB.12.0") return $"Provider={rowValue};Data Source={sourceString};User Id=admin;Password=;";
            }

            throw new Exception("Не удалось создать подключение к базе данных! Не установлен провайдер \"Microsoft.Jet.OLEDB.4.0\" или \"Microsoft.ACE.OLEDB.12.0\"!");
        }

    }
}
