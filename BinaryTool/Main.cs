using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinaryTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnBinary2String_Click(object sender, EventArgs e)
        {
            txtString.Text = "";
            string str = Decode(txtBinary.Text);
            txtString.Text = str;
        }

        
        
        
        private void btnString2Binary_Click(object sender, EventArgs e)
        {
            txtBinary.Text = "";
            string binaryStr = Encode(txtString.Text);
            txtBinary.Text = binaryStr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBinary.Text = "";
            txtString.Text = "";
        }


        private string myEncode(string text)
        {
            byte[] binaryBytes = System.Text.Encoding.UTF8.GetBytes(text);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in binaryBytes)
            {
                // 将8位无符号数转为二进制
                string binary = Convert.ToString(b, 2);
                // 位数不足8位的，前面用0补全
                binary = binary.Insert(0, new string('0', 8 - binary.Length));
                sb.Append(binary);
            }

            return sb.ToString();
        }

       
        /// <summary>
        /// 将字符串转成二进制
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string Encode(string s)
        {
            byte[] data = Encoding.UTF8.GetBytes(s.Replace(" ", ""));
            StringBuilder result = new StringBuilder(data.Length * 8);
            
            foreach (byte b in data)
            {
                result.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }
            return result.ToString();
        }

        /// <summary>
        /// 将二进制转成字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string Decode(string s)
        {
            System.Text.RegularExpressions.CaptureCollection cs =
                System.Text.RegularExpressions.Regex.Match(s, @"([01]{8})+").Groups[1].Captures;
            byte[] data = new byte[cs.Count];
            for (int i = 0; i < cs.Count; i++)
            {
                data[i] = Convert.ToByte(cs[i].Value, 2);
            }
            return Encoding.UTF8.GetString(data, 0, data.Length);
        }
    }
}
