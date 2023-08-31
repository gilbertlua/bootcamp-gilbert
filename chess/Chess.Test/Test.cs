namespace Chess.Test;

using System.Text;
using ChessLibrary;

[TestFixture]
public class PlayerTest
{
    // [Test]
    public void AddPlayer(){
        ChessPlayer player = new ChessPlayer();
        string name = "Name Test";
        int id = 123; 
        _ = player.SetName(name);
        _ = player.SetPlayerId(id);
        Assert.That(player.GetPlayerId(), Is.EqualTo(id));
        Assert.That(player.GetPlayerName(), Is.EqualTo(name));
    }
    
    public void AddPiece(){
        PieceColor color = PieceColor.black;
        Piece piece = new Pawn(color);
        Assert.That(piece.GetColor, Is.EqualTo(color));
        Assert.That(piece.GetSymbol, Is.EqualTo("P"));
        Assert.That(piece.GetName, Is.EqualTo("Pawn"));
    }
    // [Test]
    public void ViewBoards(){
        Board board = new Board();
        board.GenerateBoard();
        StringBuilder _board = board.GetBoard();
        Console.WriteLine(_board);
    }

    [Test]
    public void CreatePiece(){
        CreateInitPiece? ip = new CreateInitPiece();
        Board board= new Board();
        board.SetPiece(ip.CreatePiece("Queen",PieceColor.white),new Spot(7,7));
        board.GenerateBoard();
        StringBuilder _board = board.GetBoard();
        Console.WriteLine(_board);
    }
}