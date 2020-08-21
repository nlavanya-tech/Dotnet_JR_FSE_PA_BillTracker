using BillTracker.DataLayer;
using BillTracker.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BillTracker.BusinessLayer.Service.Repository
{
    public class UserRepository : IUserRepository
    {

        /// <summary>
        /// Creating Referance variable of TaskDBContext
        /// Injecting in TaskRepository constructor
        /// </summary>
        //private readonly InterviewTrackerDbContext _interviewDb;
        private readonly BillDBContext _billDBContext;
        public UserRepository(BillDBContext billDBContext)
        {
            _billDBContext = billDBContext;
        }



        /// <summary>
        /// Register New User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> RegisterNewUser(User user)
        {
            _billDBContext.users.Add(user);
            var result = await _billDBContext.SaveChangesAsync();
            return user;
        }
        /// <summary>
        /// Verify user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<User> VerifyUser(UserLogin user)
        {
            //Business Logic here
            throw new NotImplementedException();
        }

       
    }
}