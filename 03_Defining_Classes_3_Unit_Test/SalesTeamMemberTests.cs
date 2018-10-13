using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_3;

namespace _03_Defining_Classes_3_Unit_Test
{
    [TestClass]
    public class SalesTeamMemberTests
     {

        //[TestMethod]
        //public void TestMethod1()
        //{
        //}
        private SalesTeamMemberRepository _memberRepo;
        private SalesTeamMember _member1;
        private SalesTeamMember _member2;
        private SalesTeamMember _member3;
        private SalesTeamMember _member4;
        private SalesTeamMember _member5;


        [TestInitialize]
        public void Arrange()
        {
            _memberRepo = new SalesTeamMemberRepository();

            _member1 = new SalesTeamMember("Tucker", 250.25m);
            _member2 = new SalesTeamMember("Mullett", 600m);
            _member3 = new SalesTeamMember("Griswold", 1000m);
            _member4 = new SalesTeamMember("Wagner", 1000m);
            _member5 = new SalesTeamMember("Walker", 750m);

            _memberRepo.AddSalesMemberToTeam(_member1);
            _memberRepo.AddSalesMemberToTeam(_member2);
            _memberRepo.AddSalesMemberToTeam(_member3);
            _memberRepo.AddSalesMemberToTeam(_member4);
            _memberRepo.AddSalesMemberToTeam(_member5);
        }

        [TestMethod]
        public void STMRepo_GetTotalSales_IsCorrectDecimal()
        {
            //-- Act
            var expected = 3600.25m;
            var actual = _memberRepo.GetTotalSalesForTeam();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void STMRepo_GetLowestSales_IsCorrectDecimal()
        {
            //-- Act
            var expected = 250.25m;
            var actual = _memberRepo.GetLowestSalesNumber();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void STMRepo_GetHighestSales_IsCorrectDecimal()
        {
            //-- Act
            var expected = 1000m;
            var actual = _memberRepo.GetHighestSalesNumber();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void STMRepo_GetHighestSellingMembers_AreEqualLists()
        {
            //-- Act
            var expectedList = new List<SalesTeamMember>
            {
                _member3,
                _member4,
            };

            var expected = expectedList;
            var actual = _memberRepo.GetMembersWithHighestSales();

            //-- Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void STMRepo_GetLowestSellingMembers_AreEqualLists()
        {
            //-- Act
            var expectedList = new List<SalesTeamMember>
            {
                _member1
            };

            var expected = expectedList;
            var actual = _memberRepo.GetMembersWithLowestSales();

            //-- Assert
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
