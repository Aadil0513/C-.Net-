namespace secondDay.Models;


public class UserProfile
{
    public string FullName { get; set; } = string.Empty;
    public string? NickName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? City { get; set; }
    public decimal Balance { get; set; }

    public string GetUpperNickName()
    {
        return NickName?.ToUpper() ?? "N/A";
    }
}