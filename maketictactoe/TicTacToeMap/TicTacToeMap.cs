namespace TicTacToeMap;

public class CreateMap
{
    private static string[,] coorPos = new string[3,3]{
        {"-","-","-"},
        {"-","-","-"},
        {"-","-","-"}
    }; 
    private string[,] mapSet = 
    new string[10,1] {
        {$"    a       b       c   \n"},
        {$"        |       |       \n"},
        {$"1   {coorPos[0,0]}   |   {coorPos[0,1]}   |   {coorPos[0,2]}   \n"},
        {$" _______|_______|_______\n"},
        {$"        |       |       \n"},
        {$"2   {coorPos[1,0]}   |   {coorPos[1,1]}   |   {coorPos[1,2]}   \n"},
        {$" _______|_______|_______\n"},
        {$"        |       |       \n"},
        {$"3   {coorPos[2,0]}   |   {coorPos[2,1]}   |   {coorPos[2,2]}   \n"},
        {$"        |       |       \n"},
    };
    
    public string GetMap(){
        string? check="";
        for(int i=0 ; i<=9 ; i++){
            check += mapSet[i,0];
        }
        return check;
    }    
    public void SetCoorPos(int x,int y,string chr){
        coorPos[x,y] = chr;
    }
    public void DisplayMap(){
        SetCoorPos(1,2,"X");
        Console.WriteLine(GetMap());
    }
}
