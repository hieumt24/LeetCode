// URI: https://leetcode.com/problems/roman-to-integer/
//Problem: Roman to Integer
//Given a roman numeral, convert it to an integer.
//Example 1:
//Input: s = "III"
//Output: 3
var result = RomanToInt("MCMXCIV");
Console.WriteLine(result);

int RomanToInt(string s)
{
    Dictionary<char, int> romanValues = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    int total = 0;

    for (int i = 0; i < s.Length; i++)
    {
        var currentValue = romanValues[s[i]];
        if(i < s.Length - 1)
        {
            var nextValue = romanValues[s[i + 1]];
            if(currentValue < nextValue)
            {
                total += nextValue - currentValue;
                i++;
                continue;
            }
        }
        total += currentValue;
    }
    return total;

}