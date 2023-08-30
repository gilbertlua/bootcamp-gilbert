namespace ChessLibrary{

    public class Board{
        private static Board _board = new Board();
        private Piece[,]? _piecesHold;
        private int _sizeHeight;
        private int _sizeWidth;
        private List<IPiece>? _captPiece;
        private string[,]? _configuration;
        
        // constructur
        public Board(){
            _sizeWidth = 8;
            _sizeHeight = 8;

            _piecesHold = new Piece[8,8];
            _configuration = new string[,]{
                {"Pawn", "Pawn", "Pawn", "Pawn", "Pawn", "Pawn", "Pawn", "Pawn"},
                {"Rook", "Knight", "Bishop", "Queen", "King", "Bishop", "Knight", "Rook"}
            };
        }

        /// <summary>
        /// is used for intialize board of chess with configuration file
        /// </summary>
        private void InitBoard(){
            CreateInitPiece? ip = new CreateInitPiece();
            for(int i=0;i<=_sizeHeight;i++){
                for(int j=0;j<_sizeWidth;j++){
                    _piecesHold[i,j] = null;
                }
            }
            for(int i = 0; i < _configuration?.Length; i++){
                for(int j = 0; j < _configuration[0,0].Length; j++){
                    SetPiece(ip.CreatePiece(_configuration[i,j], PieceColor.white), new Spot(i+_sizeHeight - _configuration.Length, j));        
                }
            }
            for(int i = 0; i < _configuration?.Length; i++){
                for(int j = 0; j < _configuration[0,0].Length; j++){
                    SetPiece(ip.CreatePiece(_configuration[i,j], PieceColor.black), new Spot(_configuration.Length-1-i, j));        
                }
            }
        }     

        /// <summary>
        /// is used for add piece for the position
        /// </summary>
        /// <param name="piece">the piece instance</param>
        /// <param name="spot">spot you want to go</param>
        public void SetPiece(Piece piece,Spot spot){
            if(IsOutOfRange(spot.Get_X(),spot.Get_Y())){
                throw new ArgumentOutOfRangeException();
            }
            else{
                if(piece!=null){
                    _piecesHold[spot.Get_X(),spot.Get_Y()] = piece;
                }
            }
            
        }

        /// <summary>
        /// this method used to check if it is out of range
        /// </summary>
        /// <param name="move"></param>
        public bool IsOutOfRange(Move move){
            bool check = IsOutOfRange(move.GetStartSpot().Get_X(), move.GetStartSpot().Get_Y())
                        || IsOutOfRange(move.GetEndSpot().Get_X(), move.GetEndSpot().Get_Y());
            return true;
        }

        /// <summary>
        /// this method used to determine from move if is it out of ranges or not
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsOutOfRange(int x, int y){
            bool check = x < 0 || x >= _sizeHeight || y < 0 || y >= _sizeWidth;
            return check;
        }
        

        /// <summary>
        /// this metod used to view the board
        /// </summary>
        public void ViewBoard(){
            Console.Write(" ");
            for(int j=0 ;j<_sizeWidth ; j++){
                Console.Write("\t"+(char)(j+'a')+ " \t\t");
            }
            
            Console.WriteLine();
            for(int i=0; i<=_sizeHeight; i++){
                Console.WriteLine(8-i);
                for(int j=0; j<=_sizeHeight;j++){
                    Console.Write("\t" + GetPieceSymbol(new Spot(i,j))+ "\t");
                }
                Console.Write(' ');
                Console.WriteLine();
            }
        }       

        /// <summary>
        /// is used for get piece symbol inside coordinate
        /// </summary>
        /// <param name="spot"></param>
        /// <returns></returns>
        private string GetPieceSymbol(Spot spot){
            Piece piece = GetPiece(spot);
            if(piece!=null){
                String firstchar;
                if(piece.GetColor() == PieceColor.white){
                    firstchar = "w";
                }
                else{
                    firstchar = "b";
                }
                return firstchar + GetPiece(spot).GetSymbol();
            }
            return ". \t";
        }

        /// <summary>
        /// this method is used for get the piece in the coordinate
        /// </summary>
        /// <param name="spot"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Piece GetPiece(Spot spot){
            if(IsOutOfRange(spot.Get_X(),spot.Get_Y())){
                throw new ArgumentOutOfRangeException();
            }
            return _piecesHold[spot.Get_X(),spot.Get_Y()];    
        }   



    }
}