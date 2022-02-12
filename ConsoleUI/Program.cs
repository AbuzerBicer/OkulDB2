using Business.Concrete;
using DataAccess.Concrete.MySql;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BransManager bransManager = new BransManager(new MysqlBransDal());
            Brans brans = new Brans();
            brans.BransID = 1;
            brans.BransAdi = "din";
            bransManager.Guncelle(brans);
            Console.WriteLine("Hello World!");
        }
    }
}
