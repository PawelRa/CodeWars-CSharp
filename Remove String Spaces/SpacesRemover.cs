namespace Remove_String_Spaces
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
           return input.Replace(" ","");
        }
    }
}