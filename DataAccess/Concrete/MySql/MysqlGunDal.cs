using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DataAccess.Concrete.MySql
{
    public class MysqlGunDal : IGunDal
    {
        DBContext dBContext;
        string connectionString = "Server=Localhost;Database=Okuldb;UID=root;PWD=Ab.287358";
        public MysqlGunDal()
        {
            dBContext = new DBContext(new MySqlConnection(), connectionString);
        }
        public void Add(Gun entity)
        {
        
        }

        public void Delete(Gun entity)
        {
            throw new NotImplementedException();
        }

        public void Get(Gun entity)
        {
            throw new NotImplementedException();
        }

        public List<Gun> GetAll()
        {
            List<Gun> guns = new List<Gun>();
            DbDataReader dr= dBContext.Baglan(new MySqlCommand(), "Select * From Gunler");
            while (dr.Read())
            {
                Gun gun = new Gun();
                gun.GunID = Convert.ToByte(dr[0]);
                gun.GunAdi = dr[1].ToString();
                guns.Add(gun);
            }
            dBContext.ConnectionClose();
            return guns;
        }

        public void Update(Gun entity)
        {
            throw new NotImplementedException();
        }
    }
}
