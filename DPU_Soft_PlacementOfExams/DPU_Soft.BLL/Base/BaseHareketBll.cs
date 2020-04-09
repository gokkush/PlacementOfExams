using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.BLL.Functions;
using DPU_Soft.DAL.Interfaces;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DPU_Soft.BLL.Base
{
    public class BaseHareketBll<T, TContext> : IBaseBll, IBasehareketGenelBll where T : BaseHareketEntity where TContext : DbContext
    {

        private IUnitOfWork<T> _uow;

        protected TResult Basesingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Find(filter, selector);
        }

        protected TResult Single<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> List<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);
        }

        public virtual bool InsertSingle(BaseHareketEntity entity)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);

            _uow.Rep.Insert(entity.EntityConvert<T>());
            return _uow.Save();
        }

        public virtual bool Insert(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);

            _uow.Rep.Insert(entities.EntityListConvert<T>());
            return _uow.Save();
        }

        public virtual bool Update(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);

            _uow.Rep.Update(entities.EntityListConvert<T>());
            return _uow.Save();
        }

        public bool Delete(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);

            _uow.Rep.Delete(entities.EntityListConvert<T>());
            return _uow.Save();
        }


        public void Dispose()
        {
            _uow?.Dispose();
        }
    }
}

