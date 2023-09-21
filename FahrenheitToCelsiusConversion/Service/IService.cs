using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FahrenheitToCelsiusConversion
{
    // IService - контракт службы Service.svc, Namespace просто для уникальной идентификации
    [ServiceContract(Namespace = "http://fahrenheittocelsiusconversion.azurewebsites.net/")]
    public interface IService
    {
        // Отмечаем, что метод можно вызвать удалённо через службу
        [OperationContract]
        double FahrenheitToCelsius(double farenheitDegrees);

        [OperationContract]
        double CelsiusToFahrenheit(double celsiusDegrees);
    }
}
