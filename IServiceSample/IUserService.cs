using Models;
using System.Collections.Generic;

namespace IServiceSample
{
    public interface IUserService
    {

        void USerAdd(User userModel);
        IList<User> GetUsers();

    }
}
