using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GunManager :  GunService
    {
        IGunDal _gunDal;

        public GunManager(IGunDal gunDal)
        {
            _gunDal = gunDal;
        }

        public List<Gun> HepsiniGetir()
        {
            return _gunDal.GetAll();
        }
    }
}
