using kliens_alkalmazas;

namespace TestProject2
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    [TestClass]
    public class AlapTeszt
    {
        [TestMethod]
        public void OsszeadasTeszt()
        {
            int eredmeny = 2 + 3;
            Assert.AreEqual(5, eredmeny);
        }
    }



    [TestClass]
    public class TermekTeszt
    {


        [TestMethod]
        public void LegdragabbKeszleten_HelyesTermeketAdVissza()
        {

            var termekek = new List<Termek>
            {
                new Termek { Név = "Cipő", Raktáron = 5, BeszerzésiÁr = 1000 },
                new Termek { Név = "Tutu", Raktáron = 0, BeszerzésiÁr = 9999 },
                new Termek { Név = "Harisnya", Raktáron = 10, BeszerzésiÁr = 1500 }
            };


            var legdragabb = TermekHelper.LegdragabbKeszleten(termekek);


            Assert.IsNotNull(legdragabb);
            Assert.AreEqual("Harisnya", legdragabb.Név);
        }



        [TestMethod]
        public void RiportFormazas_TartalmazTermekadatokat()
        {

            var termekek = new List<Termek>
            {
                new Termek { Név = "Tütü", Raktáron = 3, BeszerzésiÁr = 2999 }
            };


            string riport = RiportFormatter.FormazottRiport(termekek);


            Assert.IsTrue(riport.Contains("Tütü"));
            Assert.IsTrue(riport.Contains("3"));
            Assert.IsTrue(riport.Contains("2999"));
        }

        [TestMethod]
        public void Kereses_TalalTermeket_HelyesSzures()
        {
            var termekek = new List<Termek>
    {
        new Termek { Név = "Spicc cipő" },
        new Termek { Név = "Tütü" },
        new Termek { Név = "Lábmelegítő" }
    };

            var eredmeny = TermekKeresesHelper.Kereses(termekek, "cipő");

            Assert.AreEqual(1, eredmeny.Count);
            Assert.AreEqual("Spicc cipő", eredmeny[0].Név);
        }



        [TestMethod]
        public void LegolcsobbKeszleten_HelyesTermeketAdVissza()
        {
            var termekek = new List<Termek>
    {
        new Termek { Név = "Balettcipő", Raktáron = 2, BeszerzésiÁr = 4500 },
        new Termek { Név = "Harisnya", Raktáron = 1, BeszerzésiÁr = 1990 },
        new Termek { Név = "Tütü", Raktáron = 0, BeszerzésiÁr = 5000 }
    };

            var legolcsobb = TermekHelper.LegolcsobbKeszleten(termekek);

            Assert.IsNotNull(legolcsobb);
            Assert.AreEqual("Harisnya", legolcsobb.Név);
        }

        [TestMethod]
        public void Kereses_NemErzekenyNagybeture()
        {
            var termekek = new List<Termek>
    {
        new Termek { Név = "Piruett Szoknya" }
    };

            var eredmeny = TermekKeresesHelper.Kereses(termekek, "SZOKNYA");

            Assert.AreEqual(1, eredmeny.Count);
            Assert.AreEqual("Piruett Szoknya", eredmeny[0].Név);
        }

        [TestMethod]
        public void RiportFormazas_TartalmazDatumot()
        {
            var termekek = new List<Termek>
    {
        new Termek { Név = "Gyakorló mez", Raktáron = 2, BeszerzésiÁr = 3990 }
    };

            string riport = RiportFormatter.FormazottRiport(termekek);
            string maiNap = DateTime.Now.ToString("yyyy.MM.dd");

            Assert.IsTrue(riport.Contains(maiNap));
        }




    }
}
