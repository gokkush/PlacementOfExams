using System;

namespace DPU_Soft.DAL.Interfaces
{
    public interface IUnitOfWork<T>:IDisposable where T:class
    {
        IRepository<T> Rep { get; }
        bool Save();
        
    }
}
