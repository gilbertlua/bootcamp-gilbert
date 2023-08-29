namespace ChessLibrary{
	public abstract class Piece:IPeace{
		private string? _name;
		private string? _symbol;
		private PieceColor _color;

		// set
		public bool SetName(string name)
		{
			if(name is not null)
			{
				this._name = name;
				return true;
			}
			return false;
			
		}
		public bool SetSymbol(string symbol)
		{
			if(symbol is not null)
			{
				this._name = symbol;
				return true;
			}
			return false;
		}
		
		public bool SetColor(PieceColor color)
		{
			this._color = color;
			return true;
		}
		
		// get
		public string GetName()
		{
			if(this._name is not null)
			{
				return this._name;
			}
			else
			{
				throw new ArgumentNullException("require set name before");	
			}
			
		}
		public string GetSymbol()
		{
			if(this._symbol is not null)
			{
				return this._symbol;
			}
			else
			{
				throw new ArgumentNullException("require set symbol before");	
			}
		}
	}
}