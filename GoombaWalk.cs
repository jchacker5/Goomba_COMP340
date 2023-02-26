class GoombaWalk{
    private Star star;
    private Goomba goomba;
    private Ground ground;
    public GoombaWalk(Star star, Goomba goomba, Ground ground){
        this.star = star;
        this.goomba = goomba;
        this.ground = ground;
    }
    private void DrawFrame(){
        //Console.Clear();
        this.star.DrawSprite();
        this.goomba.DrawSprite();
        this.ground.DrawSprite();
    }
    public void StartAnimation(){
        int frameNumber = 20;
        int sleepTime = 200; // pause for 200ms
        for(int i = 0; i < frameNumber; i++){
            Console.Clear();
            DrawFrame();
            goomba.UpdatePos(120);
            Thread.Sleep(sleepTime);
        }
        goomba.changeDir();
        goomba.UpdatePos(120);
        for(int i = 0; i < frameNumber; i++){
            Console.Clear();
            DrawFrame();
            goomba.UpdatePos(120);
            Thread.Sleep(sleepTime);
        }
    }
}





