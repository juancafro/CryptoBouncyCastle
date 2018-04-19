using FileEncryptionTasks.Helpers.PGP;
using System;

namespace bouncyCastleTest
{
    class Program
    {
        private static string recipientKeyFileName;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = "C:\\Users\\juancamilo\\source\\repos\\bouncyCastleTest\\bouncyCastleTest\\files\\";
            //string inputFileName = path+"ATH_20180308_BOCC_1.txt.pgp";
            string privateKeyFileName = path+ "elibom-pgp.asc.pri";
            string passPhrase = "Masivian2018Decrypt";
            string inputFileName = "CryptedFile";
            string outputFileName = "decryptedAgain";
            bool shouldArmor = true;
            string recipientKeyFileName = path+"elibom-pgp.asc.pri";
            bool shouldCheckIntegrity = true;

            //PGPEncryptDecrypt.Decrypt(inputFileName,
            //              privateKeyFileName,
            //              passPhrase,
            //              outputFileName);

            PGPEncryptDecrypt.EncryptFile(inputFileName,
                              outputFileName,
                              recipientKeyFileName,
                              shouldArmor,
                              shouldCheckIntegrity);

        }
    }
}
