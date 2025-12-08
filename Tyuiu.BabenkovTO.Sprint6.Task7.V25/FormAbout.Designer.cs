namespace Tyuiu.BabenkovTO.Sprint6.Task7.V25
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxHelp_BTO = new TextBox();
            buttonOK_BTO = new Button();
            pictureBoxAuthor_BTO = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_BTO).BeginInit();
            SuspendLayout();
            // 
            // textBoxHelp_BTO
            // 
            textBoxHelp_BTO.Font = new Font("Segoe UI", 10F);
            textBoxHelp_BTO.Location = new Point(147, 16);
            textBoxHelp_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxHelp_BTO.Multiline = true;
            textBoxHelp_BTO.Name = "textBoxHelp_BTO";
            textBoxHelp_BTO.ReadOnly = true;
            textBoxHelp_BTO.Size = new Size(357, 216);
            textBoxHelp_BTO.TabIndex = 0;
            textBoxHelp_BTO.TabStop = false;
            textBoxHelp_BTO.Text = resources.GetString("textBoxHelp_BTO.Text");
            // 
            // buttonOK_BTO
            // 
            buttonOK_BTO.Cursor = Cursors.Hand;
            buttonOK_BTO.Location = new Point(405, 240);
            buttonOK_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonOK_BTO.Name = "buttonOK_BTO";
            buttonOK_BTO.Size = new Size(86, 31);
            buttonOK_BTO.TabIndex = 1;
            buttonOK_BTO.Text = "Ок";
            buttonOK_BTO.UseVisualStyleBackColor = true;
            buttonOK_BTO.Click += buttonOK_BTO_Click;
            // 
            // pictureBoxAuthor_BTO
            // 
            pictureBoxAuthor_BTO.Image = (Image)resources.GetObject("pictureBoxAuthor_BTO.Image");
            pictureBoxAuthor_BTO.Location = new Point(14, 16);
            pictureBoxAuthor_BTO.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAuthor_BTO.Name = "pictureBoxAuthor_BTO";
            pictureBoxAuthor_BTO.Size = new Size(127, 172);
            pictureBoxAuthor_BTO.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAuthor_BTO.TabIndex = 2;
            pictureBoxAuthor_BTO.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 287);
            Controls.Add(pictureBoxAuthor_BTO);
            Controls.Add(buttonOK_BTO);
            Controls.Add(textBoxHelp_BTO);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_BTO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHelp_BTO;
        private Button buttonOK_BTO;
        private PictureBox pictureBoxAuthor_BTO;
    }
}