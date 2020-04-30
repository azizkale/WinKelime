using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace WinKelime
{
    public static class TDKIslemleri
    {
        public static ArrayList dizitdk;
        static string klm;
        public static void tdkyukleme(TextBox tbox)
        {
            StreamReader reader = new StreamReader("C:\\WinKelime\\WinKelime\\bin\\Debug\\asd.txt", Encoding.GetEncoding("windows-1254"));
            tbox.Text = reader.ReadToEnd();

            dizitdk = new ArrayList();

            foreach (string item in tbox.Lines)
            {
                foreach (char itm in item)
                {
                    if (itm == ' ' || itm == ',' || itm == '(' || itm == ')')
                        break;
                    if (itm == 'â')
                    {
                        klm += 'a';
                        continue;
                    }
                    if (itm == 'î')
                    {
                        klm += 'i';
                        continue;
                    }
                    else
                        klm += itm;
                }

                dizitdk.Add(klm.ToUpper());
                klm = "";
            }
        }
    }
}
