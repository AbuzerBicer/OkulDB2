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
            Console.WriteLine(bransManager.Getir(1).BransAdi);
            
            Console.WriteLine("Hello World!");
        }
    }
}
