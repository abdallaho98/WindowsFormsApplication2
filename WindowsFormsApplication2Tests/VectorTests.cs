using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Tests
{
    [TestClass()]
    public class VectorTests
    {
        [TestMethod()]
        public void initiateTest()
        {
            string texte = " 4 5 6";
            Vector vec = new Vector();
            vec.initiate(texte);
            Assert.AreEqual(vec.ToString(), "4 5 6 ");
        }

        [TestMethod()]
        public void TriezVectorTest()
        {
            string texte = " 8 5 6 1";
            Vector vec = new Vector();
            vec.initiate(texte);
            vec.TriezVector();
            Assert.AreEqual(vec.ToString(), "8 6 5 1 ");
        }

        [TestMethod()]
        public void SommetTest()
        {
            Vector vec1 = new Vector();
            vec1.initiate("4 5 6");
            Vector vec2 = new Vector();
            vec2.initiate("0 6 1");
            Vector vec = vec1.Sommet(vec2);
            Assert.AreEqual(vec.ToString(), "4 11 7 ");
        }

        [TestMethod()]
        public void InverseTest()
        {
            Vector vec = new Vector();
            vec.initiate("4 7 8 6 5");
            vec.Inverse();
            Assert.AreEqual(vec.ToString(), "5 6 8 7 4 ");
        }

        [TestMethod()]
        public void ApplicationTest()
        {
            Vector vec = new Vector();
            vec.initiate("4 5 6");
            vec = vec.Application("*", 5);
            Assert.AreEqual(vec.ToString(), "20 25 30 ");
        }

        [TestMethod()]
        public void MaxTest()
        {
            Vector vec = new Vector();
            vec.initiate("5 8 6 9 4 111");
            Assert.AreEqual(vec.Max(), 111);
        }

        [TestMethod()]
        public void MinTest()
        {
            Vector v = new Vector();
            v.initiate("4 5 6 ");
            Assert.AreEqual(v.Min(),4);
        }
    }
}