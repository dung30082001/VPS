using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TechnicalDAO
    {
        public static List<Technical> GetTechnical()
        {
            var listTechnical = new List<Technical>();
            try
            {
                using (var context = new VPSContext())
                {
                    listTechnical = context.Technicals.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listTechnical;
        }
        public static Technical GetTechnicalById(int id)
        {
            var technical = new Technical();
            try
            {
                using (var context = new VPSContext())
                {
                    technical = context.Technicals.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return technical;
        }
        public static void UpdateTechnical(int id, Technical technical)
        {
            Technical current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Technicals.Find(id);
                    current.FullName = technical.FullName;
                    current.Phone = technical.Phone;
                    current.Address = technical.Address;
                    current.Dob = technical.Dob;
                    current.Avatar = technical.Avatar;
                    current.StatusId = technical.StatusId;
                    context.Technicals.Update(technical);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddTechnical(Technical technical)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.Technicals.Add(technical);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteTechincal(int id)
        {
            Technical current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Technicals.Find(id);
                    context.Technicals.Remove(current);
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
