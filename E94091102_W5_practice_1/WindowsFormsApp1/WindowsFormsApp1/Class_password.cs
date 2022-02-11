using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Password
    {
        public String [] Alphabet_Array = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public String Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public String[] Generate_Array = new string[52];
        public string Generate_Alphabet;
        public int[] Number_Array = new int[52];
        public String History;
        public String Decrypt_Input;
        public String Decrypt_output;
        public String Generate()
        {
            String Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            String[] Generate_Array = new string[52];
            int[] Number_Array = new int[52];
            for (int i = 0; i < 52; i++)
            {

                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                Number_Array[i] = rnd.Next(0, 52);
                for (int j = 0; j < i; j++)
                {
                    while (Number_Array[j] == Number_Array[i])    
                    {
                        j = 0; 
                        Number_Array[i] = rnd.Next(0, 52); 
                    }
                }
            }
            for (int i = 0; i < 52; i++)
            {
                Generate_Array[i] = Alphabet_Array[Number_Array[i]];
            }

            String Generate = String.Join("", Generate_Array);
            return Generate;
        }
        public String Check( String text)
        {
            String Result;
            if (text.Length > 52)
            {
                Result = "替換表不合法，請重新輸入";
            }
            for (int i = 0; i < text.Length; i++)
            {
                Generate_Array[i] = text.Substring(i, 1);
            }
            MessageBox.Show(String.Join("", Generate_Array));
            if (text.Equals(Alphabet, StringComparison.Ordinal))
            {
                Result = "合法替換表";
                MessageBox.Show("合法替換表");
            }
            else
            {
                Result = "替換表不合法，請重新輸入";
                MessageBox.Show("替換表不合法，請重新輸入2");
                text = "";
            }
            return Result;
        }
        public bool Equal(string text1)
        {
            Alphabet_Array = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            return false;
        }
        public String Encrypt(String input, String form)
        {
            String Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            foreach ( char c in input)
            {
                int index = Alphabet.IndexOf(c);
                char form_char = Convert.ToChar(form);
                string k = Convert.ToString(index);
                MessageBox.Show(k);
            }
            String output = "";
            return output;
        }
    }
}
