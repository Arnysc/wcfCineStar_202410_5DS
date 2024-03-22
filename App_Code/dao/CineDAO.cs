using System.Data;

public class CineDAO
{
    Db db = new Db("cnCineStar");

    internal DataSet getCines()
    {
        db.Sentencia("sp_getCines");
        return db.getDataSet();
    }
}