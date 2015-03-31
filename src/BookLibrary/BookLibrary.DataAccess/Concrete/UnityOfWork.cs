using BookLibrary.DataAccess.Concrete.Interface;
using BookLibrary.DataAccess.Repositories;
using BookLibrary.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DataAccess.Concrete
{
    public class UnityOfWork : IUnityOfWork
    {
        private BookLibraryDataContext context;
        private Dictionary<Type, object> repositorieDictionary;


        public UnityOfWork()
        {
            context = new BookLibraryDataContext();
            BookRepository bookRepository = new BookRepository(context);
            UserRepository userRepository = new UserRepository(context);
            BorrowRepository borrowRepository = new BorrowRepository(context);
            BookGenreRepository genreRepository = new BookGenreRepository(context);
            repositorieDictionary = new Dictionary<Type, object>();
            repositorieDictionary.Add(bookRepository.GetType(), bookRepository);
            repositorieDictionary.Add(userRepository.GetType(), userRepository);
            repositorieDictionary.Add(borrowRepository.GetType(), borrowRepository);
            repositorieDictionary.Add(genreRepository.GetType(), genreRepository);
        }

        public IRepository<T> GetRepository<T>()
        {
            var type = typeof(T);
            if (repositorieDictionary.ContainsKey(type))
            {
                return repositorieDictionary[type] as IRepository<T>;
            }

            return null;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
