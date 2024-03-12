using System.Text;

string n = "Ribeirao preto";

StringBuilder sb = new StringBuilder();

for(var i = n.Length - 1; i >= 0; i--){
    sb.Append(n[i]);
}

Console.WriteLine(sb.ToString());

