using UML_Diagramm;

namespace UML_Diagramm_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Assign
            Abteilung abteilung = new Abteilung();
            Angestellter angestellter1 = new Angestellter("Damian", 3000);
            Angestellter angestellter2 = new Angestellter("Manuel", 3000);
            Manager manager1 = new Manager("Frischknecht", 7000, 1000);
            //Act
            abteilung.AddToLohnKosten(manager1.GetGehalt(angestellter1.MonatsLohn));
            abteilung.AddToLohnKosten(manager1.GetGehalt(angestellter2.MonatsLohn));
            abteilung.AddToLohnKosten(manager1.GetGehalt(manager1.MonatsLohn));
            //Assert
            int Ausgabe = abteilung.LohnKosten;
            Assert.AreEqual(16000, Ausgabe);
        }
    }
}