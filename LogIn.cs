using System;
class LogIn {
    public static void Loginstartup()
    {
        userLogin();
    }
    public static void userLogin()
    {
        string email, password, inputemail, inputpassword;
        email = "kmutt@gmail.com"; //Check Email จากค่าอันนี้
        password = "123456";   //Check Password จากอันนี้
        User user = new User(email,password);
        Console.WriteLine("--------------------------");
        Console.Write("Email : ");
        inputemail = Console.ReadLine();
        Console.Write("Password :");
        inputpassword = Console.ReadLine();
        Console.WriteLine("--------------------------");
        
        if( email == inputemail) //check email
            {
            if(password == inputpassword) //check password
                {
                    Console.WriteLine("Log in!!");// เข้าสู่หน้า Menu หลักได้ผ่านตรงนี้
                }
            else
                {
                    Console.WriteLine("Account or Password Wrong"); // ไม่มี Account เด้งออกจากโปรแกรม หรือกลับไปเริ่มใหม่
                }
            }
        else
            {
                Console.WriteLine("Account or Password Wrong"); // ไม่มี Account เด้งออกจากโปรแกรม หรือกลับไปเริ่มใหม่
            }   
    }
    public static void GuestLogIn(){
        string GuestName;
        Console.Clear();
        Console.WriteLine(":::::::::::::::");
        Console.WriteLine("Guest Name for log in :");
        GuestName = Console.ReadLine();
        Console.WriteLine(":::::::::::::::");
    }
}