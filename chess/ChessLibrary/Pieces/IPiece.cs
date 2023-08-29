namespace ChessLibrary{
	public interface IPeace{
		public bool SetName(string name);
		public bool SetSymbol(string symbol);
		public string GetName();
		public string GetSymbol();
	}
}