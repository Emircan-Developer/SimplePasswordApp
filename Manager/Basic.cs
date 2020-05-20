using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.Keys.SetKey.Manager
{
    public class Basic : Texts
    {
        public Basic()
        {
            this.Alphabets = new string[]{"A","a","B","b","C","c","Ç","ç","D","d","E","e","F","f","G","g","Ğ","ğ","H",
            "h","I","ı","İ","i","J","j","K","k","L","l","M","m","N","n","P","p","R","r",
            "S","s","Ş","ş","U","u","Ü","ü","V","v","Y","y","Z","z" };
            this.GenerateALphabets = new string[]{
                  "asdwrfdsaf","dsfgfdgj","asfsdfhgv","asASFasfdxf","aSDfdsg","agfsdayg","fdgesrgt","adsgfdsgreg","gdfbvcxdfg","dsajhjlkaw","astgf<aedss&","sAfasdtwret","as&asd","/asd%aAsd","asd%asdw3q","asdsa'!34awsd","Q22easd3421","asd^2234","'^!W'3'",
            "âsd^'234","sad^'+23asd","asd^'+234asd","sadxsvas5","asdd324","asd'^4","sd234","asdxzxc","as1234sdf45","sad2345sdf","asdxvxdf","dasxxvdsf","A23awsesdm","sfdjojr","asfdcxzgRFT","aSDsxczx4aw","ASdsdczdfsef","asDSADwqe","asSAdwesa",
            "ASdzxd","aDASd","ASdasd","ASdasd","ASdasd","ASDaas234d","Asdwq24213","we123sadweq","adsVw331234","easdFDewr345","CVsdre23412","Case21q3S","DXFDSZdsda>aw","ASdzxfder"

            };
        }
        public override string[] Alphabets { get; set; }
        public override string[] GenerateALphabets { get; set; }
    }
}
