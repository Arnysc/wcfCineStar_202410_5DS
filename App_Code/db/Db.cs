using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public class Db
{
    SqlConnection cn = null;
    SqlCommand cmd = null;
    SqlDataAdapter adapter = null;

    public Db(string cnn)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings[ cnn ].ConnectionString);
        cmd = new SqlCommand("", cn);
        adapter = new SqlDataAdapter(cmd);
    }

    internal void Sentencia(string sql)
    {
        cmd.CommandText = sql;
        cmd.Parameters.Clear();
    }

    internal DataSet getDataSet()
    {
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        return ds;
    }


}