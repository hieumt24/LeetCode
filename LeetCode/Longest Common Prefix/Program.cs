//Problem: Write a function to find the longest common prefix string amongst an array of strings.
//Write a function to find the longest common prefix string amongst an array of strings.
//If there is no common prefix, return an empty string "".
    

//Test case 1 : strs = ["flower","flow","flight"]
string[] strs = new string[] { "flower", "flow", "flight" };
Console.WriteLine(LongestCommonPrefix(strs));

//Test case 2 : Input: strs = ["dog","racecar","car"]
string LongestCommonPrefix(string[] strs) {
    if (strs.Length == 0)
        return "";
    string prefix = strs[0];
    for (int i = 1; i < strs.Length; i++)
        while (strs[i].IndexOf(prefix) != 0) {
            prefix = prefix.Substring(0, prefix.Length - 1);
            if (prefix == "")
                return "";
        }

    return prefix;
}