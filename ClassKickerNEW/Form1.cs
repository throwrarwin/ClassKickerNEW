using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Flood;

namespace ClassKickerNEW
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        
        // Basically "OnLoad"
        private void Form1_Load(object sender, EventArgs e)
        {
            Color background = System.Drawing.Color.FromArgb(57, 62, 70);
            Color textCol = System.Drawing.Color.FromArgb(238, 238, 238);
            Color tools = System.Drawing.Color.FromArgb(0, 173, 181);
        }


        //  Textboxes
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox2_KeyPress(object sender, EventArgs e)
        {
            textBox2.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.CharacterCasing = CharacterCasing.Upper;
        }


        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();



        // Tabcontrol / Buttons for tabs

        private void tabControl1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            TabPage CurrentTab = tabControl1.TabPages[e.Index];
            Rectangle ItemRect = tabControl1.GetTabRect(e.Index);
            SolidBrush FillBrush = new SolidBrush(Color.FromArgb(57, 62, 70));
            SolidBrush TextBrush = new SolidBrush(Color.FromArgb(0, 173, 181));
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //If we are currently painting the Selected TabItem we'll
            //change the brush colors and inflate the rectangle.
            if (System.Convert.ToBoolean(e.State & DrawItemState.Selected))
            {
                FillBrush.Color = Color.FromArgb(57, 62, 70); ;
                TextBrush.Color = Color.FromArgb(0, 173, 181);
                ItemRect.Inflate(2, 2);
            }

            //Set up rotation for left and right aligned tabs
            if (tabControl1.Alignment == TabAlignment.Left || tabControl1.Alignment == TabAlignment.Right)
            {
                float RotateAngle = 90;
                if (tabControl1.Alignment == TabAlignment.Left)
                    RotateAngle = 270;
                PointF cp = new PointF(ItemRect.Left + (ItemRect.Width / 2), ItemRect.Top + (ItemRect.Height / 2));
                e.Graphics.TranslateTransform(cp.X, cp.Y);
                e.Graphics.RotateTransform(RotateAngle);
                ItemRect = new Rectangle(-(ItemRect.Height / 2 ), -(ItemRect.Width / 2), ItemRect.Height, ItemRect.Width);
            }

            //Next we'll paint the TabItem with our Fill Brush
            e.Graphics.FillRectangle(FillBrush, ItemRect);

            //Now draw the text.
            e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, (RectangleF)ItemRect, sf);

            //Reset any Graphics rotation
            e.Graphics.ResetTransform();

            //Finally, we should Dispose of our brushes.
            FillBrush.Dispose();
            TextBrush.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        async private void button1_Click(object sender, EventArgs e)
        {
            decimal botCount = numericUpDown1.Value;
            string classcode = textBox1.Text;
            string botName = textBox4.Text;



            await ClassKick.SendFlood(botCount, classcode, botName);
        }

        async private void button2_Click(object sender, EventArgs e)
        {
            string classcode = textBox2.Text;
            Debug.Write(classcode);
            await ClassKick.RickRoll(classcode);
        }
    }
}

