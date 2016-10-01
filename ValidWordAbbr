public class ValidWordAbbr {
    Dictionary <string, string> dict;
    public ValidWordAbbr(string[] dictionary) {
        dict = new Dictionary<string, string> ();
        string key; string value;
        foreach(string s in dictionary)
        {
            key = GenerateKey(s);  
            if(!dict.TryGetValue(key, out value))
                dict.Add(key, s);
            else
            {
                if(!s.Equals(dict[key]))
                    dict[key] = "";
            }
        }
    }

    public bool IsUnique(string word) {
        string value; bool ret;
        ret = dict.TryGetValue(GenerateKey(word), out value);
        if(!ret) return true;
        if(word.Equals(value)) return true;
        return false;
    }
    
    string GenerateKey(String s)
    {
        string key;
        string cat = (s.Length-2).ToString();
        if(s.Length > 2)
                key = s[0] + cat + s[s.Length-1];
            else
                key = s;
        return key;
    }
}


// Your ValidWordAbbr object will be instantiated and called as such:
// ValidWordAbbr vwa = new ValidWordAbbr(dictionary);
// vwa.IsUnique("word");
// vwa.IsUnique("anotherWord");
