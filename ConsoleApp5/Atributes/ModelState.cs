using ConsoleApp5.Atributes;
using System.Reflection;
using System.Text.RegularExpressions;

public class ModelState
{
    public static bool IsValid(object entity)
    {
        foreach (PropertyInfo item in entity.GetType().GetProperties())
        {
            if (Attribute.IsDefined(item, typeof(EmailValidate)))
            {
                var email = item.GetValue(entity).ToString();
                var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!regex.IsMatch(email))
                {
                    return false;
                }
            }
            if (Attribute.IsDefined(item, typeof(PasswordValidate)))
            {
                var password = item.GetValue(entity).ToString();
                var regexx = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[A-Za-z\\d@$!%*?&]{8,}");
                if (!regexx.IsMatch(password))
                {
                    return false;
                }
            }
        }
        return true;
    }
}
