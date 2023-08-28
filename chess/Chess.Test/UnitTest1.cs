namespace Chess.Test;
using ChessLibrary;
[TestFixture]
public class Tests
{
    GameController game;


    [SetUp]
    public void Setup()
    {
        game = new GameController();
    }

    [Test]
    public void Test1()
    {
        string a = game.Test();
    }
}