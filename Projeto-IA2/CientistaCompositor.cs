namespace Projeto_IA2
{
    public static class CientistaCompositor
    {
        static Informacao Bach = new Informacao("Bach", new int[2]{0,0}, 0);
        static Informacao Beethoven = new Informacao("beethoven", new int[2]{0,1}, 0);
        static Informacao Einstein = new Informacao("einstein", new int[2]{1,0}, 1);
        static Informacao Kepler = new Informacao("kepler", new int[2]{1,1}, 1);

        public static Informacao[] ObtenhaPadrao1() => new List<Informacao>(){Bach, Beethoven, Einstein, Kepler}.ToArray();
        public static Informacao[] ObtenhaPadrao2() => new List<Informacao>(){Kepler, Bach, Beethoven, Einstein}.ToArray();
        public static Informacao[] ObtenhaPadrao3() => new List<Informacao>(){Einstein, Kepler, Bach, Beethoven}.ToArray();
        public static Informacao[] ObtenhaPadrao4() => new List<Informacao>(){Beethoven, Bach, Kepler, Einstein}.ToArray();
        public static Informacao[] ObtenhaPadrao5() => new List<Informacao>(){Kepler, Einstein, Beethoven, Bach}.ToArray();
        public static Informacao[] ObtenhaPadrao6() => new List<Informacao>(){Bach, Einstein, Kepler, Beethoven}.ToArray();
        public static Informacao[] ObtenhaPadrao7() => new List<Informacao>(){Einstein, Bach, Beethoven, Kepler}.ToArray();
        public static Informacao[] ObtenhaPadrao8() => new List<Informacao>(){Kepler, Beethoven, Bach, Einstein}.ToArray();
        public static Informacao[] ObtenhaPadrao9() => new List<Informacao>(){Bach, Beethoven, Kepler, Einstein}.ToArray();
        public static Informacao[] ObtenhaPadrao10() => new List<Informacao>(){Bach, Einstein, Beethoven, Kepler}.ToArray();
        public static Informacao[] ObtenhaPadrao11() => new List<Informacao>(){Bach, Kepler, Einstein, Beethoven}.ToArray();
        public static Informacao[] ObtenhaPadrao12() => new List<Informacao>(){Bach, Kepler, Beethoven, Einstein}.ToArray();
        public static Informacao[] ObtenhaPadrao13() => new List<Informacao>(){Kepler, Bach, Einstein, Beethoven}.ToArray();
        public static Informacao[] ObtenhaPadrao14() => new List<Informacao>(){Kepler, Einstein, Bach, Beethoven}.ToArray();
        public static Informacao[] ObtenhaPadrao15() => new List<Informacao>(){Kepler, Beethoven, Einstein, Bach}.ToArray();
        public static Informacao[] ObtenhaPadrao16() => new List<Informacao>(){Einstein, Kepler, Beethoven, Bach}.ToArray();
        public static Informacao[] ObtenhaPadrao17() => new List<Informacao>(){Einstein, Bach, Kepler, Beethoven}.ToArray();
        public static Informacao[] ObtenhaPadrao18() => new List<Informacao>(){Einstein, Beethoven, Bach, Kepler}.ToArray();
        public static Informacao[] ObtenhaPadrao19() => new List<Informacao>(){Einstein, Beethoven, Kepler, Bach}.ToArray();
        public static Informacao[] ObtenhaPadrao20() => new List<Informacao>(){Beethoven, Bach, Einstein, Kepler}.ToArray();
        public static Informacao[] ObtenhaPadrao21() => new List<Informacao>(){Beethoven, Kepler, Einstein, Bach}.ToArray();
        public static Informacao[] ObtenhaPadrao22() => new List<Informacao>(){Beethoven, Kepler, Bach, Einstein}.ToArray();
        public static Informacao[] ObtenhaPadrao23() => new List<Informacao>(){Beethoven, Einstein, Bach, Kepler}.ToArray();
        public static Informacao[] ObtenhaPadrao24() => new List<Informacao>(){Beethoven, Einstein, Kepler, Bach}.ToArray();

    }
}