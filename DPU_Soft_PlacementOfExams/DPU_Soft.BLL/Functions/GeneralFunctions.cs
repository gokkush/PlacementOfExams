using DPU_Soft.DAL.Base;
using DPU_Soft.DAL.Interfaces;
using DPU_Soft.PlacementOfExams.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;

namespace DPU_Soft.BLL.Functions
{
    public static class GeneralFunctions
    {
        public static List<string> DegisenAlanalariGetir<T>(this T oldEntity, T currentEntity)
        {
            List<string> alanlar = new List<string>();
            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity)??string.Empty;
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                if (prop.PropertyType==typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString())) oldValue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(currentValue.ToString())) currentValue = new byte[] { 0 };
                    if ((((byte[])oldValue).Length != (((byte[])currentValue).Length)))
                        {
                        alanlar.Add(prop.Name);
                        }                   
                }
                else if (!currentValue.Equals(oldValue))
                {
                    alanlar.Add(prop.Name);
                }
            }
            return alanlar;
        }
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["PlacementOfExamsContext"].ConnectionString;
        }

        private static TContext CreateContext<TContext>() where TContext : DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }

        public static void CreateUnitOfWork<T,TContext>(ref IUnitOfWork<T> uof) where T:class,IBaseEntity where TContext: DbContext
        {
            uof?.Dispose();
            uof = new UnitOfWork<T>(CreateContext<TContext>());
        }
    }
}
