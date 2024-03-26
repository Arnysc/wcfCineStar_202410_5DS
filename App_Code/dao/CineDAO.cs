using System;
using System.Data;

public class CineDAO
{
    Db db = new Db("cnCineStar");

    internal DataSet getCines()
    {
        db.Sentencia("sp_getCines");
        return db.getDataSet();
    }

    internal DataSet getCine(int id)
    {
        db.Sentencia("sp_getCine" + id);
        return db.getDataSet();
    }

    internal DataSet getCinePeliculas(int id) 
    {
        db.Sentencia("sp_getCinePeliculas" + id);
        return db.getDataSet();
    }

    internal DataSet getCineTarifas(int id)
    {
        db.Sentencia("sp_getCineTarifas" + id);
        return db.getDataSet() ;
    }
}