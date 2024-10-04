namespace AplikacjaDoPogody
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            RchTxtBoxPogoda = new RichTextBox();
            BtnPokazPogode = new Button();
            TmrPogoda = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // RchTxtBoxPogoda
            // 
            RchTxtBoxPogoda.Location = new Point(12, 12);
            RchTxtBoxPogoda.Name = "RchTxtBoxPogoda";
            RchTxtBoxPogoda.Size = new Size(569, 227);
            RchTxtBoxPogoda.TabIndex = 0;
            RchTxtBoxPogoda.Text = "";
            // 
            // BtnPokazPogode
            // 
            BtnPokazPogode.Location = new Point(12, 245);
            BtnPokazPogode.Name = "BtnPokazPogode";
            BtnPokazPogode.Size = new Size(569, 23);
            BtnPokazPogode.TabIndex = 1;
            BtnPokazPogode.Text = "Wyświetl pogodę";
            BtnPokazPogode.UseVisualStyleBackColor = true;
            BtnPokazPogode.Click += BtnPokazPogode_Click;
            // 
            // TmrPogoda
            // 
            TmrPogoda.Enabled = true;
            TmrPogoda.Interval = 90000;
            TmrPogoda.Tick += TmrPogoda_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 279);
            Controls.Add(BtnPokazPogode);
            Controls.Add(RchTxtBoxPogoda);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox RchTxtBoxPogoda;
        private Button BtnPokazPogode;
        private System.Windows.Forms.Timer TmrPogoda;
    }
}
