using System.Collections.Generic;

namespace FacebookNameDisplay
{
    public static class LikeMessageFormatter
    {
        public static string Format(List<string> names)
        {
            if (names == null || names.Count == 0)
                return "No Likes";

            if (names.Count == 1)
                return $"{names[0]} likes your post.";

            if (names.Count == 2)
                return $"{names[0]} and {names[1]} like your post.";

            return $"{names[0]}, {names[1]} and {names.Count - 2} others like your post.";
        }
    }
}

