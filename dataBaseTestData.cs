using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЦВД_тестовоеЗадание
{
    sealed class dataBaseTestData : dataBase
    {

        public dataBaseTestData(string sourceString) : base(sourceString)
        {
           
        }
        public void createTestData()
        {
            if (!tablesExists())
            {

                List<string> queryList = new List<string>
                {
                    "CREATE TABLE department (id int, name varchar(100))",
                    "CREATE TABLE employee (id int, department_id int, chief_id int, name varchar(100), salary int)"
                };

                Tuple<string, string[]>[] commandTupleArray = new Tuple<string, string[]>[]
                {
                    Tuple.Create("department(id, name)", new string[] {
                    "(1, \"D1\")",
                    "(2, \"D2\")",
                    "(3, \"D3\")"
                    }),
                    Tuple.Create("employee(id, department_id, chief_id, name, salary)", new string[] {
                    "(1, 1, 5, \"John\", 100)",
                    "(2, 1, 5, \"Misha\", 600)",
                    "(3, 2, 6, \"Eugen\", 300)",
                    "(4, 2, 6, \"Tolya\", 400)",
                    "(5, 3, 7, \"Stepan\", 500)",
                    "(6, 3, 7, \"Alex\", 1000)",
                    "(7, 3, NULL, \"Ivan\", 1100)"
                    })
                };

                foreach (Tuple<string, string[]> commandTuple in commandTupleArray)
                {
                    foreach (string valueString in commandTuple.Item2)
                        queryList.Add($"INSERT INTO {commandTuple.Item1} VALUES{valueString}");
                }

                foreach (string query in queryList)
                {
                    executeQuery(query);
                }

            }
        }
        public bool tablesExists()
        {
            return containsTable("department") && containsTable("employee");
        }
        

        public DataTable getDepSalaryData(bool addChiefNames)
        {
            DataTable tempTable = new DataTable();

            if (tablesExists())
            {
                createDefaultColumns(tempTable, true);

                string additionalFields = "";
                string additionalConditions = "";
                                
                if (addChiefNames)
                {
                    additionalConditions += "   LEFT JOIN employee as chief ON (employee.chief_id = chief.id)";
                    additionalFields     +=$",  {getCheckNullField("chief.name")} as chief_name";
                    tempTable.Columns.Add("chief_name", Type.GetType("System.String"));
                }

                OleDbDataReader reader = executeQueryReader(
                    " SELECT " +
                    getCheckNullField("department.name") + "as dep_name" + 
                    getDefaultColumnsQuery(true) +
                    additionalFields +
                    getDefaultJoinsQery() +
                    additionalConditions +
                    "GROUP BY " +
                    getCheckNullField("department.name") +
                    (addChiefNames ? ", " + getCheckNullField("chief.name") : "") +
                    " ORDER BY SUM(employee.salary) DESC "
                    );

                while (reader.Read())
                {
                    DataRow newRow = tempTable.NewRow();
                    fillDefaultColumns(newRow, reader, true);
                    if (addChiefNames) newRow["chief_name"] = reader["chief_name"].ToString();
                    tempTable.Rows.Add(newRow);
                }
                tempTable.AcceptChanges();
                reader.Close();
            }

            return tempTable;
        }

        public DataTable getMaxDepSalaryData()
        {
            DataTable tempTable = new DataTable();

            if (tablesExists())
            {
                createDefaultColumns(tempTable);

                // Создаем временную таблицу с данными по максимальной з/п
                executeQuery("SELECT employee.department_id, Max(employee.salary) AS maxSalary INTO tempMaxSalary FROM employee GROUP BY employee.department_id");
               
                // Получаем эти данные
                OleDbDataReader reader = executeQueryReader(
                    " SELECT " +
                    getCheckNullField("department.name") + " as dep_name " +
                    getDefaultColumnsQuery() +
                    getDefaultJoinsQery() +
                    " INNER JOIN tempMaxSalary ON (employee.department_id = tempMaxSalary.department_id AND employee.salary = tempMaxSalary.maxSalary) " +
                    " ORDER BY salary DESC "
                    );
                while (reader.Read())
                {
                    DataRow newRow = tempTable.NewRow();
                    fillDefaultColumns(newRow, reader);
                    tempTable.Rows.Add(newRow);
                }
                tempTable.AcceptChanges();
                reader.Close();

                // Удаляем временную таблицу
                executeQuery("DROP TABLE tempMaxSalary");
            }

            return tempTable;
        }

        public DataTable getChiefsSalaryData()
        {
            DataTable tempTable = new DataTable();

            if (tablesExists())
            {
                createDefaultColumns(tempTable);

                OleDbDataReader reader = executeQueryReader(
                    " SELECT " +
                    getCheckNullField("department.name") + " as dep_name " +
                    getDefaultColumnsQuery() +
                    getDefaultJoinsQery() +
                    " WHERE employee.id in (SELECT chief_id FROM employee) " +
                    " ORDER BY salary DESC ");
                while (reader.Read())
                {
                    DataRow newRow = tempTable.NewRow();
                    fillDefaultColumns(newRow, reader);
                    tempTable.Rows.Add(newRow);
                }
                tempTable.AcceptChanges();
                reader.Close();

            }

            return tempTable;
        }

        private void createDefaultColumns(DataTable table, bool onlyDep = false)
        {
            table.Columns.Add("dep_name", Type.GetType("System.String"));
            if (!onlyDep)
            {
                table.Columns.Add("name", Type.GetType("System.String"));
                table.Columns.Add("id", Type.GetType("System.Int32"));
            };
            table.Columns.Add("salary", Type.GetType("System.Int32"));
        }

        private void fillDefaultColumns(DataRow newRow, OleDbDataReader reader, bool onlyDep = false)
        {
            if (!onlyDep)
            {
                newRow["id"] = reader["id"].ToString();
                newRow["name"] = reader["name"].ToString();
            }
            newRow["dep_name"] = reader["dep_name"].ToString();
            newRow["salary"] = reader["salary"].ToString();
        }

        private string getDefaultColumnsQuery(bool onlyDep = false)
        {
            return  (onlyDep ? ", SUM(employee.salary) as salary " : ", employee.name as name, employee.id as id,   employee.salary as salary ");
        }

        private string getCheckNullField(string filedName)
        {
            return $"IIf(IsNull({filedName}),\"\",{filedName})";
        }

        private string getDefaultJoinsQery()
        {
            return  " FROM ( " +
                    " employee " +
                    " LEFT  JOIN department ON employee.department_id = department.id) ";
        }

    }
}
