namespace IncludeInterfaceLib;
interface IStream
{
	void ShowFrame();	
}


class AppVersion:IStream
{
	string version = "DBG 4.1.1 Scurve";
	public void ShowFrame()
	{
		Console.WriteLine("This App Version is"+version);
	}
}
abstract class SetImgConfig
{
	public int x,y;
	public abstract int SetImageSize();
}

class ShowImg:SetImgConfig,IStream
{
	public ShowImg(int x,int y)
	{
		this.x = x;
		this.y = y;
	}
	public override int SetImageSize()
	{
		return x+y;
	}
	public void ShowFrame()
	{
		Console.Write("image success configuration ");
	}
}
