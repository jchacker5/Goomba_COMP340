class ParaGomba : Goomba
{
    public ParaGomba(int speed) : base(speed)
    {
        //intialize variables
       // posX = 0;
        //this.speed = speed;
        //goombaSprite = new string[10];
        //Direction = true;
        
    }
    protected override void SetSprite()
    {
        goombaSprite[0] = @"              ________  ";
        goombaSprite[1] = @"             /        \ ";
        goombaSprite[2] = @"            /  \    /  \ ";
        goombaSprite[3] = @"           /   |    |   \ ";
        goombaSprite[4] = @"_________ /  -^------^-  \ _________";
        goombaSprite[5] = @"\_       |________________|       _/";
        goombaSprite[6] = @"  \_           /    \           _/  ";  
        goombaSprite[7] = @"    \____ ____|      |____ ____/";
        goombaSprite[8] = @"         /____\ ==== /____\ ";
        goombaSprite[9] = @"                             ";
    }
}