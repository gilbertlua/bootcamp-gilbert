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

    // [Test]
    public void CreatePiece(){
        CreateInitPiece? ip = new CreateInitPiece();
        Board board= new Board();
        board.SetPiece(ip.CreatePiece("Queen",PieceColor.white),new Spot(7,7));
        board.GenerateBoard();
        StringBuilder _board = board.GetBoard();
        Console.WriteLine(_board);
    }
    // [Test]
    public void MoveTest(){
        CreateInitPiece? ip = new CreateInitPiece();
        StringBuilder sb;
        Board board= new Board();
        board.SetPiece(ip.CreatePiece("Queen",PieceColor.white),new Spot(6,7));
        
        
        board.GenerateBoard();
        sb = board.GetBoard();
        Console.WriteLine(sb);
        Console.Write("\n\n");

        Spot start_spot = new Spot(6,7);
        Spot end_spot = new Spot(7,9);
        Move move = new Move(start_spot,end_spot);
        board.MovePiece(move);
        
        board.GenerateBoard();
        sb = board.GetBoard();
        Console.WriteLine(sb);
    }

// move validate test
    // [Test]
    public void ValidMoveTest(){
        StringBuilder sb;
        Board board= Board.GetTheBoard();
        
        CreateInitPiece? ip = new CreateInitPiece();
        board.SetPiece(ip.CreatePiece("Bishop",PieceColor.white),new Spot(4,7));
        
        board.GenerateBoard();
        sb = board.GetBoard();
        Console.WriteLine(sb);
        


        Spot start_spot = new Spot(7,2);
        Spot end_spot = new Spot(2,5);
        Move move = new Move(start_spot,end_spot);

        Piece piece = board.GetPiece(start_spot);
        board.IsSpotEmpty(start_spot);
        Console.WriteLine(piece.GetName());
        // Console.WriteLine("Piece name\t: "+piece.GetName());
        // Console.WriteLine("Piece color\t: "+piece.GetColor());

        Console.WriteLine("is valid ? :"+ piece.IsMovedValid(move));
        // 
    }   

    [Test]
    public void ValidateSingleMove(){
        CreateInitPiece? ip = new CreateInitPiece();
        Board board= Board.GetTheBoard();
        StringBuilder sb = new StringBuilder();


        board.SetPiece(ip.CreatePiece("Bishop",PieceColor.white),new Spot(7,7));
        Spot spot = new Spot(7,7);
        Move move = new Move(spot, new Spot(6,6));
        
        
        Piece piece = board.GetPiece(new Spot(7,7));
        board.GenerateBoard();
        sb = board.GetBoard();
        Console.WriteLine(sb);

        piece.IsMovedValid(move);
        // board.IsSpotEmpty(move.GetStartSpot());


    }
}