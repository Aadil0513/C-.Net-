using System.ComponentModel.DataAnnotations;

using secondDay.Models;

Console.WriteLine("Hello, World!");

string?  rawName = "Aadil";
string? rawNickName = null;

     rawNickName= "Aadiiiiii" ;
string? rawPhone = null ;

rawPhone = "0310123456";

decimal walletBalance = 1500.50m;

string cleanName = rawName?.Trim();

string displayName = string.IsNullOrWhiteSpace(cleanName) ? "Guest User" : cleanName;

string city= "Isb" ;

rawNickName ??= "Not provided";

rawPhone ??=   "Not Provided" ;

var phoneLength = rawPhone?.Length ?? 0;

UserProfile?  profile = new UserProfile
{
    
    FullName = displayName,
    PhoneNumber = rawPhone,
    Balance = walletBalance,
    NickName = rawNickName,
    City =city

};


string upperNickname = profile?.NickName?.ToUpper() ?? "N/A";

Console.WriteLine($"Name: {profile?.FullName}");
Console.WriteLine($"Nickname: {upperNickname}");
Console.WriteLine($"Phone: {profile?.PhoneNumber} (Chars: {phoneLength})");
Console.WriteLine($"Balance: PKR {profile?.Balance:N2}");

Console.WriteLine($"City : {profile?.City}");

UserProfile? emptyProfile = null;

Console.WriteLine($"Empty Profile City: {emptyProfile?.City ?? "Karachi (Default)"}");







