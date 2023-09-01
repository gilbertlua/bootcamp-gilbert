namespace ChessLibrary{
    public class Knight:Piece{
         public Knight(PieceColor color){
            SetName("Knight");
            SetSymbol("Kn");
            SetColor(color);
        }

        // override
        public override bool IsMovedValid(Move move){
            if(!base.IsMovedValid(move)){
                return false;
            }
            Spot startSpot = move.GetStartSpot();
            Spot endSpot = move.GetEndSpot();
            int xD = endSpot.Get_X() - startSpot.Get_X();
            int yD = endSpot.Get_Y() - startSpot.Get_Y();
            return Math.Abs(xD * yD) == 2;
        }
    }
}

/*
example maps
    0   1   2   3   4   5   6   7 
0   
1
2
3
4
5   5,0
6
7       7,1


(x , y)
start spot -> (7 , 1)
end spot   -> (5 , 0)

xd = 5 - 7 = -2
yd = 1 - 0 = 0


*/