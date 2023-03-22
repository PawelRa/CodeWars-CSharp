namespace Remove_String_Spaces
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            string Result = "";
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    continue;
                }
                Result += c;
            }
            return Result;
        }
    }
}