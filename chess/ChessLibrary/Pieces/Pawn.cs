namespace ChessLibrary{
    public class Pawn:Piece{
        
        //constructor 
        public Pawn(PieceColor color){
            SetName("Pawn");
            SetSymbol("P");
            SetColor(color);
        }

        // override
        public override bool IsMovedValid(Move move){
            Board board = Board.GetTheBoard();

            if(!base.IsMovedValid(move)){
                Console.WriteLine("base false");
                return false;
            }
            Spot startSpot = move.GetStartSpot();
            Spot endSpot = move.GetEndSpot();

            int xD = endSpot.Get_X() - startSpot.Get_X();
            int yD = endSpot.Get_Y() - startSpot.Get_Y();
            Console.WriteLine("xD\t"+xD);
            Console.WriteLine("yD\t"+yD);
            Console.WriteLine(Math.Abs(yD));
            
            int side;
            if(board.GetPiece(startSpot).GetColor().Equals(PieceColor.white)){
                side = -1;
            }
            else{
                side = 1;
            }
            Console.WriteLine("side is"+ side);
            if(xD == side && yD == 0 && board.IsSpotEmpty(endSpot)){
                return true;
            }
            if(xD == 2*side && yD == 0 && board.IsSpotEmpty(new Spot(startSpot.Get_X()+side,startSpot.Get_Y()))&& !board.GetPiece(startSpot).HasBeenMoved()){
                return true;
            }
            if(xD == side && Math.Abs(yD) == 1 && !board.IsSpotEmpty(endSpot)){
                return true;
            }
            Console.WriteLine("pawn false");
            return false;
        }
    }
}