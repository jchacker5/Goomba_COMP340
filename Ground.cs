class Ground{
    private int length;
    private string[] groundSprite;
    private int posX;

    public Ground(int length){
        this.length = length;
        groundSprite = new string[2];
        SetSprite();
    }
    private void SetSprite(){
        string grassOneLayer = "";
        for(int i = 0; i < this.length; i++){
            grassOneLayer += @"/";   
        }
        groundSprite[0] = grassOneLayer;
        groundSprite[1] = grassOneLayer;
    }
public void DrawSprite(){
    string spaces = "";
        for(int i = 0; i < posX; i++){
            spaces += " ";
        }
        foreach(string eachLine in groundSprite){
            Console.WriteLine(spaces + eachLine);
        }
    }
}

