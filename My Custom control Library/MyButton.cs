using My_Custom_control_Library.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace My_Custom_control_Library
{
    public partial class CustomControl2 : Button
    {
        public CustomControl2()
        {
            InitializeComponent();
            this.TextAlign = ContentAlignment.MiddleRight;
            this.Width = 90;
            this.Height = 34;
            this.Font = new Font("Microsoft Sans Serif", 12);
            this.FlatStyle = FlatStyle.Flat;
            this.ImageAlign= ContentAlignment.MiddleLeft;
            
            
        }

        //protected override void OnPaint(PaintEventArgs pe)
        //{
        //    base.OnPaint(pe);
        //}

        public enum enButtonText { Save,Close,Next,Back};
        enButtonText _ButtonText=enButtonText.Save;
        public enButtonText ButtonText
        {
            get { return _ButtonText; }
            set
            {
                _ButtonText = value;
                switch (value)
                {
                    case enButtonText.Save:
                        this.Text = "Save";
                        
                        
                        
                        
                        break;
                    case enButtonText.Close:
                        this.Text = "Close";
                        break;
                    case enButtonText.Next:
                        this.Text = "Next";
                        break;
                    case enButtonText.Back:
                        this.Text = "Back";
                        break;
                }
            }
        }

            



    }
}
