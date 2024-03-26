using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ICineStar
{

	[OperationContract]
	DataSet getCines();

    [OperationContract]
    DataSet getCine(int id);

    [OperationContract]
    DataSet getCinePeliculas(int id);

    [OperationContract]
    DataSet getCineTarifas(int id);

    [OperationContract]
    DataSet getPeliculas(int id);

    [OperationContract]
    DataSet getPelicula(int id);
}