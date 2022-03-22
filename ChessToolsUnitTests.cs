using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessTools;
using System.Collections.Generic;

namespace ChessToolsTests
{
    [TestClass]
    public class ReaderTests
    {
        [TestMethod]
        public void TestPerformQuery3()
        {
            System.DateTime start = new System.DateTime(1998, 04, 30);
            System.DateTime end = new System.DateTime(2019, 09, 11);
            PGNReader.PerformQuery("Draskovic, Luka", "", "1.e4", "", true, start, end, true);

            //I added a comment


        }

        [TestMethod]
        public void TestUploadGame3()
        {
            PGNReader.UploadGamesToDatabase("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb3.pgn");
            //PGNReader.UploadGamesToDatabase("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb2.pgn");
            //PGNReader.UploadGamesToDatabase("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb1.pgn");

        }
        [TestMethod]
        public void TestUploadGames2()
        {
            //PGNReader.UploadGamesToDatabase("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb3.pgn");
            PGNReader.UploadGamesToDatabase("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb2.pgn");
            //PGNReader.UploadGamesToDatabase("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb1.pgn");

        }
        [TestMethod]
        public void TestUploadGames1()
        {
            //PGNReader.UploadGamesToDatabase("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb3.pgn");
            //PGNReader.UploadGamesToDatabase("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb2.pgn");
            PGNReader.UploadGamesToDatabase("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb1.pgn");

        }

        [TestMethod]
        public void TestCorrectNumOfGamesKB1()
        {
            List<ChessGame> games = PGNReader.ReadFile("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb1.pgn");
            Assert.AreEqual(games.Count, 975);
        }
        [TestMethod]
        public void TestCorrectNumOfGamesKB2()
        {
            List<ChessGame> games = PGNReader.ReadFile("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb2.pgn");
            Assert.AreEqual(games.Count, 1005);
        }
        [TestMethod]
        public void TestCorrectNumOfGamesKB3()
        {
            List<ChessGame> games = PGNReader.ReadFile("/Users/camillevanginkel/Projects/ChessBrowser/ChessBrowser/ChessToolsTest/kb3.pgn");
            Assert.AreEqual(games.Count, 1019);
        }

        
    }


}