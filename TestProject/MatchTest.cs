using foot;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace TestProject
{
    
    
    /// <summary>
    ///Classe de test pour MatchTest, destinée à contenir tous
    ///les tests unitaires MatchTest
    ///</summary>
    [TestClass()]
    public class MatchTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur Match
        ///</summary>
        [TestMethod()]
        public void MatchConstructorTest()
        {
            Club away = new Club("FCB");
            Club home = new Club("RMCF");
            bool isForfeit = false; 
            Match target = new Match(away, home, isForfeit);
            
            Assert.AreEqual(home, target.Home);
            Assert.AreEqual(away, target.Away);
           
        }

        /// <summary>
        ///Test pour Constructeur Match
        ///</summary>
        [TestMethod()]
        public void MatchConstructorTest1()
        {
            
            Club away = new Club("fcb") ; 
            Club home = new Club("RMCF") ; 
            int awayGoals = 3; 
            int homeGoals = 0; 
            Match target = new Match(away, home, awayGoals, homeGoals);
            Assert.AreEqual(3,target.AwayGoals);
            Assert.AreEqual(0, target.HomeGoals);
            Assert.AreEqual(home, target.Home);
            Assert.AreEqual(away, target.Away);
        }

        /// <summary>
        ///Test pour isdraw
        ///</summary>
        [TestMethod()]
        public void isdrawTest()
        {
            Club away = new Club("FCB"); 
            Club home = new Club("AC Milan");
            int agoals = 3;
            int hgoals = 3; 
            Match target = new Match(away,home, agoals, hgoals); 
            bool actual;
            actual = target.isdraw();
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        ///Test pour Away
        ///</summary>
        [TestMethod()]
        public void AwayTest()
        {
            Club away = new Club("FC Barcelona");
            Club home = new Club("OM");
            int agoals = 5;
            int hgoals = 0;
            Match target = new Match(away, home, agoals, hgoals);
            Club actual;
            actual = target.Away;
            Assert.AreEqual(away, actual); 
        }

        /// <summary>
        ///Test pour AwayGoals
        ///</summary>
        [TestMethod()]
        public void AwayGoalsTest()
        {
            Club away = new Club("Raja Casablanca");
            Club home = new Club("Wydad Casablanca");
            int agoals = 5;
            int hgoals = 1;
            Match target = new Match(away, home, agoals, hgoals);
            int actual;
            actual = target.AwayGoals;
            Assert.AreEqual(agoals, actual);
        }

        /// <summary>
        ///Test pour Home
        ///</summary>
        [TestMethod()]
        public void HomeTest()
        {
            Club away = new Club("FC Barcelona");
            Club home = new Club("OM");
            int agoals = 5;
            int hgoals = 0;
            Match target = new Match(away, home, agoals, hgoals);
            Club actual;
            actual = target.Home;
            Assert.AreEqual(home, actual); 
        }

        /// <summary>
        ///Test pour HomeGoals
        ///</summary>
        [TestMethod()]
        public void HomeGoalsTest()
        {
            Club away = new Club("Raja Casablanca");
            Club home = new Club("Wydad Casablanca");
            int agoals = 5;
            int hgoals = 1;
            Match target = new Match(away, home, agoals, hgoals);
            int actual;
            actual = target.HomeGoals;
            Assert.AreEqual(hgoals, actual);
        }

        /// <summary>
        ///Test pour isawayForfeit
        ///</summary>
        [TestMethod()]
        public void isawayForfeitTest()
        {
            Club away = new Club("FC Barcelona");
            Club home = new Club("Real Madrid");
            bool isForfeit = false; 
            Match target = new Match(away, home, isForfeit); 
            bool actual;
            actual = target.isawayForfeit();
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///Test pour ishomeForfeit
        ///</summary>
        [TestMethod()]
        public void ishomeForfeitTest()
        {
            Club away = new Club("FC Barcelona");
            Club home = new Club("Real Madrid");
            bool forfeit = true;
            Match target = new Match(away, home, forfeit);
            bool actual;
            actual = target.isawayForfeit();
            Assert.IsFalse(actual);
               
           
        }
    }
}
