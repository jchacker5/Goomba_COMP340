using System.Text;
class GoombaAdv : Goomba
{
    private string[] goombaSpriteLeftFoot = new string[10];
    private string[] goombaSpriteRightFoot = new string[10];

    private int spriteIndex = 0;

    public GoombaAdv(int speed ) : base(speed, new string[10], new string[10])
    {
        // goombaSpriteLeftFoot = new string[10];
        // goombaSpriteRightFoot = new string[10];
        SetSprite();

    }

    public override void DrawSprite()
    {
        if (this.posX < 0|| this.posX > Console.WindowWidth)
        {
            Console.WriteLine("The sprite is not visible");
            return;
        }

        StringBuilder spaces = new StringBuilder();
        for (int i = 0; i < this.posX; i++)
        {
            spaces.Append(" ");
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
            Console.WriteLine(spaces.ToString() + eachLine);
        }

        spriteIndex = (spriteIndex + 1) % int.MaxValue;

        if (spriteIndex == 1000000) // to prevent integer overflow
        {
            Console.WriteLine("Resetting the sprite index");
            spriteIndex = 0;
        }
    }

    protected override void SetSprite()
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