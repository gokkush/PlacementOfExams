using DPU_Soft.DAL.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Massage;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;


namespace DPU_Soft.DAL.Base
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        
        private readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            if (context == null) return;
            _context = context;
        }
        public IRepository<T> Rep
        {
            get
            {
                return new Repository<T>(_context);
            }
        }

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var sqlExp = (SqlException)ex.InnerException?.InnerException;
                if (sqlExp == null)
                {
                    Messages.HataMesaji(ex.Message);
                    return false;
                }
                switch (sqlExp.Number)
                {
                    case 208:
                        Messages.HataMesaji("İşlem Yapmak istediğiniz tablo veri tabanında bulunamadı.");
                        break;
                    case 547:
                        Messages.HataMesaji("Seçilen kaydın hareketleri var. Silme yapılamaz.");
                        break;
                    case 2601:

                    case 2627:
                        Messages.HataMesaji("Girmiş olduğunuz ID daha önce kullanılmıştır.");
                        break;
                    case 4060:
                        Messages.HataMesaji("İşlem yapmak istediğiniz Veri Tabanı Sunucuda bulunamadı.");
                        break;
                    case 18456:
                        Messages.HataMesaji("server için Kullanıcı adı veya Şifre Hatalıdır. ");
                        break;
                    default:
                        Messages.HataMesaji(sqlExp.Message);
                        break;
                }

            }

            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
                return false;
            }
            return true;
        }

        #region IDisposable Support
        private bool _disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

              
                _disposedValue = true;
            }
        }

     
        public void Dispose()
        {
           
            Dispose(true);
            GC.SuppressFinalize(this);
          
        }
        #endregion
    }
}
