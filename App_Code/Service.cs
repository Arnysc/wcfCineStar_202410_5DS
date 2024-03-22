using System.Data;

public class Service : ICineStar
{
    CineDAO cineDAO = new CineDAO();

    public DataSet getCines()
    {
        return cineDAO.getCines();
    }
}
