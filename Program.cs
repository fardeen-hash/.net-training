class Program{

    static void Main(string[] args){
        var cookie =new HttpCookies();
        cookie["name"]="mosh";
        Console.WriteLine(cookie["name"]);
    }
}