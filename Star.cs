class Star{
    private readonly int posX;
    private string[] starSprite;
    public Star(int posX){
        this.posX = posX;
        this.starSprite = new string[6];
        SetSprite(); //storing star image to starSprite
    }
    private void SetSprite(){
        starSprite[0] = @"          ";
        starSprite[1] = @"  ___/\___";
        starSprite[2] = @"  \  ||  / ";
        starSprite[3] = @"  /__  __\";
        starSprite[4] = @"     \/   ";
        starSprite[5] = @"          "; 
    }
    public void DrawSprite(){
        string spaces = "";
        for(int i = 0; i < this.posX; i++){
            spaces += " ";
        }
        foreach(string eachLine in starSprite){
            Console.WriteLine(spaces + eachLine);
        }
    }
}