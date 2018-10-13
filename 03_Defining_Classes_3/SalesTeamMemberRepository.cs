using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_3
{

    public class SalesTeamMemberRepository
    {
        //private List<SalesTeamMember> _salesTeamMembers;

        //public SalesTeamMemberRepository()
        //{
        //    _salesTeamMembers = new List<SalesTeamMember>();
        //}

        //public void AddSalesTeamMember(SalesTeamMember salesTeamMember)
        //{
        //    _salesTeamMembers.Add(salesTeamMember);

        //}

        //public decimal TotalSalesAllMembers()
        //{
        //    decimal totalSalesAmt = 0;

        //    foreach (var mem in _salesTeamMembers)
        //    {
        //        totalSalesAmt += mem.TotalSales;

        //    }

        //    return totalSalesAmt;

        //}

        //public decimal SalesTeamMemberFewest()
        //{
        //    List<decimal> fewestSales = new List<decimal>();


        //    foreach (var mem in _salesTeamMembers)
        //    {
        //       fewestSales.Add(mem.TotalSales);
        //    }

        //    return fewestSales.Min();
        //}
        private List<SalesTeamMember> _salesTeamMemberList;

        public SalesTeamMemberRepository()
        {
            _salesTeamMemberList = new List<SalesTeamMember>();
        }

        public List<SalesTeamMember> GetMemberList()
        {
            return _salesTeamMemberList;
        }

        public void AddSalesMemberToTeam(SalesTeamMember salesMember)
        {
            _salesTeamMemberList.Add(salesMember);
        }

        public decimal GetTotalSalesForTeam()
        {
            decimal totalSalesForTeam = 0;

            foreach (var s in _salesTeamMemberList)
            {
                totalSalesForTeam += s.MonthlySales;
            }

            return totalSalesForTeam;
        }

        public decimal GetLowestSalesNumber()
        {
            var lowest = _salesTeamMemberList.Min(s => s.MonthlySales);

            return lowest;
        }

        public List<SalesTeamMember> GetMembersWithLowestSales()
        {
            var lowestNum = GetLowestSalesNumber();

            //var members = _salesTeamMemberList.FindAll(x => x.MonthlySales == lowestNum);
            List<SalesTeamMember> members = new List<SalesTeamMember>();
            foreach (SalesTeamMember s in _salesTeamMemberList)
            {
                if (s.MonthlySales == lowestNum)
                    members.Add(s);
            }

            return members;
        }

        public decimal GetHighestSalesNumber()
        {
            var highest = _salesTeamMemberList.Max(s => s.MonthlySales);

            return highest;
        }

        public List<SalesTeamMember> GetMembersWithHighestSales()
        {
            var highestNum = GetHighestSalesNumber();

            var members = _salesTeamMemberList.FindAll(x => x.MonthlySales == highestNum);

            return members;
        }

    }



}
