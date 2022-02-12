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
    public class MysqlBransDal : IBransDal
    {
        DBContext dBContext;
        string connectionString = "Server=Localhost;Database=Okuldb;UID=root;PWD=Ab.287358";
        public MysqlBransDal()
        {
            dBContext = new DBContext(new MySqlConnection(), connectionString);
        }
        public void Add(Brans entity)
        {
            dBContext.Baglan(new MySqlCommand(), "insert into Branslar(BransAdi) values ('"+entity.BransAdi+"')");
            dBContext.ConnectionClose();
        }

        public void Delete(Brans entity)
        {
            dBContext.Baglan(new MySqlCommand(), "Delete From Branslar WHERE (BransID='" + entity.BransID + "'");
            dBContext.ConnectionClose();
        }

        public void Get(Brans entity)
        {
            throw new NotImplementedException();
        }

        public List<Brans> GetAll()
        {
            List<Brans> branss = new List<Brans>();
            DbDataReader dr = dBContext.Baglan(new MySqlCommand(), "Select * From Branslar");
            while (dr.Read())
            {
                Brans brans = new Brans();
                brans.BransID = Convert.ToByte(dr[0]);
                brans.BransAdi = dr[1].ToString();
                branss.Add(brans);
            }
            dBContext.ConnectionClose();
            return branss;
        }

        public void Update(Brans entity)
        {
            dBContext.Baglan(new MySqlCommand(), "Update Branslar Set BransAdi='"+entity.BransAdi+"' WHERE (BransID='" + entity.BransID + "')");
            dBContext.ConnectionClose();
        }
    }
}
