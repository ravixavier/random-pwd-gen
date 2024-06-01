class Program
{
    static void Main(string[] args)
    {
        string charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!#$%&'()*+-<>?@^_";
        //char set usado para escrever a senha, todos os possíveis characteres aceitos.
        int pwdLength = 12;
        //tamanho da senha.
        string randomPwd = GetRandomCharacters(charSet, pwdLength);
        //string randomPassword que recebe uma função?(metodo?) com dois parametros informando
        //todos os possíveis characteres utilizados na senha e o tamanho da senha.
        Console.WriteLine(randomPwd);
    }

    static string GetRandomCharacters(string input, int count)
    {
        Random random = new Random();
        char[] result = new char[count];
        int inputLength = input.Length;

        for (int i = 0; i < count; i++)
        {
            int randomIndex = random.Next(inputLength);
            result[i] = input[randomIndex];
        }

        return new string(result);
    }
}