namespace CslAppOperatorConvertion
{
    public class Source
    {
        public int Code { get; }
        public Source(int code)
        {
            Code = code;
        }

        public static implicit operator bool(Source source)
        {
            return source.Code > 0;
        }
    }
}

        //public static Source operator +(Source s1, Source s2)
        //{
        //    return new Source(s1.Code + s2.Code);
        //}

        //public static Source operator -(Source s1, Source s2)
        //{
        //    return new Source(s1.Code + s2.Code);
        //}