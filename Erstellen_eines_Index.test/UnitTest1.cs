namespace Erstellen_eines_Index.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DefinitionsListe_PrintLists_correct()
        {
            //Assign
            DefinitionsListe defList = new DefinitionsListe();

            //Act
            defList.CreateLists();
            string defListString = defList.PrintLists();

            // Assert
            Assert.AreEqual("Blume: Blatt, Stiel, Blüte, Grün\nBaum: Stamm, Ast, Blüte, Grün, Blatt\nPilz: Hut, Farbe, Stiel\n", defListString);
        }
    }
}