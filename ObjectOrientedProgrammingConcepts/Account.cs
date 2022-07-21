namespace ObjectOrientedProgrammingConcepts;

public class Account
{
    private int _failedLoginAttempts = 0;
    private string _password;

    public Account (string password)
    {
        _password = password;
    }

    public bool Login(string password)
    {
        bool passwordsMatch = password.Equals(_password);
        if (!passwordsMatch)
        {
            _failedLoginAttempts++;
        }

        bool loginFailed = !passwordsMatch || _failedLoginAttempts >= 3;
        if (loginFailed)
        {
            Console.WriteLine($"Login Failed, {_failedLoginAttempts} Failed Attempts");
        } else
        {
            _failedLoginAttempts = 0;
        }

        return !loginFailed;
    }
}
