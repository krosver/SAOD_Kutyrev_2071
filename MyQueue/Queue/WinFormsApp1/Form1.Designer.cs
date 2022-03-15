
namespace WinFormsApp1
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
            this.queue = new System.Windows.Forms.ListBox();
            this.bt_enqueue = new System.Windows.Forms.Button();
            this.bt_dequeue = new System.Windows.Forms.Button();
            this.bt_peek = new System.Windows.Forms.Button();
            this.bt_create = new System.Windows.Forms.Button();
            this.tb_create = new System.Windows.Forms.TextBox();
            this.tb_enqueue = new System.Windows.Forms.TextBox();
            this.tb_dequeue = new System.Windows.Forms.TextBox();
            this.tb_peek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // queue
            // 
            this.queue.FormattingEnabled = true;
            this.queue.ItemHeight = 20;
            this.queue.Location = new System.Drawing.Point(12, 33);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(150, 384);
            this.queue.TabIndex = 0;
            // 
            // bt_enqueue
            // 
            this.bt_enqueue.Location = new System.Drawing.Point(184, 87);
            this.bt_enqueue.Name = "bt_enqueue";
            this.bt_enqueue.Size = new System.Drawing.Size(94, 29);
            this.bt_enqueue.TabIndex = 1;
            this.bt_enqueue.Text = "Enqueue";
            this.bt_enqueue.UseVisualStyleBackColor = true;
            this.bt_enqueue.Click += new System.EventHandler(this.bt_enqueue_Click);
            // 
            // bt_dequeue
            // 
            this.bt_dequeue.Location = new System.Drawing.Point(184, 141);
            this.bt_dequeue.Name = "bt_dequeue";
            this.bt_dequeue.Size = new System.Drawing.Size(94, 29);
            this.bt_dequeue.TabIndex = 2;
            this.bt_dequeue.Text = "Dequeue";
            this.bt_dequeue.UseVisualStyleBackColor = true;
            this.bt_dequeue.Click += new System.EventHandler(this.bt_dequeue_Click);
            // 
            // bt_peek
            // 
            this.bt_peek.Location = new System.Drawing.Point(184, 192);
            this.bt_peek.Name = "bt_peek";
            this.bt_peek.Size = new System.Drawing.Size(94, 29);
            this.bt_peek.TabIndex = 3;
            this.bt_peek.Text = "Peek";
            this.bt_peek.UseVisualStyleBackColor = true;
            this.bt_peek.Click += new System.EventHandler(this.bt_peek_Click);
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(184, 42);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(94, 29);
            this.bt_create.TabIndex = 4;
            this.bt_create.Text = "Create";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // tb_create
            // 
            this.tb_create.Location = new System.Drawing.Point(305, 42);
            this.tb_create.Name = "tb_create";
            this.tb_create.Size = new System.Drawing.Size(150, 27);
            this.tb_create.TabIndex = 5;
            // 
            // tb_enqueue
            // 
            this.tb_enqueue.Location = new System.Drawing.Point(305, 89);
            this.tb_enqueue.Name = "tb_enqueue";
            this.tb_enqueue.Size = new System.Drawing.Size(150, 27);
            this.tb_enqueue.TabIndex = 7;
            // 
            // tb_dequeue
            // 
            this.tb_dequeue.Location = new System.Drawing.Point(305, 141);
            this.tb_dequeue.Name = "tb_dequeue";
            this.tb_dequeue.Size = new System.Drawing.Size(150, 27);
            this.tb_dequeue.TabIndex = 8;
            // 
            // tb_peek
            // 
            this.tb_peek.Location = new System.Drawing.Point(305, 194);
            this.tb_peek.Name = "tb_peek";
            this.tb_peek.Size = new System.Drawing.Size(150, 27);
            this.tb_peek.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 783);
            this.Controls.Add(this.tb_peek);
            this.Controls.Add(this.tb_dequeue);
            this.Controls.Add(this.tb_enqueue);
            this.Controls.Add(this.tb_create);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.bt_peek);
            this.Controls.Add(this.bt_dequeue);
            this.Controls.Add(this.bt_enqueue);
            this.Controls.Add(this.queue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox queue;
        private System.Windows.Forms.Button bt_enqueue;
        private System.Windows.Forms.Button bt_dequeue;
        private System.Windows.Forms.Button bt_peek;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.TextBox tb_create;
        private System.Windows.Forms.TextBox tb_enqueue;
        private System.Windows.Forms.TextBox tb_dequeue;
        private System.Windows.Forms.TextBox tb_peek;
    }
}

