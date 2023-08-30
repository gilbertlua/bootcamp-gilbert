namespace ChessLibrary{
    public class Move{
        private Spot _startSpot; 
        private Spot _endSpot;

        public Move(Spot startSpot, Spot endSpot){
            _startSpot = startSpot; 
            _endSpot = endSpot; 
        }  

        public Spot GetStartSpot() { 
            return _startSpot;
        }
        public Spot GetEndSpot(){
            return _endSpot;
        }   
    }
}