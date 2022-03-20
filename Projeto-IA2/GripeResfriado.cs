namespace Projeto_IA2
{
    public static class GripeResfriado
    {
        static Informacao Gripe1 = new Informacao("Gripe1", new int[4]{1,0,1,1}, 0);
        static Informacao Resfriado1 = new Informacao("Resfriado1", new int[4]{0,1,0,1}, 1);
        static Informacao Gripe2 = new Informacao("Gripe2", new int[4]{1,0,1,0}, 0);
        static Informacao Resfriado2 = new Informacao("Resfriado2", new int[4]{0,1,1,1}, 1);
        static Informacao Gripe3 = new Informacao("Gripe3", new int[4]{0,0,1,1}, 0);
        static Informacao Resfriado3 = new Informacao("Resfriado3", new int[4]{0,0,0,1}, 1);

        public static Informacao[] ObtenhaPadrao1() => new List<Informacao>(){Gripe1, Resfriado1, Gripe2, Resfriado2, Gripe3, Resfriado3}.ToArray();

        static Informacao x1 = new Informacao("x1", new int[4]{1,1,1,1}, 0);
        static Informacao x2 = new Informacao("x2", new int[4]{1,0,0,0}, 0);
        static Informacao x3 = new Informacao("x3", new int[4]{0,1,0,0}, 0);
        static Informacao x4 = new Informacao("x4", new int[4]{0,1,1,1}, 0);
        static Informacao x5 = new Informacao("x5", new int[4]{1,0,0,1}, 0);
        static Informacao x6 = new Informacao("x6", new int[4]{0,0,0,0}, 0);

        public static Informacao[] ObtenhaTeste1() => new List<Informacao>(){x1,x2,x3,x4,x5,x6}.ToArray();
    }
}