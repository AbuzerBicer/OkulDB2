using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BransManager : BransService
    {
        IBransDal _bransDal;

        public BransManager(IBransDal bransDal)
        {
            _bransDal = bransDal;
        }

        public void Ekle(Brans entity)
        {
            _bransDal.Add(entity);
        }

        public void Guncelle(Brans entity)
        {
            _bransDal.Update(entity);
        }

        public List<Brans> HepsiniGetir()
        {
           return _bransDal.GetAll();
        }
    }
}
