using System.Data;

public class Service : ICineStar
{
    CineDAO cineDAO = new CineDAO();
    PeliculaDAO peliculaDAO = new PeliculaDAO();

    public DataSet getCines()
    {
        return cineDAO.getCines();
    }

    public DataSet getCine(int id)
    {
        return cineDAO.getCine(id);
    }

    public DataSet getCinePeliculas(int id)
    {
        return cineDAO.getCinePeliculas(id);
    }

    public DataSet getCineTarifas(int id)
    {
        return cineDAO.getCineTarifas(id);
    }

    public DataSet getPelicula(int id)
    {
        return peliculaDAO.getPelicula(id);
    }

    public DataSet getPeliculas(int id)
    {
        return peliculaDAO.getPeliculas(id);
    }
}
