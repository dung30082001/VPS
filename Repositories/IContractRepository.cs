using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IContractRepository
    {
        List<Contract> GetContract();

        Contract GetContractById(int id);


        void UpdateContract(int id, Contract contract);

        void AddContract(Contract contract);

        void DeleteContract(int id);
    }
}
