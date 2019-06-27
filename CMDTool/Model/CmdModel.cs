using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDTool.Model
{
    public class CmdModel
    {
        public string column { get; set; }
        public string connection { get; set; }
    }

    public struct Field
    {
        public string Name;
        public string Type;
    }

    public class DatabaseCommon
    {
        public static List<Field> GetFileds(string connectionString, string tableName)
        {
            List<Field> _Fields = new List<Field>();
            SqlConnection _Connection = new SqlConnection(connectionString);
            try
            {
                _Connection.Open();

                string[] restrictionValues = new string[4];
                restrictionValues[0] = null; // Catalog
                restrictionValues[1] = null; // Owner
                restrictionValues[2] = tableName; // Table
                restrictionValues[3] = null; // Column

                using (DataTable dt = _Connection.GetSchema(SqlClientMetaDataCollectionNames.Columns, restrictionValues))
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Field field;
                        field.Name = dr["column_name"].ToString();
                        field.Type = dr["data_type"].ToString();
                        _Fields.Add(field);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Connection.Dispose();
            }

            return _Fields;
        }
    }
}
