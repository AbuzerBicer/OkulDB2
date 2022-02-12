using Business.Concrete;
using DataAccess.Concrete.MySql;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GunManager gunManager = new GunManager(new MysqlGunDal());
            foreach (var gun in gunManager.HepsiniGetir())
            {
                Console.WriteLine(gun.GunAdi);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
