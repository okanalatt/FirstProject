namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args) // Main method is the entry point of the program
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Press any key to exit..\n.");
            Console.WriteLine(true); // Outputs 'True' to the console
            Console.WriteLine(false); // Outputs 'False' to the console
            Console.WriteLine(10.7 + 2.2); // Outputs the result of the addition (12.9) to the console
            Console.WriteLine(10 / 2); // Outputs the result of the division (5) to the console
            Console.WriteLine(32 * 5); // Outputs the result of the multiplication (160) to the console
            Console.Read(); // Waits for user input before closing the console window
        }
    }
}
// Scope {}
/*
 Yazacagımız kodlar bir class ın içerisinde ki methodlara yazılır.
    Namespace, class ve methodlar programın yapısını belirler.
        Namespace-> class-> method-> kodlar

C# Programlama dilinde kodlar, genellikle bir sınıf (class) içinde tanımlanır.Sınıflar, programın yapısını ve işlevselliğini belirler.
// Namespace, sınıfları gruplamak ve ad alanlarını yönetmek için kullanılır. Programın ana giriş noktası olan Main metodu, uygulamanın başlangıç noktasını belirler. Bu metot içinde yazılan kodlar, programın çalışması sırasında yürütülür. Console.WriteLine() gibi komutlar, konsola çıktı vermek için kullanılır. Console.ReadLine() ve Console.ReadKey() ise kullanıcıdan girdi almak veya programın sonlanmasını beklemek için kullanılır
// C# dilinde kodlar, genellikle bir sınıf (class) içinde tanımlanır. Sınıflar, programın yapısını ve işlevselliğini belirler. Namespace, sınıfları gruplamak ve ad alanlarını yönetmek için kullanılır. Programın ana giriş noktası olan Main metodu, uygulamanın başlangıç noktasını belirler. Bu metot içinde yazılan kodlar, programın çalışması sırasında yürütülür. Console.WriteLine() gibi komutlar, konsola çıktı vermek için kullanılır. Console.ReadLine() ve Console.ReadKey() ise kullanıcıdan girdi almak veya programın sonlanmasını beklemek için kullanılır.

 */
