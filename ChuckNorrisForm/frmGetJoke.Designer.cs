namespace ChuckNorrisForm
{
    partial class frmGetJoke
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
            this.btnGetJoke = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.lblJoke = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetJoke
            // 
            this.btnGetJoke.Location = new System.Drawing.Point(24, 181);
            this.btnGetJoke.Name = "btnGetJoke";
            this.btnGetJoke.Size = new System.Drawing.Size(87, 35);
            this.btnGetJoke.TabIndex = 0;
            this.btnGetJoke.Text = "Get Joke";
            this.btnGetJoke.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 102);
            this.textBox1.TabIndex = 1;
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(24, 33);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(187, 21);
            this.cbxCategories.TabIndex = 2;
            // 
            // lblJoke
            // 
            this.lblJoke.AutoSize = true;
            this.lblJoke.Location = new System.Drawing.Point(21, 57);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(33, 13);
            this.lblJoke.TabIndex = 3;
            this.lblJoke.Text = "Joke:";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(21, 17);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(60, 13);
            this.lblCategories.TabIndex = 4;
            this.lblCategories.Text = "Categories:";
            // 
            // frmGetJoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 388);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblJoke);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGetJoke);
            this.Name = "frmGetJoke";
            this.Text = "Chuck Norris Jokes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetJoke;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Label lblJoke;
        private System.Windows.Forms.Label lblCategories;
    }
}

