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
            TmrDoUpdate = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // RchTxtBoxPogoda
            // 
            RchTxtBoxPogoda.Location = new Point(12, 27);
            RchTxtBoxPogoda.Name = "RchTxtBoxPogoda";
            RchTxtBoxPogoda.Size = new Size(569, 212);
            RchTxtBoxPogoda.TabIndex = 0;
            RchTxtBoxPogoda.Text = "";
            // 
            // BtnPokazPogode
            // 
            BtnPokazPogode.Location = new Point(12, 245);
            BtnPokazPogode.Name = "BtnPokazPogode";
            BtnPokazPogode.Size = new Size(569, 23);
            BtnPokazPogode.TabIndex = 1;
            BtnPokazPogode.Text = "Aktualizuj pogodę teraz";
            BtnPokazPogode.UseVisualStyleBackColor = true;
            BtnPokazPogode.Click += BtnPokazPogode_Click;
            // 
            // TmrPogoda
            // 
            TmrPogoda.Enabled = true;
            TmrPogoda.Interval = 90000;
            TmrPogoda.Tick += TmrPogoda_Tick;
            // 
            // TmrDoUpdate
            // 
            TmrDoUpdate.Enabled = true;
            TmrDoUpdate.Interval = 1000;
            TmrDoUpdate.Tick += TmrDoUpdate_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 2;
            label1.Text = "Czas do aktualizacji pogody: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 279);
            Controls.Add(label1);
            Controls.Add(BtnPokazPogode);
            Controls.Add(RchTxtBoxPogoda);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RchTxtBoxPogoda;
        private Button BtnPokazPogode;
        private System.Windows.Forms.Timer TmrPogoda;
        private System.Windows.Forms.Timer TmrDoUpdate;
        private Label label1;
    }
}
