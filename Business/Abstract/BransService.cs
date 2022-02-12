using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface BransService
    {
        public void Ekle(Brans entity);
        public void Guncelle(Brans entity);
        public Brans Getir(byte ID);
        List<Brans> HepsiniGetir();
    }
}
