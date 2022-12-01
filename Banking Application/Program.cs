namespace Banking_Application
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Person person1 = new Person("aaa", "bbb", 69);
            Account acc1 = new Account(123456789, "asdfasdf");

            person1.Accounts.Add(acc1);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}