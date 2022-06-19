using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.ConsoleUı
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member{Email = "b203102022@gmail.com", FirstName = "Hande",LastName = "Derin",DateOfBirth = new DateTime(2001,6,27),TcNo = "34984051352" });
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
