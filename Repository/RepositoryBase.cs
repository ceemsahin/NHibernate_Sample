using NHibernate;
using NHibernate.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryBase<T> : ICrudRepository<T> where T : class
    {
        public RepositoryBase()
        {

        }

        public void Delete(T entities)
        {
            using (ISession _session = NHibernateSqlContext.SessionOpen())
            {
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                    try
                    {
                        _session.Delete(entities);
                        _transaction.Commit();

                    }
                    catch (Exception ex)
                    {

                        if (!_transaction.WasCommitted)
                        {
                            _transaction.Rollback();
                        }

                        throw new Exception("Delete Hatası : " + ex.Message);
                    }


                }

            }
        }

        public IList<T> GetAll()
        {
            using (ISession _session = NHibernateSqlContext.SessionOpen())
            {
                return _session.Query<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (ISession _session = NHibernateSqlContext.SessionOpen())
            {
                return _session.Get<T>(id);
            }
        }

        public void Insert(T entities)
        {
            using (ISession _session = NHibernateSqlContext.SessionOpen())
            {
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                    try
                    {
                        _session.Save(entities);
                        _transaction.Commit();

                    }
                    catch (Exception ex)
                    {

                        if (!_transaction.WasCommitted)
                        {
                            _transaction.Rollback();
                        }

                        throw new Exception("Insert Hatası : " + ex.Message);
                    }


                }

            }
        }

        public void Update(T entities)
        {
            using (ISession _session = NHibernateSqlContext.SessionOpen())
            {
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                    try
                    {
                        _session.Update(entities);
                        _transaction.Commit();

                    }
                    catch (Exception ex)
                    {

                        if (!_transaction.WasCommitted)
                        {
                            _transaction.Rollback();
                        }

                        throw new Exception("Update Hatası : " + ex.Message);
                    }


                }

            }
        }
    }
}
