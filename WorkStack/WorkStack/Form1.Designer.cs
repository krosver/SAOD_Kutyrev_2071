
namespace WorkStack
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
            this.tb_arr = new System.Windows.Forms.TextBox();
            this.bt_push = new System.Windows.Forms.Button();
            this.bt_Pop = new System.Windows.Forms.Button();
            this.bt_top = new System.Windows.Forms.Button();
            this.tb_push = new System.Windows.Forms.TextBox();
            this.tb_pop = new System.Windows.Forms.TextBox();
            this.tb_top = new System.Windows.Forms.TextBox();
            this.bt_create = new System.Windows.Forms.Button();
            this.tb_create = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_arr
            // 
            this.tb_arr.Location = new System.Drawing.Point(39, 33);
            this.tb_arr.Multiline = true;
            this.tb_arr.Name = "tb_arr";
            this.tb_arr.Size = new System.Drawing.Size(125, 384);
            this.tb_arr.TabIndex = 0;
            // 
            // bt_push
            // 
            this.bt_push.Location = new System.Drawing.Point(244, 131);
            this.bt_push.Name = "bt_push";
            this.bt_push.Size = new System.Drawing.Size(94, 63);
            this.bt_push.TabIndex = 1;
            this.bt_push.Text = "Push";
            this.bt_push.UseVisualStyleBackColor = true;
            this.bt_push.Click += new System.EventHandler(this.bt_push_Click);
            // 
            // bt_Pop
            // 
            this.bt_Pop.Location = new System.Drawing.Point(244, 243);
            this.bt_Pop.Name = "bt_Pop";
            this.bt_Pop.Size = new System.Drawing.Size(94, 62);
            this.bt_Pop.TabIndex = 2;
            this.bt_Pop.Text = "Pop";
            this.bt_Pop.UseVisualStyleBackColor = true;
            this.bt_Pop.Click += new System.EventHandler(this.bt_Pop_Click);
            // 
            // bt_top
            // 
            this.bt_top.Location = new System.Drawing.Point(244, 359);
            this.bt_top.Name = "bt_top";
            this.bt_top.Size = new System.Drawing.Size(94, 54);
            this.bt_top.TabIndex = 3;
            this.bt_top.Text = "Top";
            this.bt_top.UseVisualStyleBackColor = true;
            this.bt_top.Click += new System.EventHandler(this.bt_top_Click);
            // 
            // tb_push
            // 
            this.tb_push.Location = new System.Drawing.Point(404, 141);
            this.tb_push.Name = "tb_push";
            this.tb_push.Size = new System.Drawing.Size(125, 27);
            this.tb_push.TabIndex = 4;
            // 
            // tb_pop
            // 
            this.tb_pop.Location = new System.Drawing.Point(404, 261);
            this.tb_pop.Name = "tb_pop";
            this.tb_pop.Size = new System.Drawing.Size(125, 27);
            this.tb_pop.TabIndex = 5;
            // 
            // tb_top
            // 
            this.tb_top.Location = new System.Drawing.Point(404, 373);
            this.tb_top.Name = "tb_top";
            this.tb_top.Size = new System.Drawing.Size(125, 27);
            this.tb_top.TabIndex = 6;
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(244, 33);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(94, 63);
            this.bt_create.TabIndex = 7;
            this.bt_create.Text = "Create";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // tb_create
            // 
            this.tb_create.Location = new System.Drawing.Point(404, 51);
            this.tb_create.Name = "tb_create";
            this.tb_create.Size = new System.Drawing.Size(125, 27);
            this.tb_create.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_create);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.tb_top);
            this.Controls.Add(this.tb_pop);
            this.Controls.Add(this.tb_push);
            this.Controls.Add(this.bt_top);
            this.Controls.Add(this.bt_Pop);
            this.Controls.Add(this.bt_push);
            this.Controls.Add(this.tb_arr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_arr;
        private System.Windows.Forms.Button bt_push;
        private System.Windows.Forms.Button bt_Pop;
        private System.Windows.Forms.Button bt_top;
        private System.Windows.Forms.TextBox tb_push;
        private System.Windows.Forms.TextBox tb_pop;
        private System.Windows.Forms.TextBox tb_top;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.TextBox tb_creat;
        private System.Windows.Forms.TextBox tb_create;
    }
}

