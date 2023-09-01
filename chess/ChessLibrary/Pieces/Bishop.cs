namespace ChessLibrary{
    public class Bishop:Piece{
        public Bishop(PieceColor color){
            SetName("Bishop");
            SetSymbol("B");
            SetColor(color);
        }

        // override
        public override bool IsMovedValid(Move move){
            Board board = Board.GetTheBoard();
            if (!base.IsMovedValid(move)){
                return false;
            }                
            Spot startSpot = move.GetStartSpot();
            Spot endSpot = move.GetEndSpot();
            int xD = endSpot.Get_X() - startSpot.Get_X();
            int yD = endSpot.Get_Y() - startSpot.Get_Y();
            
            bool canMove = true;
            if (Math.Abs(xD) == Math.Abs(yD) && xD != 0) {
                int verticalDirection = xD > 0 ? 1 : -1;
                int horizontalDirection = yD > 0 ? 1 : -1;

                for (int i = 1; i < Math.Abs(xD); i++) {
                    int x = startSpot.Get_X() + i * verticalDirection;
                    int y = startSpot.Get_Y() + i * horizontalDirection;
                    if (!board.IsSpotEmpty(new Spot(x, y))){
                        canMove = false;
                    }                        
                }
            } 
            else{
                canMove = false;
            } 
            return canMove;
        }
    }
}