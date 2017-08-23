namespace ExCap07
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.tabControl10 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LimpaButt = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Ex5_23 = new System.Windows.Forms.Button();
            this.RemoveButt = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.IncluiButton = new System.Windows.Forms.Button();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl10.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl10
            // 
            this.tabControl10.Controls.Add(this.tabPage1);
            this.tabControl10.Controls.Add(this.tabPage2);
            this.tabControl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl10.Location = new System.Drawing.Point(0, 0);
            this.tabControl10.Name = "tabControl10";
            this.tabControl10.SelectedIndex = 0;
            this.tabControl10.Size = new System.Drawing.Size(588, 511);
            this.tabControl10.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LimpaButt);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.Ex5_23);
            this.tabPage1.Controls.Add(this.RemoveButt);
            this.tabPage1.Controls.Add(this.inputTextBox);
            this.tabPage1.Controls.Add(this.IncluiButton);
            this.tabPage1.Controls.Add(this.displayListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(580, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LimpaButt
            // 
            this.LimpaButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpaButt.Location = new System.Drawing.Point(341, 185);
            this.LimpaButt.Name = "LimpaButt";
            this.LimpaButt.Size = new System.Drawing.Size(163, 31);
            this.LimpaButt.TabIndex = 8;
            this.LimpaButt.Text = "Limpa a lista";
            this.LimpaButt.UseVisualStyleBackColor = true;
            this.LimpaButt.Click += new System.EventHandler(this.LimpaButt_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(429, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 31);
            this.button6.TabIndex = 7;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(341, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 31);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(429, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Ex5_23
            // 
            this.Ex5_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex5_23.Location = new System.Drawing.Point(341, 235);
            this.Ex5_23.Name = "Ex5_23";
            this.Ex5_23.Size = new System.Drawing.Size(75, 31);
            this.Ex5_23.TabIndex = 4;
            this.Ex5_23.Text = "Ex 5-23";
            this.toolTip1.SetToolTip(this.Ex5_23, "Ache o maior, o segundo maior , o menor , a soma e a média. \r\nDigite número reais" +
        " na caixa de texto e aperte no botão Inclui no List Box !!");
            this.Ex5_23.UseVisualStyleBackColor = true;
            this.Ex5_23.Click += new System.EventHandler(this.Ex5_23_Click);
            // 
            // RemoveButt
            // 
            this.RemoveButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButt.ForeColor = System.Drawing.Color.Red;
            this.RemoveButt.Location = new System.Drawing.Point(341, 135);
            this.RemoveButt.Name = "RemoveButt";
            this.RemoveButt.Size = new System.Drawing.Size(163, 31);
            this.RemoveButt.TabIndex = 3;
            this.RemoveButt.Text = "Remove a linha ";
            this.RemoveButt.UseVisualStyleBackColor = true;
            this.RemoveButt.Click += new System.EventHandler(this.RemoveButt_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(341, 40);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(163, 26);
            this.inputTextBox.TabIndex = 2;
            // 
            // IncluiButton
            // 
            this.IncluiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncluiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IncluiButton.Location = new System.Drawing.Point(341, 85);
            this.IncluiButton.Name = "IncluiButton";
            this.IncluiButton.Size = new System.Drawing.Size(163, 31);
            this.IncluiButton.TabIndex = 1;
            this.IncluiButton.Text = "Inclui no List Box";
            this.IncluiButton.UseVisualStyleBackColor = true;
            this.IncluiButton.Click += new System.EventHandler(this.IncluiButton_Click);
            // 
            // displayListBox
            // 
            this.displayListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 20;
            this.displayListBox.Location = new System.Drawing.Point(20, 30);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(267, 404);
            this.displayListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(580, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Exercícios Deitel C# 2012 HTP 5ed !!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 511);
            this.Controls.Add(this.tabControl10);
            this.Name = "Form1";
            this.Text = "Form1";           
            this.tabControl10.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Ex5_23;
        private System.Windows.Forms.Button RemoveButt;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button IncluiButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button LimpaButt;
    }
}