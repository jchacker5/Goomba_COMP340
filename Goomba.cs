class Goomba{
    protected int posX;
    private int speed;
    protected string[] goombaSprite;
    private Boolean direction;
    protected Lazy<string[]> goombaSpriteLeftFoot;
    protected Lazy<string[]> goombaSpriteRightFoot;
   public Goomba(int speed)
    {
        this.posX = 0;
        this.speed = speed;
        this.goombaSprite = new string[10];
        SetSprite(); // store the goomba image to goombaSprite
        this.direction = true; // true = right, false = left
        goombaSpriteLeftFoot = new Lazy<string[]>(() => new string[10]);
        goombaSpriteRightFoot = new Lazy<string[]>(() => new string[10]);
    }
    protected Goomba(int speed, string[] goombaSpriteLeftFoot, string[] goombaSpriteRightFoot) : this(speed)
    {
    
    }

    protected virtual void SetSprite(){
        goombaSprite[0] = @"     ________  ";
        goombaSprite[1] = @"    /        \ ";
        goombaSprite[2] = @"   /  \    /  \ ";
        goombaSprite[3] = @"  /   |    |   \ ";
        goombaSprite[4] = @" /  -^------^-  \ ";
        goombaSprite[5] = @"|________________| ";
        goombaSprite[6] = @"      /    \ ";  
        goombaSprite[7] = @" ____|      |____ ";
        goombaSprite[8] = @"/____\ ==== /____\ ";
        goombaSprite[9] = @"                     ";
    }
    public virtual void DrawSprite(){
        string spaces = "";
        for(int i = 0; i < this.posX; i++){
            spaces += " ";
        }
        foreach(string eachLine in goombaSprite){
            Console.WriteLine(spaces + eachLine);
        }
    }
    public void changeDir(){
        this.direction = !this.direction;
        //this.speed = -this.speed;
    }
    public void UpdatePos(int groundLength){
        if(this.direction) // if direction is true
            this.posX = posX + this.speed;
        else
            this.posX = this.posX - this.speed;
    
    }
}
