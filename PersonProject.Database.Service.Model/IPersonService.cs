using System.Collections.Generic;
using System.ServiceModel;

namespace PersonProject.Database.Service.Model
{
    [ServiceContract(Name = "personService", Namespace = Constants.Namespace)]
    public interface IPersonService
    {
        [OperationContract(Name="getAll")]
        IEnumerable<Person> GetAll();

        [OperationContract(Name = "getById")]
        Person GetById(long id);
    }
}
