using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ClassLibrary1
{
    public class GameFactory
    {
        StreamWriter sw;
        XmlSerializer serial;
        List<Game> gameList;
        const string GAMES_FILENAME = @"..\..\games.xml";

        public void CreateGameList()
        {
            gameList = new List<Game>();

            //Creating 6 games with 12 teams and populating their scores. Italian Serie A (Soccer)
            Game game;

            game = new Game("Bologna", 2, "Inter", 0);
            gameList.Add(game);

            game = new Game("Fiorentina", 1, "Napoli", 0);
            gameList.Add(game);

            game = new Game("Milan", 1, "Roma", 3);
            gameList.Add(game);

            game = new Game("Lazio", 0, "Sampdoria", 2);
            gameList.Add(game);

            game = new Game("Torino", 1, "Udinese", 1);
            gameList.Add(game);

            game = new Game("Atalanta", 2, "Bologna", 1);
            gameList.Add(game);


            serial = new XmlSerializer(gameList.GetType());
            sw = new StreamWriter(GAMES_FILENAME);
            serial.Serialize(sw, gameList);
            sw.Close();
        }

        public List<Game> ReadGameFactory(out string resultMessage)
        {
            try
            {
                gameList = new List<Game>();
                StreamReader sr = new StreamReader(GAMES_FILENAME);
                serial = new XmlSerializer(gameList.GetType());
                gameList = (List<Game>)serial.Deserialize(sr);
                sr.Close();
                resultMessage = "success";
                return gameList;
            }
            catch (Exception ex )
            {
                resultMessage = "Exception thrown: " + ex.Message;
                return null;
            }
        }
    }


}
