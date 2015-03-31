using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DataAccess.Concrete.Interface
{
    public class IUnityOfWork
    {
        public T GetRepository<T>();
        public void SaveChanges();
    }
}
