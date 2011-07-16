namespace System
{
    public static class CastingHelpers
    {
        public static T CastAs<T>(this object @object)
        {
            return (T) @object;
        }
    }
}