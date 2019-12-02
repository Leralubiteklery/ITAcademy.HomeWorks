using System;
//1.Добавить директиву Using System.IO для использования класса StreamReader.
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {

            //2.Использовать класс StreamReader для считывания текста из файла, с указанием пути к файлу.
            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);

            //3.Прочитать все символы из указанного файла и преобразовать их в строку(string).
            string textReaderResult = textReader.ReadToEnd();

            //4.Прекратить считывание символов из файла.
            textReader.Dispose();

            //5.Создать массив для хранения частей строки(substrings), полученных путем деления строки из шага 3 на разряды.
            string[] arrayOfTextResult = textReaderResult.Split(' ');

            //6.Создать массив для хранения байтов равный по длине массиву для хранения частей строки -1.
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            //7.Конвертировать части строки массива из шага 5 в байты.
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            //8.Создать файл, содержащий массив байтов, полученных после конвертации, в указанной директории.
            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
        }
    }
}