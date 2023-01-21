using IServiceSample;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSample
{



    public class UserService : IUserService
    {
        private readonly RepositoryBase<User> _repository = new RepositoryBase<User>();

        public IList<User> GetUsers()
        {
            return _repository.GetAll();
        }

        public void USerAdd(User userModel)
        {
            _repository.Insert(userModel);
        }
    }
}
