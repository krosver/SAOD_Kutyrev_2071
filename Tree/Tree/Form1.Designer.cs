
namespace Tree
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
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.TextBox();
            this.bt_find = new System.Windows.Forms.Button();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.bt_tree = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.tb_del = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(37, 32);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(70, 33);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(127, 35);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(125, 27);
            this.tb_add.TabIndex = 1;
            // 
            // bt_find
            // 
            this.bt_find.Location = new System.Drawing.Point(37, 71);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(70, 37);
            this.bt_find.TabIndex = 2;
            this.bt_find.Text = "Find";
            this.bt_find.UseVisualStyleBackColor = true;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // tb_find
            // 
            this.tb_find.Location = new System.Drawing.Point(127, 76);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(125, 27);
            this.tb_find.TabIndex = 3;
            // 
            // bt_tree
            // 
            this.bt_tree.Location = new System.Drawing.Point(624, 32);
            this.bt_tree.Name = "bt_tree";
            this.bt_tree.Size = new System.Drawing.Size(144, 54);
            this.bt_tree.TabIndex = 4;
            this.bt_tree.Text = "Дерево на отдельной форме";
            this.bt_tree.UseVisualStyleBackColor = true;
            this.bt_tree.Click += new System.EventHandler(this.bt_tree_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(37, 114);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(70, 33);
            this.bt_del.TabIndex = 5;
            this.bt_del.Text = "Delete";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // tb_del
            // 
            this.tb_del.Location = new System.Drawing.Point(127, 117);
            this.tb_del.Name = "tb_del";
            this.tb_del.Size = new System.Drawing.Size(125, 27);
            this.tb_del.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_del);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_tree);
            this.Controls.Add(this.tb_find);
            this.Controls.Add(this.bt_find);
            this.Controls.Add(this.tb_add);
            this.Controls.Add(this.bt_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_add;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.Button bt_tree;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.TextBox tb_del;
        private System.Windows.Forms.Button button1;
    }
}

