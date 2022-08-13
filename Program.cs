using GamerSystemProject.Abstract;
using GamerSystemProject.Adapter;
using GamerSystemProject.Concrete;
using GamerSystemProject.Entities;

using System;

namespace GamerSystemProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseGamersManager baseGamers = new BaseGamersManager();
            baseGamers.Save(new Entities.Gamers{ NationalyId = "1234567901", FirstName = "Muhammed Tayyib", LastName = "ŞAHİN", DateOfBirth = new DateTime(1997, 9, 14) });                                     
        }
    }
}