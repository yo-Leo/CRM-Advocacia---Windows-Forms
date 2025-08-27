using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CRM_Advocacia___Windows_Forms
{
    public class MetodoCoringa
    {

        public string RemoverMascara(string input)
        {

            return new string(input.Where(char.IsDigit).ToArray());

        }
    }
} 