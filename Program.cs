Star star = new Star(0);
Goomba goomba = new Goomba(4);
Ground ground = new Ground(120);
GoombaWalk gWalk = new GoombaWalk(star, goomba, ground);
gWalk.StartAnimation();
GoombaAdv goomb = new GoombaAdv(10);
goomba.DrawSprite();


// for(int i = 0; i < 120; i++){
//     goomba.DrawSprite();
//     goomba.UpdatePos(120);
// }
// goomba.changeDir();
// goomba.UpdatePos(120);
// for(int i = 0; i < 120; i++){
//     goomba.DrawSprite();
//     goomba.UpdatePos(120);
// }
//GoombaAdv goomb = new GoombaAdv(10);
for(int i = 0; i < 120; i++){
    gWalk.StartAnimation();
    goomb.DrawSprite(); 
    goomb.UpdatePos(120);
}
goomb.changeDir();
goomb.UpdatePos(120);
for(int i = 0; i < 120; i++){
    gWalk.StartAnimation();
    goomb.DrawSprite();
    goomb.UpdatePos(120);
}
