namespace Chess.Test;

using ChessLibrary;

[TestFixture]
public class PlayerTest
{
    [Test]
    public void AddPlayer(){
        ChessPlayer player = new ChessPlayer();
        string name = "Name Test";
        int id = 123; 
        _ = player.SetName(name);
        _ = player.SetPlayerId(id);
        Assert.That(player.GetPlayerId(), Is.EqualTo(id));
        Assert.That(player.GetPlayerName(), Is.EqualTo(name));
    }
}