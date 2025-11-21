namespace FormCRUD
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
            label1 = new Label();
            label2 = new Label();
            nametextBox = new TextBox();
            emailtextBox = new TextBox();
            Addbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 66);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 152);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(247, 60);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(291, 31);
            nametextBox.TabIndex = 2;
            // 
            // emailtextBox
            // 
            emailtextBox.Location = new Point(247, 146);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(291, 31);
            emailtextBox.TabIndex = 3;
            // 
            // Addbutton
            // 
            Addbutton.Location = new Point(60, 251);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(128, 34);
            Addbutton.TabIndex = 4;
            Addbutton.Text = "Enregistrer";
            Addbutton.UseVisualStyleBackColor = true;
            Addbutton.Click += Addbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 668);
            Controls.Add(Addbutton);
            Controls.Add(emailtextBox);
            Controls.Add(nametextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nametextBox;
        private TextBox emailtextBox;
        private Button Addbutton;
    }
}
