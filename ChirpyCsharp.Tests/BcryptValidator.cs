using System.Text.RegularExpressions;

namespace ChirpyCsharp.Tests;

public partial class BcryptValidator
{
    private static Regex _bcryptValidatorRegex = BcryptValidatorRegex();

    public static bool IsValidBcryptHash(string hash)
    {
        if (string.IsNullOrWhiteSpace(hash)) return false;
        return _bcryptValidatorRegex.IsMatch(hash);
    }

    [GeneratedRegex(@"^\$2[abxy]\$\d{2}\$[./A-Za-z0-9]{53}$", RegexOptions.Compiled)]
    private static partial Regex BcryptValidatorRegex();
}