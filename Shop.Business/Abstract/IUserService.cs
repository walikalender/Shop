using Shop.Core_.Utilities.Results;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Abstract
{
    public interface IUserService
    {
        // Tüm kullanıcıları getirir.
        IDataResult<List<User>> GetAllUsers();

        // Belirli bir kullanıcı ID'sine göre kullanıcıyı getirir.
        IDataResult<User> GetUserById(int userId);

        // Yeni bir kullanıcı ekler.
        IResult AddUser(User user);

        // Mevcut bir kullanıcıyı günceller.
        IResult UpdateUser(User user);

        // Belirli bir kullanıcı ID'sine göre kullanıcıyı siler.
        IResult DeleteUser(int userId);
    }
}
