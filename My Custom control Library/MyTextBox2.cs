using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Custom_control_Library
{
    public partial class MyTextBox2 : TextBox
    {
        public MyTextBox2()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public bool IsRequired { get; set; }
        public enum enInPutType { Number, Text };
        public enInPutType InPutType { get; set; }

        private bool IsNumeric()
        {
            string S = this.Text.Trim();
            foreach (char c in S)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsValid()
        {
            if (IsRequired)
            {
                if (this.Text.Trim().Length == 0)
                {
                    return false;
                }
            }
            if (InPutType == enInPutType.Number)
            {
                return IsNumeric();
            }
            return true;

        }
    }
}
