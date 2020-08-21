using BillTracker.DataLayer;
using BillTracker.Entities;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BillTracker.BusinessLayer.Service.Repository
{
    public class BillRepository : IBillRepository
    {

        /// <summary>
        /// Creating Referance variable of TaskDBContext
        /// Injecting in TaskRepository constructor
        /// </summary>
        //private readonly InterviewTrackerDbContext _interviewDb;
        private readonly BillDBContext _billDBContext;
        public BillRepository(BillDBContext billDBContext)
        {
            _billDBContext = billDBContext;
        }

        /// <summary>
        /// InMemoryDb logic to retrieve all Bills present in db
        /// </summary>
        /// <returns></returns>

       

        public async Task<IEnumerable<BillDetails>> GetAllBillsAsync()
        {
            //business logic goes here
            try
            {
                var taskitem = await _billDBContext.billDetails.
               OrderByDescending(x => x.Amount).ToListAsync();
                return taskitem;
            }
            catch (Exception exception)
            {
                throw (exception);
            }
        }

        /// <summary>
        /// InMemoryDb logic to retrieve all Bills by DueDate present in db
        /// </summary>
        /// <returns></returns>
        public async Task<List<BillDetails>> GetAllBillsByDueDateAsync(DateTime dueDate)
        {
            try
            {
                var result = await _billDBContext.billDetails.Where(x => x.DueDate == dueDate).Take(10).ToListAsync();
              
              return result;
            }
            catch (Exception exception)
            {
                throw (exception);
            }
        }
        /// <summary>
        /// InMemoryDb logic to save bill in db
        /// </summary>
        /// <returns></returns>
        /// 

        public async Task<BillDetails> SaveBillAsync(BillDetails billdetails)
        {
            _billDBContext.billDetails.Add(billdetails);
            await _billDBContext.SaveChangesAsync();
            return billdetails;
        }

        Task<List<BillDetails>> IBillRepository.GetAllBillsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
