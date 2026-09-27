// Goomba g = new Goomba(1);
// ParaGoomba pg = new ParaGoomba(1);
// GoombaAni ga1 = new GoombaAni(g);
// GoombaAni ga2 = new GoombaAni(pg);

// ga1.StartAni();
// ga2.StartAni();

Character goomba = new Goomba();
Character paraGoomba = new ParaGoomba();

GoombaAni ga1 = new GoombaAni(goomba);
GoombaAni ga2 = new GoombaAni(paraGoomba);

ga1.StartAni();
ga2.StartAni();
