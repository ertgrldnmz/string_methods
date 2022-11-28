internal class Program
{
    private static void Main(string[] args)
    {
        string degisken="Dersimize Csharp hoşgeldiniz";
        string degisken2="Csharp";

        //Length
        Console.WriteLine(degisken.Length);

        //ToUpper and ToLower
        Console.WriteLine(degisken.ToLower());
        Console.WriteLine(degisken.ToUpper());

        //Concat
         Console.WriteLine(string.Concat(degisken," Merhaba"));

         //Compare, CompareTo
         Console.WriteLine(degisken.CompareTo(degisken2));
         
         Console.WriteLine(string.Compare(degisken,degisken2,true));
         Console.WriteLine(string.Compare(degisken,degisken2,false));

         //Contains
         Console.WriteLine(degisken.Contains(degisken2));

         Console.WriteLine(degisken.EndsWith("hoşgeldiniz"));
         Console.WriteLine(degisken.StartsWith("Dersim"));

          //IndexOf
          Console.WriteLine(degisken.IndexOf("Ders"));

          //LastIndexOf
          Console.WriteLine(degisken.LastIndexOf("i"));

           //Insert
          Console.WriteLine(degisken.Insert(0,"Aferin "));

          //PadLeft, PadRight
          Console.WriteLine(degisken+degisken2.PadLeft(30));
           Console.WriteLine(degisken.PadRight(50)+degisken2);
        Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

        //Remove
          Console.WriteLine(degisken.Remove(12));
          Console.WriteLine(degisken.Remove(12,3));
          Console.WriteLine(degisken.Remove(0,3));

          //Replace
          Console.WriteLine(degisken.Replace("Csharp","C#"));
           Console.WriteLine(degisken.Replace(" ","*"));

           //Split
          Console.WriteLine(degisken.Split(' ')[1]);

          //Substring
          Console.WriteLine(degisken.Substring(4));
           Console.WriteLine(degisken.Substring(4,6));




    }
}