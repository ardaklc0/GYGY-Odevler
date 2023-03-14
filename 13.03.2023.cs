/*
 * 1. En az 6 karakter
 * 2. Sadece harf ya da sadece sayı ya da sadece alfa-nümerik olan ise zayıf şifre 
 * 3. Hem harf hem sayı ise orta
 * 4. Hem sayı, hem harf hem de alfa-nümerik olmayan bir karakter varsa güçlü   
 * şifre desin
 * ipucu:
 * char.
 */


using System.Diagnostics.SymbolStore;

string password = getPassword();
bool passwordValidation = isPasswordValid(password);
onlyDigitPassword(password, passwordValidation);
bool isWeak = onlyDigitPassword(password, passwordValidation);
isWeak = onlyLetterPassword(password, passwordValidation, isWeak);
isWeak = onlyNonAlphaNumericPassword(password, passwordValidation, isWeak);
(isWeak, bool isMedium) = digitOrLetterPassword(password, passwordValidation, isWeak);
(isWeak, isMedium, bool isStrong) = digitOrLetterOrNonAlphNumbericPassword(password, passwordValidation, isWeak, isMedium);
showPowerOfPassword(isWeak, isMedium, isStrong);



string getPassword() 
{
    Console.WriteLine("Enter a password: ");
    string password = Console.ReadLine();
    return password;
}

bool isPasswordValid(string password) 
{
    bool validPassword = false;
    if (password.Length >= 6)
    {
        validPassword = true;
    }
    Console.WriteLine(validPassword ? "Password has length 6 or more" : "Invalid Password");
    return validPassword;
}

bool onlyDigitPassword(string password, bool validation) 
{
    bool isWeak = false;
    if (validation)
    {
        foreach (char letter in password)
        {
            if (char.IsDigit(letter))
            {
                isWeak = true;
            }
            else
            {
                isWeak = false;
                break;
            }
        }
    }
    return isWeak;
}

bool onlyLetterPassword(string password, bool validation, bool isWeak)
{
    if (isWeak)
    {
        return isWeak;
    }
    else
    {
        if (validation)
        {
            foreach (char letter in password)
            {
                if (char.IsLetter(letter))
                {
                    isWeak = true;
                }
                else
                {
                    isWeak = false;
                    break;
                }
            }
        }
    }
    return isWeak;
}

bool onlyNonAlphaNumericPassword(string password, bool validation, bool isWeak)
{
    if (isWeak)
    {
        return isWeak;
    }
    else
    {
        if (validation)
        {
            foreach (char letter in password)
            {
                if (!char.IsLetter(letter) && !char.IsDigit(letter))
                {
                    isWeak = true;
                }
                else
                {
                    isWeak = false;
                    break;
                }
            }
        }
    }
    return isWeak;
}

(bool, bool) digitOrLetterPassword(string password, bool validation, bool isWeak)
{
    bool isMedium = false;
    if (isWeak)
    {
        return (isWeak, isMedium);
    }
    else
    {
        if (validation)
        {
            foreach (char letter in password)
            {
                if (char.IsLetter(letter) || char.IsDigit(letter))
                {
                    isWeak = false;
                    isMedium = true;
                }
                else
                {
                    isWeak = false;
                    isMedium = false;
                    break;
                }
            }
        }
    }
    return (isWeak, isMedium);
}

(bool, bool, bool) digitOrLetterOrNonAlphNumbericPassword(string password, bool validation, bool isWeak, bool isMedium) 
{
    bool isStrong = false;
    if (isWeak)
    {
        return (isWeak, isMedium, isStrong);
    }
    else if (isMedium)
    {
        return (isWeak, isMedium, isStrong);
    }
    else
    {
        if (validation)
        {
            foreach (char letter in password)
            {
                if (char.IsLetter(letter) || char.IsDigit(letter) || (!char.IsLetter(letter) && !char.IsDigit(letter)))
                {
                    isWeak = false;
                    isMedium = false;
                    isStrong = true;
                }
                else
                {
                    isWeak = false;
                    isMedium = false;
                    isStrong = false;
                    break;
                }
            }
        }
    }
    return (isWeak, isMedium, isStrong);
}

void showPowerOfPassword(bool isWeak, bool isMedium, bool isStrong)
{
    if (isWeak)
    {
        Console.WriteLine("Weak Password");
    }
    else if (isMedium)
    {
        Console.WriteLine("Medium Password");
    }
    else
    {
        Console.WriteLine("Strong Password");
    }
} 
