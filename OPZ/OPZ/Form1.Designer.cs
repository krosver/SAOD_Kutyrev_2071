
namespace OPZ
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
            this.tb_formula = new System.Windows.Forms.TextBox();
            this.tb_opz = new System.Windows.Forms.TextBox();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_formula
            // 
            this.tb_formula.Location = new System.Drawing.Point(123, 101);
            this.tb_formula.Name = "tb_formula";
            this.tb_formula.Size = new System.Drawing.Size(220, 27);
            this.tb_formula.TabIndex = 0;
            // 
            // tb_opz
            // 
            this.tb_opz.Location = new System.Drawing.Point(123, 200);
            this.tb_opz.Name = "tb_opz";
            this.tb_opz.Size = new System.Drawing.Size(220, 27);
            this.tb_opz.TabIndex = 1;
            // 
            // tb_answer
            // 
            this.tb_answer.Location = new System.Drawing.Point(123, 300);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(220, 27);
            this.tb_answer.TabIndex = 2;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(477, 198);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(94, 29);
            this.bt_start.TabIndex = 3;
            this.bt_start.Text = "start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.tb_opz);
            this.Controls.Add(this.tb_formula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_formula;
        private System.Windows.Forms.TextBox tb_opz;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Button bt_start;
    }
}

