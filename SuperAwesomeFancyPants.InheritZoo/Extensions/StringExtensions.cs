namespace SuperAwesomeFancyPants.InheritZoo.Extensions
{
    public static class StringExtensions
    {
        public static int NumberOfWords(this string str)
        {
            return str.Split(" ").Length;
        }
    }
}