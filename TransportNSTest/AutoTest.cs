using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportNS;

namespace TransportNSTest
{
    [TestClass]
    public class AutoTest
    {

        Auto AutoA = new Auto();
        Auto AutoB = new Auto();

        [TestMethod]
        public void Auto_NotNull_Test_TrueReturned()
        {
            Assert.IsNotNull(AutoA);
        }
    
        [TestMethod]
        public void Auto_AreEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Daewoo Matiz", 3.5, 1.5, 152.0, 8.2, 60000.0, "Мини");

            AutoA = auto1;
            AutoB = auto1;

            Assert.AreEqual(AutoA, AutoB);
        }

        [TestMethod]
        public void Auto_AreNotEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Daewoo Matiz", 3.5, 1.5, 152.0, 8.2, 60000.0, "Мини");
            Auto auto2 = new Auto("Daewoo Matiz", 3.5, 2.0, 152.0, 8.2, 60000.0, "Мини");

            AutoA = auto1;
            AutoB = auto2;

            Assert.AreNotEqual(AutoA, AutoB);
        }

        [TestMethod]
        public void Auto_Type_AreEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Peugeot 307 SW", 4.32, 1.76, 160.0, 9.0, 80000.0, "Малый");
            Auto auto2 = new Auto("Lada Kalina", 4.04, 1.7, 165.0, 9.7, 65000.0, "Малый");

            string varA = auto1.type;
            string varB = auto2.type;

            Assert.AreEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Type_AreNotEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Daewoo Matiz", 3.5, 1.5, 152.0, 8.2, 60000.0, "Мини");
            Auto auto2 = new Auto("Lada Kalina", 4.04, 1.7, 165.0, 9.7, 65000.0, "Малый");

            string varA = auto1.type;
            string varB = auto2.type;

            Assert.AreNotEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Name_AreEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Lada Kalina", 4.32, 1.76, 160.0, 9.0, 80000.0, "Малый");
            Auto auto2 = new Auto("Lada Kalina", 4.04, 1.7, 165.0, 9.7, 65000.0, "Малый");

            string varA = auto1.name;
            string varB = auto2.name;

            Assert.AreEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Name_AreNotEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Daewoo Matiz", 3.5, 1.5, 152.0, 8.2, 60000.0, "Мини");
            Auto auto2 = new Auto("Lada Kalina", 4.04, 1.7, 165.0, 9.7, 65000.0, "Малый");

            string varA = auto1.name;
            string varB = auto2.name;

            Assert.AreNotEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Length_AreEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Lada Kalina", 4.32, 1.76, 160.0, 9.0, 80000.0, "Малый");
            Auto auto2 = new Auto("Lada Kalina", 4.32, 1.7, 165.0, 9.7, 65000.0, "Малый");

            double varA = auto1.length;
            double varB = auto2.length;

            Assert.AreEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Length_AreNotEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Daewoo Matiz", 3.5, 1.5, 152.0, 8.2, 60000.0, "Мини");
            Auto auto2 = new Auto("Lada Kalina", 4.04, 1.7, 165.0, 9.7, 65000.0, "Малый");

            double varA = auto1.length;
            double varB = auto2.length;

            Assert.AreNotEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Width_AreEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Lada Kalina", 4.35, 1.7, 160.0, 9.0, 80000.0, "Малый");
            Auto auto2 = new Auto("Lada Kalina", 4.32, 1.7, 165.0, 9.7, 65000.0, "Малый");

            double varA = auto1.width;
            double varB = auto2.width;

            Assert.AreEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Width_AreNotEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Daewoo Matiz", 3.5, 1.5, 152.0, 8.2, 60000.0, "Мини");
            Auto auto2 = new Auto("Lada Kalina", 4.04, 1.7, 165.0, 9.7, 65000.0, "Малый");

            double varA = auto1.width;
            double varB = auto2.width;

            Assert.AreNotEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Speed_AreEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Lada Kalina", 4.32, 1.76, 160.0, 9.0, 80000.0, "Малый");
            Auto auto2 = new Auto("Lada Kalina", 4.32, 1.7, 160.0, 9.7, 65000.0, "Малый");

            double varA = auto1.speed;
            double varB = auto2.speed;

            Assert.AreEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Speed_AreNotEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Daewoo Matiz", 3.5, 1.5, 152.0, 8.2, 60000.0, "Мини");
            Auto auto2 = new Auto("Lada Kalina", 4.04, 1.7, 165.0, 9.7, 65000.0, "Малый");

            double varA = auto1.speed;
            double varB = auto2.speed;

            Assert.AreNotEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Expence_AreEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Lada Kalina", 4.32, 1.76, 160.0, 9.0, 80000.0, "Малый");
            Auto auto2 = new Auto("Lada Kalina", 4.32, 1.7, 165.0, 9.0, 65000.0, "Малый");

            double varA = auto1.expence;
            double varB = auto2.expence;

            Assert.AreEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Expence_AreNotEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Daewoo Matiz", 3.5, 1.5, 152.0, 8.2, 60000.0, "Мини");
            Auto auto2 = new Auto("Lada Kalina", 4.04, 1.7, 165.0, 9.7, 65000.0, "Малый");

            double varA = auto1.expence;
            double varB = auto2.expence;

            Assert.AreNotEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Cost_AreEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Lada Kalina", 4.32, 1.76, 160.0, 9.0, 80000.0, "Малый");
            Auto auto2 = new Auto("Lada Kalina", 4.32, 1.7, 165.0, 9.7, 80000.0, "Малый");

            double varA = auto1.cost;
            double varB = auto2.cost;

            Assert.AreEqual(varA, varB);
        }

        [TestMethod]
        public void Auto_Cost_AreNotEqual_Test_TrueReturned()
        {
            Auto auto1 = new Auto("Daewoo Matiz", 3.5, 1.5, 152.0, 8.2, 60000.0, "Мини");
            Auto auto2 = new Auto("Lada Kalina", 4.04, 1.7, 165.0, 9.7, 65000.0, "Малый");

            double varA = auto1.cost;
            double varB = auto2.cost;

            Assert.AreNotEqual(varA, varB);
        }
    }


}
