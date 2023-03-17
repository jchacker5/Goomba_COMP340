Star backgroundStar = new Star(0);
GoombaAdv goomba = new GoombaAdv(4);
Ground gameGround = new Ground(120);
GoombaAdv paraGoomba = new GoombaAdv(4);
GoombaWalk gameAnimation = new GoombaWalk(backgroundStar, paraGoomba, gameGround);
gameAnimation.StartAnimation();
