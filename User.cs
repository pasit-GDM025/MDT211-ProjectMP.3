class User{
    private string Email;
    private string Password;
    public User ( string Email, string Password){
        this.Email = Email;
        this.Password = Password;
    }
    public string GetEmail(){
        return this.Email;
    }
    public string GetPassword(){
        return this.Password;
    }
}