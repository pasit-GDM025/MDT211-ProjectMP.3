using System;
enum Menu{
    Login = 1,
    MusicPlayer
}
enum LoginMenu{
    EmailLogin = 1,
    GuestLogin 
}
class Program {
    public static char starter; //ในตัวเต็มจะรับ ค่าจากการ login
    
    public static void Main(string[]args)
    {
        starting();
        
    }
    public static void WhenStart(){
         starting(); 
        if(starter != '+'){ // เมื่อ login ได้ จะเริ้มทำงานส่วนนี้
            explained();//ส่านนี้จะอธิบายให้ userว่าต้องกดอะไรบ้าง
             inputCommand(); //รับค่าให้ ีuser พิม 1 2 3 แล้วเก็บในลิสด์ 

        }
    }
    public static void starting(){
        char Command;
        Console.Clear();
        Console.WriteLine(":::::::::::::::::::");
        Console.WriteLine("   Please input any letter to start");
        Console.WriteLine(":::::::::::::::::::");
        starter = char.Parse(Console.ReadLine());

    }
    public static void explained(){
    Console.Clear();
    Console.WriteLine("-press number 1 - 3 to making a track- ");
    Console.WriteLine("Then Press 'p' to play");
    }
    public void PrintMainMenuScreen(){
        Console.Clear();
        PrintStartingMenu();
    }
    public void PrintStartingMenu(){
    Console.Clear();
    Console.WriteLine(":::::::::::::::::::");
    Console.WriteLine("Welcome to Mucsic player");
    Console.WriteLine("1.Log in");
    Console.WriteLine("2.Track Player");
    Console.WriteLine(":::::::::::::::::::");
    }
    public static void InputFromKeyboard(){
    Console.WriteLine("Choose: \n");
    Menu menu = (Menu)(int.Parse(Console.ReadLine()));
    PrintMainMenu(menu);
    }
    public static void PrintMainMenu(Menu menu){
     switch(menu){
       case Menu.Login :
       ShowLoginMenu();
       break;
       case Menu.MusicPlayer:
       ShowMusicPlayer();
       break;
       default:
       break;
        }
    }
    public static void ShowLoginMenu(){
        Console.Clear();
        Console.WriteLine("Login Menu");
        Console.WriteLine("1.Email Login \n 2.Guest Login");
        Console.WriteLine("Choose:");
        LoginMenu submenu = (LoginMenu)(int.Parse(Console.ReadLine()));
        PrintLoginMenu(submenu);
    }
    public static void PrintLoginMenu(LoginMenu submenu){
        switch(submenu){
            case LoginMenu.EmailLogin:
            ShowEmailLogin();
            break;
            case LoginMenu.GuestLogin:
            ShowGuestLogin();
            break;
            default:
            break;
        }
    }
    public static void ShowEmailLogin(){

    }
    public static void ShowGuestLogin(){

    }
    public static void ShowMusicPlayer(){

    }
    public static void inputCommand(){
        char Command;
        if(starter != '+'){
              Console.WriteLine("Please Input play order: ");

        Command = char.Parse(Console.ReadLine());
        CircularLinkedList<char> Playlist = new CircularLinkedList<char>();
        while(Command == '1'|| Command == '2'|| Command == '3')
        { // ยังไม่เสด

        }
        }
    }
}
