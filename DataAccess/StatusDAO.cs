using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StatusDAO
    {
        public static List<Status> GetStatus()
        {
            var listStatus = new List<Status>();
            try
            {
                using (var context = new VPSContext())
                {
                    listStatus = context.Statuses.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listStatus;
        }
        public static Status GetStatusrById(int id)
        {
            var status = new Status();
            try
            {
                using (var context = new VPSContext())
                {
                    status = context.Statuses.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return status;
        }
        public static void UpdateStatus(int id, Status status)
        {
            Status current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Statuses.Find(id);
                    current.StatusName = status.StatusName;
                    context.Statuses.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddStatus(Status status)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.Statuses.Add(status);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteStatus(int id)
        {
            Status current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Statuses.Find(id);
                    context.Statuses.Remove(current);
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
