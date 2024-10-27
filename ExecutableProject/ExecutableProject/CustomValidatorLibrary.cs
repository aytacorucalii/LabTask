namespace CustomValidatorLibrary
{
    public class Validator
    {
        public bool ValidateUserName(string username)
        {
            return username.Length >= 2;
        }

        public bool ValidatePassword(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsDigit) &&
                   password.Any(char.IsSymbol) &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower);
        }

        public bool ValidateName(string name)
        {
            return name.Length >= 2;
        }

        public bool ValidateSurname(string surname)
        {
            return surname.Length >= 2;
        }

        public bool ValidateAge(int age)
        {
            return age > 0 && age <55;
        }

        public bool ValidateBirthday(DateTime birthday)
        {
            return birthday.Year >= 1970;
        }
    }
}
