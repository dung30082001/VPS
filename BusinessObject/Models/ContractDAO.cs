using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class ContractDAO
    {
        public static List<Contract> GetContract()
        {
            var listContract = new List<Contract>();
            try
            {
                using (var context = new VPSContext())
                {
                    listContract = context.Contracts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listContract;
        }
        public static Contract GetContractById(int id)
        {
            var contract = new Contract();
            try
            {
                using (var context = new VPSContext())
                {
                    contract = context.Contracts.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return contract;
        }
        public static void UpdateContract(int id, Contract contract)
        {
            Contract current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Contracts.Find(id);
                    current.TechnicalId = contract.TechnicalId;
                    current.SupplierId = contract.SupplierId;
                    current.Content = contract.Content;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddContract(Contract contract)
        {
            Contract current;
            try
            {
                using (var context = new VPSContext())
                {
                    context.Contracts.Add(contract);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteContract(int id)
        {
            Contract current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Contracts.Find(id);
                    context.Contracts.Remove(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
