
namespace List
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_append = new System.Windows.Forms.Button();
            this.tb_append = new System.Windows.Forms.TextBox();
            this.tb_prepend = new System.Windows.Forms.TextBox();
            this.bt_prepend = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.tb_insert = new System.Windows.Forms.TextBox();
            this.bt_find = new System.Windows.Forms.Button();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.bt_find_index = new System.Windows.Forms.Button();
            this.tb_find_index = new System.Windows.Forms.TextBox();
            this.br_remove = new System.Windows.Forms.Button();
            this.tb_remove = new System.Windows.Forms.TextBox();
            this.bt_remove_index = new System.Windows.Forms.Button();
            this.tb_remove_index = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 424);
            this.listBox1.TabIndex = 0;
            // 
            // bt_append
            // 
            this.bt_append.Location = new System.Drawing.Point(331, 12);
            this.bt_append.Name = "bt_append";
            this.bt_append.Size = new System.Drawing.Size(125, 27);
            this.bt_append.TabIndex = 1;
            this.bt_append.Text = "append";
            this.bt_append.UseVisualStyleBackColor = true;
            this.bt_append.Click += new System.EventHandler(this.bt_append_Click);
            // 
            // tb_append
            // 
            this.tb_append.Location = new System.Drawing.Point(183, 12);
            this.tb_append.Name = "tb_append";
            this.tb_append.Size = new System.Drawing.Size(125, 27);
            this.tb_append.TabIndex = 2;
            // 
            // tb_prepend
            // 
            this.tb_prepend.Location = new System.Drawing.Point(183, 55);
            this.tb_prepend.Name = "tb_prepend";
            this.tb_prepend.Size = new System.Drawing.Size(125, 27);
            this.tb_prepend.TabIndex = 3;
            // 
            // bt_prepend
            // 
            this.bt_prepend.Location = new System.Drawing.Point(331, 53);
            this.bt_prepend.Name = "bt_prepend";
            this.bt_prepend.Size = new System.Drawing.Size(125, 29);
            this.bt_prepend.TabIndex = 4;
            this.bt_prepend.Text = "prepend";
            this.bt_prepend.UseVisualStyleBackColor = true;
            this.bt_prepend.Click += new System.EventHandler(this.bt_prepend_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(331, 96);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(125, 29);
            this.bt_insert.TabIndex = 6;
            this.bt_insert.Text = "insert";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // tb_insert
            // 
            this.tb_insert.Location = new System.Drawing.Point(183, 98);
            this.tb_insert.Name = "tb_insert";
            this.tb_insert.Size = new System.Drawing.Size(125, 27);
            this.tb_insert.TabIndex = 5;
            // 
            // bt_find
            // 
            this.bt_find.Location = new System.Drawing.Point(331, 142);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(125, 29);
            this.bt_find.TabIndex = 8;
            this.bt_find.Text = "find(value)";
            this.bt_find.UseVisualStyleBackColor = true;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // tb_find
            // 
            this.tb_find.Location = new System.Drawing.Point(183, 143);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(125, 27);
            this.tb_find.TabIndex = 7;
            // 
            // bt_find_index
            // 
            this.bt_find_index.Location = new System.Drawing.Point(331, 186);
            this.bt_find_index.Name = "bt_find_index";
            this.bt_find_index.Size = new System.Drawing.Size(125, 29);
            this.bt_find_index.TabIndex = 10;
            this.bt_find_index.Text = "find(index)";
            this.bt_find_index.UseVisualStyleBackColor = true;
            // 
            // tb_find_index
            // 
            this.tb_find_index.Location = new System.Drawing.Point(183, 187);
            this.tb_find_index.Name = "tb_find_index";
            this.tb_find_index.Size = new System.Drawing.Size(125, 27);
            this.tb_find_index.TabIndex = 9;
            // 
            // br_remove
            // 
            this.br_remove.Location = new System.Drawing.Point(331, 232);
            this.br_remove.Name = "br_remove";
            this.br_remove.Size = new System.Drawing.Size(125, 29);
            this.br_remove.TabIndex = 12;
            this.br_remove.Text = "remove(value)";
            this.br_remove.UseVisualStyleBackColor = true;
            // 
            // tb_remove
            // 
            this.tb_remove.Location = new System.Drawing.Point(183, 232);
            this.tb_remove.Name = "tb_remove";
            this.tb_remove.Size = new System.Drawing.Size(125, 27);
            this.tb_remove.TabIndex = 11;
            // 
            // bt_remove_index
            // 
            this.bt_remove_index.Location = new System.Drawing.Point(331, 277);
            this.bt_remove_index.Name = "bt_remove_index";
            this.bt_remove_index.Size = new System.Drawing.Size(125, 29);
            this.bt_remove_index.TabIndex = 14;
            this.bt_remove_index.Text = "remove(index)";
            this.bt_remove_index.UseVisualStyleBackColor = true;
            // 
            // tb_remove_index
            // 
            this.tb_remove_index.Location = new System.Drawing.Point(183, 277);
            this.tb_remove_index.Name = "tb_remove_index";
            this.tb_remove_index.Size = new System.Drawing.Size(125, 27);
            this.tb_remove_index.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_remove_index);
            this.Controls.Add(this.tb_remove_index);
            this.Controls.Add(this.br_remove);
            this.Controls.Add(this.tb_remove);
            this.Controls.Add(this.bt_find_index);
            this.Controls.Add(this.tb_find_index);
            this.Controls.Add(this.bt_find);
            this.Controls.Add(this.tb_find);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.tb_insert);
            this.Controls.Add(this.bt_prepend);
            this.Controls.Add(this.tb_prepend);
            this.Controls.Add(this.tb_append);
            this.Controls.Add(this.bt_append);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_append;
        private System.Windows.Forms.TextBox tb_append;
        private System.Windows.Forms.TextBox tb_prepend;
        private System.Windows.Forms.Button bt_prepend;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.TextBox tb_insert;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.Button bt_find_index;
        private System.Windows.Forms.TextBox tb_find_index;
        private System.Windows.Forms.Button br_remove;
        private System.Windows.Forms.TextBox tb_remove;
        private System.Windows.Forms.Button bt_remove_index;
        private System.Windows.Forms.TextBox tb_remove_index;
    }
}

