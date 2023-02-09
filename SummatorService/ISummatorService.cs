using System.ServiceModel;

namespace SummatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISummatorService" in both code and config file together.
    [ServiceContract]
    public interface ISummatorService
    {
        [OperationContract]
        int GetSum(int a, int b);
    }
}
