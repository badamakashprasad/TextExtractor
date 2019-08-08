using System;
using System.Text.RegularExpressions;
using System.Collections;
public class RegularMatch{
public string[] instr {get;set;}
 public ArrayList ret = new ArrayList();


public RegularMatch(string s){
  instr = s.Split("\n");
  }

public ArrayList GetMatches(string[] str,string exp){

  foreach(string s in str){

    MatchCollection m = Regex.Matches(s,exp);
    
    foreach(Match i in m){
      ret.Add(i);

    }
  }
return ret;
}

public ArrayList GetIntegers(){
  ret = GetMatches(instr,"\\d+");
  return ret;
  }


public ArrayList GetEmails(){
  return GetMatches(instr,"\\w+@\\w+.com");
}

public ArrayList GetNames(){
  return GetMatches(instr,"[A-Z]\\w+");
}

public ArrayList GetPhoneNumber(){
  return GetMatches(instr,"[0-9]{10}|\\+[0-9]\\d+-[0-9]{10}");
}
}


public class Regular{
public static void Main(string[] args){
string s = "sdfas@dfads.com sadasd@scas.com\n Akash Prasad 1234567937 +91-9724211403";
RegularMatch m = new RegularMatch(s);
ArrayList ret = m.GetPhoneNumber();
foreach(var st in ret){
  Console.WriteLine(st.ToString());
}
}
}
