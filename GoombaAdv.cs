class GoombaAdv : Goomba
{
    
    private string[] goombaSpriteLeftFoot;   
    private string[] goombaSpriteRightFoot;
    private int spriteIndex = 0;

    public GoombaAdv(int speed) : base(speed)
    {
        goombaSpriteLeftFoot = new string[10];
        goombaSpriteRightFoot = new string[10];
        SetSprite();

    }

    public override void DrawSprite()
    {
        if (this.posX < 0)
        {
            Console.WriteLine("The sprite is not visible");
            return;
        }

        string spaces = "";
        for (int i = 0; i < this.posX; i++)
        {
            spaces += " ";
        }

        string[] currentSprite;
        if (spriteIndex % 2 == 0)
        {
            currentSprite = goombaSpriteLeftFoot;
        }
        else
        {
            currentSprite = goombaSpriteRightFoot;
        }

        foreach (string eachLine in currentSprite)
        {
            Console.WriteLine(spaces + eachLine);
        }

        spriteIndex++;

        if (spriteIndex == 1000000) // to prevent integer overflow
        {
            Console.WriteLine("Resetting the sprite index");
            spriteIndex = 0;
        }
    }

    private void SetSprite()
    {
    // Store the left and right foot sprites in separate arrays
    goombaSpriteLeftFoot[0] = @"     ________  ";
    goombaSpriteLeftFoot[1] = @"    /        \ ";
    goombaSpriteLeftFoot[2] = @"   /  \    /  \ ";
    goombaSpriteLeftFoot[3] = @"  /   |    |   \ ";
    goombaSpriteLeftFoot[4] = @" /  -^------^-  \ ";
    goombaSpriteLeftFoot[5] = @"|________________| ";
    goombaSpriteLeftFoot[6] = @" ____ /    \ ";  
    goombaSpriteLeftFoot[7] = @"/____\      |____ ";
    goombaSpriteLeftFoot[8] = @"       ==== /____\ ";
    goombaSpriteLeftFoot[9] = @"                     ";
    
    goombaSpriteRightFoot[0] = @"     ________  ";
    goombaSpriteRightFoot[1] = @"    /        \ ";
    goombaSpriteRightFoot[2] = @"   /  \    /  \ ";
    goombaSpriteRightFoot[3] = @"  /   |    |   \ ";
    goombaSpriteRightFoot[4] = @" /  -^------^-  \ ";
    goombaSpriteRightFoot[5] = @"|________________| ";
    goombaSpriteRightFoot[6] = @"      /    \ ____ ";
    goombaSpriteRightFoot[7] = @" ____|      /____\ ";
    goombaSpriteRightFoot[8] = @"/____\ ====         ";
    goombaSpriteRightFoot[9] = @"                     ";
    
    }

}