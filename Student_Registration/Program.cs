namespace Student_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- ВЪВЕДЕТЕ ДАННИ ЗА УЧЕНИК ---");

            string name = ReadString("Име: ");
            int age = ReadInt("Възраст (6-20): ");
            int grade = ReadInt("Клас (1-12): ");
            double avgScore = ReadDouble("Среден успех (2.00-6.00): ");
            decimal fee = ReadDecimal("Такса: ");
            bool scholarship = ReadBool("Получава ли стипендия (true/false): ");
            char classLetter = ReadChar("Паралелка (буква): ");
            DateTime birthDate = ReadDate("Дата на раждане (dd.MM.yyyy): ");
        }
    }
}
