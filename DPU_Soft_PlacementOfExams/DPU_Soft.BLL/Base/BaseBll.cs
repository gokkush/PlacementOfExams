using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.BLL.Functions;
using DPU_Soft.DAL.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Common.Functions;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace DPU_Soft.BLL.Base
{
    public class BaseBll<T,TContext>:IBaseBll where T:BaseEntity where TContext: DbContext
    {
        private readonly Control _ctrl;

        private IUnitOfWork<T> _unitOfWork;
        protected BaseBll()
        {


        }

        protected BaseBll(Control ctrl)
        {
            _ctrl = ctrl;
        }

        protected TResult Basesingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Select(filter, selector);
        }

        protected bool BaseInsert(BaseEntity entity, Expression<Func<T,bool>>filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            //Validation işlemleri yap
            _unitOfWork.Rep.Insert(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            //Validation işlemleri yap
            var degisenAlanlar = oldEntity.DegisenAlanalariGetir(currentEntity);
            if (degisenAlanlar.Count == 0) return true;
            
            _unitOfWork.Rep.Update(currentEntity.EntityConvert<T>(), degisenAlanlar);
            return _unitOfWork.Save();
        }

        protected bool BaseDelete(BaseEntity entity, KartTuru kartTuru ,bool mesajVer=true)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            //Validation işlemleri yap

            if (mesajVer)
                if (Messages.SilMesaj(kartTuru.ToName()) != DialogResult.Yes) return false;


            _unitOfWork.Rep.Delete(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        #region IDisposable Support
 
        public void Dispose()
        {
            _ctrl?.Dispose();
            _unitOfWork?.Dispose();           

        }
        #endregion

    }
}
