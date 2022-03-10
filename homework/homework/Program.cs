using System;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            int element = 34;
            AddItem(ref array, element);
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            string sentence = Console.ReadLine();
            Deleter(ref sentence);
            Console.WriteLine(sentence);
        }
        static void Deleter(ref string sentence)
        {
            string newStr = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                    newStr += sentence[i];
            }
            sentence = newStr;
        }
        static void AddItem(ref int[] array,int element)
        {
            int length = array.Length;
            int newlength = length + 1;
            int[] newArr = new int[newlength];
            for (int i = 0;i<array.Length;i++)
            {
                newArr[i] = array[i];
            }
            newArr[newArr.Length-1] = element;
            array = newArr;
        }


    }
}
