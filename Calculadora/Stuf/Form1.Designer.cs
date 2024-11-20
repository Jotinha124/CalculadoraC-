namespace Stuf
{
    partial class Pagina_inicial
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
            button = new Button();
            text_1 = new TextBox();
            label_1 = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(101, 92);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 0;
            button.Text = "Click  !";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // text_1
            // 
            text_1.Location = new Point(87, 38);
            text_1.Name = "text_1";
            text_1.Size = new Size(100, 23);
            text_1.TabIndex = 1;
            // 
            // label_1
            // 
            label_1.AutoSize = true;
            label_1.Location = new Point(118, 139);
            label_1.Name = "label_1";
            label_1.Size = new Size(38, 15);
            label_1.TabIndex = 2;
            label_1.Text = "label1";
            // 
            // Pagina_inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 297);
            Controls.Add(label_1);
            Controls.Add(text_1);
            Controls.Add(button);
            Name = "Pagina_inicial";
            Text = "Simpes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private TextBox text_1;
        private Label label_1;
    }
}