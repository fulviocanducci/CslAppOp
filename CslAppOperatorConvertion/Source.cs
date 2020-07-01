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