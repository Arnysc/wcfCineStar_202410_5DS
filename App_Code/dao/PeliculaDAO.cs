using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de PeliculaDAO
/// </summary>
public class PeliculaDAO
{
    Db db = new Db("cnCineStar");

    internal DataSet getPeliculas(int id)
    {
        db.Sentencia("sp_getPeliculas" + id);
        return db.getDataSet();
    }

    internal DataSet getPelicula(int id)
    {
        db.Sentencia("sp_getPelicula" + id);
        return db.getDataSet();
    }
}