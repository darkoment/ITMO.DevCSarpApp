using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Calculator
{
    public class Calc : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Button btn_sbros;
        private System.Windows.Forms.Button btn_Changesign;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_ravno;
        private System.Windows.Forms.Button btn_delenie;
        private System.Windows.Forms.Button btn_umnojenie;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private Button btn_Stepen;
        private Button btn_Koren;
        private Button btn_Obratnoe;
        private Button btn_Kvadrat;
        private Button btn_Close;
        private IContainer components;

        /// <summary>
        /// Объявляем и инициализируем переменные, которые будут
        ///  возникать на экране при нажатии соответствующих кнопок.
        /// </summary>
        private const string odin = "1";
        private const string dva = "2";
        private const string tri = "3";
        private const string chetire = "4";
        private const string pyat = "5";
        private const string shest = "6";
        private const string sem = "7";
        private const string vosem = "8";
        private const string devyat = "9";
        private MenuStrip menuCalc;
        private ToolStripMenuItem viewMenuItem1;
        private ToolStripMenuItem enginMenuItem2;
        private ToolStripMenuItem lightMenuItem3;
        private ToolStripMenuItem quesMenuItem4;
        public ToolTip toolTip1;
        //private EventHandler txtOutput_TextChanged;
        //private EventHandler btn_sbros_Click;
        //private EventHandler btnChangesign_Click;
        //private EventHandler btn2_Click;
        //private EventHandler btn3_Click;
        //private EventHandler btn4_Click;
        //private EventHandler btn5_Click;
        //private EventHandler btn6_Click;
        //private EventHandler btn8_Click;
        //private EventHandler btn9_Click;
        //private EventHandler btn0_Click;
        //private EventHandler btn_plus_Click;
        //private EventHandler btnpoint_Click;
        //private EventHandler btn_ravno_Click;
        //private EventHandler btn_umnojenie_Click;
        //private EventHandler btn_minus_Click;
        //private EventHandler btn_delenie_Click;
        //private EventHandler btn7_Click;
        //private EventHandler btn1_Click;
        //private PopupEventHandler toolTip1_Popup;
        private const string nul = "0";

        public EventHandler Stepen_Click { get; private set; }
        public EventHandler Koren_Click { get; private set; }
        public EventHandler Obratnoe_Click { get; private set; }
        public EventHandler Close_Click { get; private set; }
        public EventHandler Kvadrat_Click { get; private set; }

        public Calc()
        {
            InitializeComponent();
            // При запуске приложения на экране будет нуль
            txt_Output.Text = "0";

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.btn_sbros = new System.Windows.Forms.Button();
            this.btn_Changesign = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_ravno = new System.Windows.Forms.Button();
            this.btn_delenie = new System.Windows.Forms.Button();
            this.btn_umnojenie = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_Stepen = new System.Windows.Forms.Button();
            this.btn_Koren = new System.Windows.Forms.Button();
            this.btn_Obratnoe = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.menuCalc = new System.Windows.Forms.MenuStrip();
            this.viewMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enginMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lightMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.quesMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Kvadrat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Output
            // 
            this.txt_Output.AccessibleName = "Display";
            this.txt_Output.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Output.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Output.ForeColor = System.Drawing.Color.Purple;
            this.txt_Output.Location = new System.Drawing.Point(12, 47);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.ReadOnly = true;
            this.txt_Output.Size = new System.Drawing.Size(300, 30);
            this.txt_Output.TabIndex = 60;
            this.txt_Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Output.Click += new System.EventHandler(this.txt_Output_Click);
            // 
            // btn_sbros
            // 
            this.btn_sbros.AccessibleName = "reset";
            this.btn_sbros.Location = new System.Drawing.Point(268, 83);
            this.btn_sbros.Name = "btn_sbros";
            this.btn_sbros.Size = new System.Drawing.Size(48, 92);
            this.btn_sbros.TabIndex = 0;
            this.btn_sbros.Text = "C";
            this.btn_sbros.Click += new System.EventHandler(this.btn_sbros_Click_1);
            // 
            // btn_Changesign
            // 
            this.btn_Changesign.AccessibleName = "change sign";
            this.btn_Changesign.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Changesign.Location = new System.Drawing.Point(118, 222);
            this.btn_Changesign.Name = "btn_Changesign";
            this.btn_Changesign.Size = new System.Drawing.Size(48, 46);
            this.btn_Changesign.TabIndex = 58;
            this.btn_Changesign.Text = "+/-";
            this.btn_Changesign.Click += new System.EventHandler(this.btn_Changesign_Click_1);
            // 
            // btn_point
            // 
            this.btn_point.AccessibleName = "point ";
            this.btn_point.Location = new System.Drawing.Point(166, 222);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(48, 46);
            this.btn_point.TabIndex = 57;
            this.btn_point.Text = ",";
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click_1);
            // 
            // btn_ravno
            // 
            this.btn_ravno.AccessibleDescription = "ravno";
            this.btn_ravno.AccessibleName = "equal";
            this.btn_ravno.Location = new System.Drawing.Point(268, 175);
            this.btn_ravno.Name = "btn_ravno";
            this.btn_ravno.Size = new System.Drawing.Size(48, 93);
            this.btn_ravno.TabIndex = 56;
            this.btn_ravno.Text = "=";
            this.btn_ravno.Click += new System.EventHandler(this.btn_ravno_Click_1);
            // 
            // btn_delenie
            // 
            this.btn_delenie.AccessibleName = "divide ";
            this.btn_delenie.Location = new System.Drawing.Point(220, 83);
            this.btn_delenie.Name = "btn_delenie";
            this.btn_delenie.Size = new System.Drawing.Size(48, 46);
            this.btn_delenie.TabIndex = 55;
            this.btn_delenie.Text = "/";
            this.btn_delenie.Click += new System.EventHandler(this.btn_delenie_Click_1);
            // 
            // btn_umnojenie
            // 
            this.btn_umnojenie.AccessibleName = "multiply ";
            this.btn_umnojenie.Location = new System.Drawing.Point(220, 129);
            this.btn_umnojenie.Name = "btn_umnojenie";
            this.btn_umnojenie.Size = new System.Drawing.Size(48, 46);
            this.btn_umnojenie.TabIndex = 54;
            this.btn_umnojenie.Text = "*";
            this.btn_umnojenie.Click += new System.EventHandler(this.btn_umnojenie_Click_1);
            // 
            // btn_plus
            // 
            this.btn_plus.AccessibleName = "plus ";
            this.btn_plus.Location = new System.Drawing.Point(220, 222);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(48, 46);
            this.btn_plus.TabIndex = 53;
            this.btn_plus.Text = "+";
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click_1);
            // 
            // btn_minus
            // 
            this.btn_minus.AccessibleName = "minus ";
            this.btn_minus.Location = new System.Drawing.Point(220, 175);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(48, 47);
            this.btn_minus.TabIndex = 52;
            this.btn_minus.Text = "-";
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click_1);
            // 
            // btn_0
            // 
            this.btn_0.AccessibleName = "zero";
            this.btn_0.Location = new System.Drawing.Point(70, 222);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(48, 46);
            this.btn_0.TabIndex = 51;
            this.btn_0.Text = "0";
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click_1);
            // 
            // btn_9
            // 
            this.btn_9.AccessibleName = "nine ";
            this.btn_9.Location = new System.Drawing.Point(166, 83);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(48, 46);
            this.btn_9.TabIndex = 50;
            this.btn_9.Text = "9";
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.AccessibleName = "eight ";
            this.btn_8.Location = new System.Drawing.Point(118, 83);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(48, 46);
            this.btn_8.TabIndex = 49;
            this.btn_8.Text = "8";
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.AccessibleName = "seven ";
            this.btn_7.Location = new System.Drawing.Point(70, 83);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(48, 46);
            this.btn_7.TabIndex = 48;
            this.btn_7.Text = "7";
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click_1);
            // 
            // btn_6
            // 
            this.btn_6.AccessibleName = "six ";
            this.btn_6.Location = new System.Drawing.Point(166, 129);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(48, 46);
            this.btn_6.TabIndex = 47;
            this.btn_6.Text = "6";
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.AccessibleName = "five ";
            this.btn_5.Location = new System.Drawing.Point(118, 129);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(48, 46);
            this.btn_5.TabIndex = 46;
            this.btn_5.Text = "5";
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.AccessibleName = "four ";
            this.btn_4.Location = new System.Drawing.Point(70, 129);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(48, 46);
            this.btn_4.TabIndex = 45;
            this.btn_4.Text = "4";
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_3
            // 
            this.btn_3.AccessibleName = "three ";
            this.btn_3.Location = new System.Drawing.Point(166, 175);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(48, 47);
            this.btn_3.TabIndex = 44;
            this.btn_3.Text = "3";
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.AccessibleName = "two ";
            this.btn_2.Location = new System.Drawing.Point(118, 175);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(48, 47);
            this.btn_2.TabIndex = 43;
            this.btn_2.Text = "2";
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.AccessibleName = "one ";
            this.btn_1.Location = new System.Drawing.Point(70, 175);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(48, 47);
            this.btn_1.TabIndex = 42;
            this.btn_1.Text = "1";
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_Stepen
            // 
            this.btn_Stepen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Stepen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Stepen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stepen.ForeColor = System.Drawing.Color.Teal;
            this.btn_Stepen.Location = new System.Drawing.Point(12, 83);
            this.btn_Stepen.Name = "btn_Stepen";
            this.btn_Stepen.Size = new System.Drawing.Size(52, 46);
            this.btn_Stepen.TabIndex = 61;
            this.btn_Stepen.Text = "2^n";
            this.btn_Stepen.UseVisualStyleBackColor = false;
            this.btn_Stepen.Click += new System.EventHandler(this.btn_Stepen_Click);
            // 
            // btn_Koren
            // 
            this.btn_Koren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Koren.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Koren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Koren.ForeColor = System.Drawing.Color.Teal;
            this.btn_Koren.Location = new System.Drawing.Point(12, 129);
            this.btn_Koren.Name = "btn_Koren";
            this.btn_Koren.Size = new System.Drawing.Size(52, 46);
            this.btn_Koren.TabIndex = 62;
            this.btn_Koren.Text = "V";
            this.btn_Koren.UseVisualStyleBackColor = false;
            this.btn_Koren.Click += new System.EventHandler(this.btn_Koren_Click);
            // 
            // btn_Obratnoe
            // 
            this.btn_Obratnoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Obratnoe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Obratnoe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Obratnoe.ForeColor = System.Drawing.Color.Teal;
            this.btn_Obratnoe.Location = new System.Drawing.Point(12, 175);
            this.btn_Obratnoe.Name = "btn_Obratnoe";
            this.btn_Obratnoe.Size = new System.Drawing.Size(52, 47);
            this.btn_Obratnoe.TabIndex = 63;
            this.btn_Obratnoe.Text = "1/x";
            this.btn_Obratnoe.UseVisualStyleBackColor = false;
            this.btn_Obratnoe.Click += new System.EventHandler(this.btn_Obratnoe_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.ForeColor = System.Drawing.Color.Green;
            this.btn_Close.Location = new System.Drawing.Point(57, 278);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(259, 31);
            this.btn_Close.TabIndex = 64;
            this.btn_Close.Text = "Закрыть калькулятор";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // menuCalc
            // 
            this.menuCalc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuCalc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenuItem1,
            this.quesMenuItem4});
            this.menuCalc.Location = new System.Drawing.Point(0, 0);
            this.menuCalc.Name = "menuCalc";
            this.menuCalc.Size = new System.Drawing.Size(330, 28);
            this.menuCalc.TabIndex = 65;
            this.menuCalc.Text = "menuStrip1";
            // 
            // viewMenuItem1
            // 
            this.viewMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enginMenuItem2,
            this.lightMenuItem3});
            this.viewMenuItem1.Name = "viewMenuItem1";
            this.viewMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.viewMenuItem1.Text = "Вид";
            // 
            // enginMenuItem2
            // 
            this.enginMenuItem2.Name = "enginMenuItem2";
            this.enginMenuItem2.Size = new System.Drawing.Size(186, 26);
            this.enginMenuItem2.Text = "Инженерный";
            // 
            // lightMenuItem3
            // 
            this.lightMenuItem3.Name = "lightMenuItem3";
            this.lightMenuItem3.Size = new System.Drawing.Size(186, 26);
            this.lightMenuItem3.Text = "Стандартный";
            // 
            // quesMenuItem4
            // 
            this.quesMenuItem4.Name = "quesMenuItem4";
            this.quesMenuItem4.Size = new System.Drawing.Size(81, 24);
            this.quesMenuItem4.Text = "Справка";
            // 
            // btn_Kvadrat
            // 
            this.btn_Kvadrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Kvadrat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Kvadrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kvadrat.ForeColor = System.Drawing.Color.Teal;
            this.btn_Kvadrat.Location = new System.Drawing.Point(12, 225);
            this.btn_Kvadrat.Name = "btn_Kvadrat";
            this.btn_Kvadrat.Size = new System.Drawing.Size(52, 47);
            this.btn_Kvadrat.TabIndex = 66;
            this.btn_Kvadrat.Text = "n^2";
            this.btn_Kvadrat.UseVisualStyleBackColor = false;
            this.btn_Kvadrat.Click += new System.EventHandler(this.btn_Kvadrat_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Tag = "Stepen";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Stepen";
            // 
            // Calc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(330, 321);
            this.Controls.Add(this.btn_Kvadrat);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Obratnoe);
            this.Controls.Add(this.btn_Koren);
            this.Controls.Add(this.btn_Stepen);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.btn_sbros);
            this.Controls.Add(this.btn_Changesign);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_ravno);
            this.Controls.Add(this.btn_delenie);
            this.Controls.Add(this.btn_umnojenie);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.menuCalc);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuCalc;
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.Opacity = 0.77D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор 1.0";
            this.TopMost = true;
            this.menuCalc.ResumeLayout(false);
            this.menuCalc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Calc());
        }
        /// <summary>
        /// Обработчики для кнопок  обращаются к методу chislonaEkrane класса mehanizmcalkulyatora
        /// и передают ему одну из постоянных (odin, dva, tri  и т.д.). Результат, возвращаемый методом,
        /// присваивается  свойству Text текстового поля txtOutput.
        /// </summary>

        private void btn_1_Click(object sender, System.EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.chislonaEkrane(odin);
        }
        private void btn_7_Click_1(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.chislonaEkrane(sem);
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.chislonaEkrane(shest);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.chislonaEkrane(dva);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.chislonaEkrane(devyat);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.chislonaEkrane(pyat);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.chislonaEkrane(vosem);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.chislonaEkrane(chetire);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.chislonaEkrane(tri);
        }

        private void btn_0_Click_1(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.chislonaEkrane(nul);
        }


        /// <summary>
        /// Обработчики кнопок действия калькулятора передают 
        /// методу DeystvieCalculatora класса mehanizmcalkulyatora переменную перечисления Deystvie.
        /// </summary>



        private void btn_plus_Click_1(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Slojenie);
        }

        private void btn_minus_Click_1(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Vichitanie);
        }

        private void btn_umnojenie_Click_1(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Umnojenie);
        }

        private void btn_delenie_Click_1(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Delenie);
        }

 

        private void btn_sbros_Click_1(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.Sbros();
            txt_Output.Text = "0";
        }

        private void btn_ravno_Click_1(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.ZnakRavno();
            mehanizmcalkulyatora.Sbros();
        }

        private void txt_Output_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Stepen_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Stepen);
        }

        private void btn_Koren_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Koren);
        }

        private void btn_Obratnoe_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Obratnoe);
        }

        private void btn_Kvadrat_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Kvadrat);
        }


        private void btn_Changesign_Click_1(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.ZnakChisla();
        }

        private void btn_point_Click_1(object sender, EventArgs e)
        {
            txt_Output.Text = mehanizmcalkulyatora.ZnakTochki();
        }


    }
    //public partial class engin : Calculator.Calc
    //{
    //    public engin()
    //    {
    //        InitializeComponent();
    //    }

    //private void Obratnoe_Click(object sender, EventArgs e)
    //    {

    //    }

    //private void Kvadrat_Click(object sender, EventArgs e)
    //    {

    //    }

    //private void Koren_Click(object sender, EventArgs e)
    //{

    //}

    //private void Stepen_Click(object sender, EventArgs e)
    //{

    //}

    //private void Close_Click(object sender, EventArgs e)
    //{

    //}

    //private void toolTip1_Popup(object sender, PopupEventArgs e)
    //{

    //}
    //}

    //internal class InitializeComponent
    //{
    //    public InitializeComponent()
    //    {
    //    }
    //}

    class mehanizmcalkulyatora
	{
	/// <summary>
	///Создаем перечисление Deystvie, для определения одного из четырех действия калькулятора.
	/// </summary>
		public enum Deystvie:int
		{
			NeopredelDeystvie = 0,
			Slojenie = 1,
			Vichitanie = 2,
			Umnojenie = 3,
			Delenie = 4,
            Koren = 5,
            Stepen = 6,
            Obratnoe = 7,
            Kvadrat = 8,
        }

	/// <summary>
	/// Объявляем и инициализируем переменную, 
	/// которая будет использоваться для смены знака при нажатии клавиши (+/-)
	/// </summary>

		private static double peremennayaMinus = -1;

		/// <summary>
		/// Объвляем переменные, для работы калькулятора:
		/// resultatVichisleniy - переменная для хранения
		///  промежуточного результата в механизме калькулятора
		///  resultatOutput - переменная, значение которой будет сниматься с экрана и  выводиться на него.
		///  tekusheeDeystvieCalculatora - хранение одного из действия калькулятора.
		///  pervoeChislo - переменная, в которую будет записываться число на экране
		///   до нажатия на одну из четырех кнопок с действием.
		///  vtoroeChislo - второе число на экране.
		///  dobavlenierazryada при добавлении следующего  разряда эта переменная примет значение true;
		///  ChislosTochkoy при добавлении десятичного разряда (знака точки) эта переменная примет значение true
		/// </summary>
	
		private static double resultatVichisleniy;
		private static string resultatOutput;
		private static Deystvie tekusheeDeystvieCalculatora;
		private static double pervoeChislo;
		private static double vtoroeChislo;
		private static bool dobavlenierazryada;
		private static bool ChislosTochkoy;
 
		/// <summary>
		/// В конструкторе класса mehanizmcalkulyatora инициализируем переменные 
		/// ChislosTochkoy и dobavlenierazryada - при запуске калькулятора на экране 
		/// нет ни разрядности, ни десятичной части.
		/// </summary>

		public mehanizmcalkulyatora ()
		{
			ChislosTochkoy = false;
			dobavlenierazryada = false;
		}

			
		/// <summary>
		/// В этом методе переменная resultatOutput изменяется - при вводе числа ее значение перезаписывается.
		/// </summary>
		

		public static string chislonaEkrane (string najatayaKlavisha)
		{
			resultatOutput = resultatOutput + najatayaKlavisha;
			return (resultatOutput);
		}
		/// <summary>
		/// Метод, в котором определяется peremenDeystviya - одно значение перечисления Deystvie,
		///в зависимости от выбора  клавиши +, -, *,  или /
		/// </summary>
	
		public static void DeystvieCalculatora (Deystvie peremenDeystviya)
		{
			try
			{
				if (resultatOutput != "" && !dobavlenierazryada)
				{
					pervoeChislo = System.Convert.ToDouble (resultatOutput);
					tekusheeDeystvieCalculatora = peremenDeystviya;
					resultatOutput = "";
					ChislosTochkoy = false;
				}			
			}
		
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
			
			}
		}
        ////public static string btn_Obratnoe()
        ////{
        ////    double pervoeChislo;

        ////    if (resultatOutput != "")
        ////    {
        ////        pervoeChislo = System.Convert.ToDouble(resultatOutput);
        ////        resultatOutput = System.Convert.ToString(1 / pervoeChislo);
        ////    }
        ////    return (resultatOutput);

        ////}

        /// <summary>
        /// При нажатии  кнопки +/- число на экране - tekusheeChislo умножается на -1,
        ///  а затем результат снова присваивается переменной resultatOutput.
        /// </summary>

        ////public static string btn_Kvadrat()
        ////{
        ////    double pervoeChislo;

        ////    if (resultatOutput != "")
        ////    {

        ////        pervoeChislo = System.Convert.ToDouble(resultatOutput);
        ////        resultatOutput = System.Convert.ToString(Math.Pow(pervoeChislo,2));
        ////    }
        ////    return (resultatOutput);

        ////}
        ////public static string btn_Koren()
        ////{
        ////    double tekusheeChislo;

        ////    if (resultatOutput != "")
        ////    {
        ////        tekusheeChislo = System.Convert.ToDouble(resultatOutput);
        ////        resultatOutput = System.Convert.ToString(Math.Sqrt(tekusheeChislo));
        ////    }
        ////    return (resultatOutput);
        ////}

            public static string ZnakChisla ()
		{
			double tekusheeChislo;

			if (resultatOutput != "")
			{
				tekusheeChislo = System.Convert.ToDouble (resultatOutput);
				resultatOutput = System.Convert.ToString(tekusheeChislo * peremennayaMinus);
			}
		
			return (resultatOutput);
		}

		/// <summary>
		/// При нажатии кнопки ( , ) переменная resultatOutput приобретает дробную часть.
		/// </summary>
	

		public static string ZnakTochki ()
		{
			if (!ChislosTochkoy && !dobavlenierazryada)
			{
				if (resultatOutput != "")
					resultatOutput = resultatOutput + ",";
				else
					resultatOutput = "0,";

				ChislosTochkoy = true;
			}

			return (resultatOutput);
		}

	/// <summary>
	/// При нажатии кнопки ZnakRavno обрабатываются значения 
	/// переменнных pervoeChislo и vtoroeChislo, результат присваивается переменной resultatVichisleniy 
	/// которая  затем преобразуется в resultatOutput.
	/// </summary>


		public static string ZnakRavno ()
		{
			bool proverkaOshibok = false;

			if (resultatOutput != "")
			{
				vtoroeChislo = System.Convert.ToDouble (resultatOutput);
				dobavlenierazryada = true;

				switch (tekusheeDeystvieCalculatora)
				{
					case Deystvie.NeopredelDeystvie:
						proverkaOshibok = false;
						break;

					case Deystvie.Slojenie:
						resultatVichisleniy = pervoeChislo + vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Vichitanie:
						resultatVichisleniy = pervoeChislo - vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Umnojenie:
						resultatVichisleniy = pervoeChislo * vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Delenie:
						resultatVichisleniy = pervoeChislo / vtoroeChislo;
						proverkaOshibok = true;
						break;

                    case Deystvie.Stepen:
                        resultatVichisleniy = Math.Pow(pervoeChislo, vtoroeChislo);
                        proverkaOshibok=true;
                        break;

                    case Deystvie.Koren:
                        resultatVichisleniy = Math.Sqrt(pervoeChislo);
                        proverkaOshibok = true;
                        break;

                    case Deystvie.Obratnoe:
                        resultatVichisleniy = 1 / pervoeChislo;
                        proverkaOshibok = true;
                        break;

                    case Deystvie.Kvadrat:
                        resultatVichisleniy = pervoeChislo * pervoeChislo;
                        proverkaOshibok = true;
                        break;

                    default:
						proverkaOshibok = false;
						break;
				}

				if (proverkaOshibok)
					resultatOutput = System.Convert.ToString (resultatVichisleniy);
			}
			
			return (resultatOutput);
		}

	/// <summary>
	/// При нажатии кнопки  С (сброс) значения переменных обнуляются.
	/// </summary>

		public static void Sbros ()
		{
			resultatVichisleniy = 0;
			pervoeChislo = 0;
			vtoroeChislo = 0;
			resultatOutput = "";
			tekusheeDeystvieCalculatora = Deystvie.NeopredelDeystvie;
			ChislosTochkoy = false;
			dobavlenierazryada = false;			
		}

	}
}
