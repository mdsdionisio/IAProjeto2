namespace Projeto_IA2
{
    public static class Limitado
    {
        static Informacao x1 = new Informacao("x1", new int[2]{0,0}, 0);
        static Informacao x2 = new Informacao("x2", new int[2]{0,1}, 1);
        static Informacao x3 = new Informacao("x3", new int[2]{1,0}, 1);
        static Informacao x4 = new Informacao("x4", new int[2]{1,1}, 0);

        public static Informacao[] ObtenhaPadrao1() => new List<Informacao>(){x1,x2,x3,x4}.ToArray();
    }
}