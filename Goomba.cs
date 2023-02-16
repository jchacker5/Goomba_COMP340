class Goomba{
    private int posX;
    private int speed;

    private string[] GoombaSprite;
    public Goomba(int speed){
        this.posX = 0;
        this.speed = speed;
        this.goombaSprite = new string[10];
        setSprite(); // store the goomba speed

    }
    private void SetSprite(){
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
}