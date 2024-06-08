using CleanCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application
{
    public class CompanyService
    {
        public List<Company> GetCompanies()
        {
            var companies = new List<Company>()
            {
                new Company() { Name="Acme", HourlyPrice=150},
                new Company() { Name = "Abc", HourlyPrice = 125 }
            };
            return companies;

        }
    }
}
