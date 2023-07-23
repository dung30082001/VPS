using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ContractRepository : IContractRepository
    {
        public void AddContract(Contract contract)
        {
            ContractDAO.AddContract(contract);
        }

        public void DeleteContract(int id)
        {
            ContractDAO.DeleteContract(id);
        }

        public List<Contract> GetContract()
        {
            return ContractDAO.GetContract();
        }

        public Contract GetContractById(int id)
        {
            return ContractDAO.GetContractById(id);
        }

        public void UpdateContract(int id, Contract contract)
        {
            ContractDAO.UpdateContract(id,contract);
        }
    }
}
