namespace Tarea4_Media
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            numeric1 = new NumericUpDown();
            numeric2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numeric1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(128, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Num1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 88);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Num2";
            // 
            // numeric1
            // 
            numeric1.Location = new Point(142, 49);
            numeric1.Name = "numeric1";
            numeric1.Size = new Size(120, 23);
            numeric1.TabIndex = 3;
            // 
            // numeric2
            // 
            numeric2.Location = new Point(142, 86);
            numeric2.Name = "numeric2";
            numeric2.Size = new Size(120, 23);
            numeric2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numeric2);
            Controls.Add(numeric1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numeric1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private NumericUpDown numeric1;
        private NumericUpDown numeric2;
    }
}
