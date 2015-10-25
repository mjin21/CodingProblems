namespace CodingProblems
{
    class StringPermutation
    {
        public bool IsPermutation(string a, string b)
        {
            if(a == b)
                return true;

            if (a.Length > b.Length)
                return AContainsB(a,b);
            else
                return AContainsB(b,a);
        }

        private bool AContainsB(string a, string b)
        {
            bool doesContain = false;

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == b[i])
                {
                    for(int j = i; j < b.Length; j++)
                    {
                        if (a[j] == b[j])
                            continue;
                        else
                        {
                            doesContain = false;
                            break;
                        }
                    }
                }
            }

            return doesContain;
        }
    }
}
