using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ConsultantDAO
    {
        public static List<Consultant> GetConsultant()
        {
            var listConsultant = new List<Consultant>();
            try
            {
                using (var context = new VPSContext())
                {
                    listConsultant = context.Consultants.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listConsultant;
        }
        public static Consultant GetConsultantById(int id)
        {
            var consultant = new Consultant();
            try
            {
                using (var context = new VPSContext())
                {
                    consultant = context.Consultants.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return consultant;
        }
        public static void UpdateConsultant(int id, Consultant consultant)
        {
            Consultant current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Consultants.Find(id);
                    current.FullName = consultant.FullName;
                    current.Phone = consultant.Phone;
                    current.Address = consultant.Address;
                    current.Dob = consultant.Dob;
                    current.StatusId = consultant.StatusId;
                    context.Consultants.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddConsultant(Consultant consultant)
        {
            Consultant current;
            try
            {
                using (var context = new VPSContext())
                {
                    context.Consultants.Add(consultant);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteConsultant(int id)
        {
            Consultant current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Consultants.Find(id);
                    context.Consultants.Remove(current);
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
