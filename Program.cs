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
       int StartMenuinput;
         PrintStartingMenu();
         StartMenuinput = int.Parse(Console.ReadLine());
         if(StartMenuinput == 1){
            ShowLoginMenu();
             explained();
               inputCommand();
            }
         if(StartMenuinput == 2){
            starting();
             if(starter != '+')
             {
               explained();
               inputCommand();
             }
             else{
              explained();
              inputCommand();
             }
         }
    }
    public static void starting(){
        Console.Clear();
        Console.WriteLine(":::::::::::::::::::");
        Console.WriteLine("   Please input any letter to start");
        Console.WriteLine(":::::::::::::::::::");
        starter = char.Parse(Console.ReadLine());
    }
    public static void explained(){
    Console.WriteLine(" - ");
    Console.WriteLine("-press number 1 - 3 to making a track- ");
    Console.WriteLine("Then Press 'p' to play");
    }
    public static void PrintMainMenuScreen(){
        Console.Clear();
         explained();
               inputCommand();
    }
    public static void PrintStartingMenu(){
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
        LogIn.userLogin();
        Console.Clear();
        PrintMainMenuScreen();
    }
    public static void ShowGuestLogin(){
        LogIn.GuestLogIn();
        Console.Clear();
        PrintMainMenuScreen();
    }
    public static void ShowMusicPlayer(){
        Console.WriteLine(":::::::::::::::::::");
        Console.WriteLine("This is music player Enjoy!");
        Console.WriteLine(":::::::::::::::::::");
        Player.MusicPlayer.TrackPlayer();
    }
    public static void inputCommand(){
        char Command = '+';
        if(starter != '+'){
            Console.WriteLine("Input number 1 to start playlist");
              Console.WriteLine("Please Input play order: ");

        Command = char.Parse(Console.ReadLine());
        CircularLinkedList<char> Playlist = new CircularLinkedList<char>();
        while(Command == '1'|| Command == '2'|| Command == '3'||Command == '+')
        { 
            Command = char.Parse(Console.ReadLine());
            if(Command == '1'){
               Playlist.Push('1');
            }
            if(Command == '2'){
               Playlist.Push('2');
            }
            if(Command == '3'){
                Playlist.Push('3');
            }
        }
        for(int x = 0;x<=Playlist.GetLength();x++){
            if(Playlist.Get(x) == '1'){
                Console.WriteLine("Playing 1 ....");
                Player.MusicPlayer.TrackPlayer();
            }
            if(Playlist.Get(x) == '2'){
                Console.WriteLine("Playing 2 ....");
                 Player.MusicPlayer.TrackPlayer2();
            }
            if(Playlist.Get(x) == '3'){
                Console.WriteLine("Playing 3 ....");
                 Player.MusicPlayer.TrackPlayer3();
            }
        }
    }
}
}