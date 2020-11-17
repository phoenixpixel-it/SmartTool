namespace SmartTool
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent ()
        {
            this.Barra_pnl = new System.Windows.Forms.Panel();
            this.Close_btn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.Fn1_btn = new System.Windows.Forms.Button();
            this.fn1_pnl = new System.Windows.Forms.Panel();
            this.opz1_chkbox = new System.Windows.Forms.CheckBox();
            this.Start_fn1_btn = new System.Windows.Forms.Button();
            this.lstfn1_lstbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Path_txtbox = new System.Windows.Forms.TextBox();
            this.Browse_btn = new System.Windows.Forms.Button();
            this.Barra_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.fn1_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barra_pnl
            // 
            this.Barra_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Barra_pnl.Controls.Add(this.Close_btn);
            this.Barra_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_pnl.Location = new System.Drawing.Point(0, 0);
            this.Barra_pnl.Name = "Barra_pnl";
            this.Barra_pnl.Size = new System.Drawing.Size(800, 34);
            this.Barra_pnl.TabIndex = 0;
            this.Barra_pnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Transparent;
            this.Close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(766, 0);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(34, 34);
            this.Close_btn.TabIndex = 3;
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.Fn1_btn);
            this.splitContainer1.Panel1MinSize = 35;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fn1_pnl);
            this.splitContainer1.Size = new System.Drawing.Size(800, 416);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fn1_btn
            // 
            this.Fn1_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Fn1_btn.Location = new System.Drawing.Point(0, 0);
            this.Fn1_btn.Name = "Fn1_btn";
            this.Fn1_btn.Size = new System.Drawing.Size(73, 23);
            this.Fn1_btn.TabIndex = 0;
            this.Fn1_btn.Text = "Function 1";
            this.Fn1_btn.UseVisualStyleBackColor = true;
            // 
            // fn1_pnl
            // 
            this.fn1_pnl.Controls.Add(this.opz1_chkbox);
            this.fn1_pnl.Controls.Add(this.Start_fn1_btn);
            this.fn1_pnl.Controls.Add(this.lstfn1_lstbox);
            this.fn1_pnl.Controls.Add(this.label1);
            this.fn1_pnl.Controls.Add(this.Path_txtbox);
            this.fn1_pnl.Controls.Add(this.Browse_btn);
            this.fn1_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fn1_pnl.Location = new System.Drawing.Point(0, 0);
            this.fn1_pnl.Name = "fn1_pnl";
            this.fn1_pnl.Size = new System.Drawing.Size(719, 414);
            this.fn1_pnl.TabIndex = 0;
            // 
            // opz1_chkbox
            // 
            this.opz1_chkbox.AutoSize = true;
            this.opz1_chkbox.Location = new System.Drawing.Point(74, 78);
            this.opz1_chkbox.Name = "opz1_chkbox";
            this.opz1_chkbox.Size = new System.Drawing.Size(118, 17);
            this.opz1_chkbox.TabIndex = 5;
            this.opz1_chkbox.Text = "Move file into folder";
            this.opz1_chkbox.UseVisualStyleBackColor = true;
            // 
            // Start_fn1_btn
            // 
            this.Start_fn1_btn.Enabled = false;
            this.Start_fn1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_fn1_btn.Location = new System.Drawing.Point(14, 46);
            this.Start_fn1_btn.Name = "Start_fn1_btn";
            this.Start_fn1_btn.Size = new System.Drawing.Size(54, 49);
            this.Start_fn1_btn.TabIndex = 4;
            this.Start_fn1_btn.Text = "Start";
            this.Start_fn1_btn.UseVisualStyleBackColor = true;
            this.Start_fn1_btn.Click += new System.EventHandler(this.Start_fn1_btn_Click);
            // 
            // lstfn1_lstbox
            // 
            this.lstfn1_lstbox.FormattingEnabled = true;
            this.lstfn1_lstbox.Location = new System.Drawing.Point(17, 113);
            this.lstfn1_lstbox.Name = "lstfn1_lstbox";
            this.lstfn1_lstbox.Size = new System.Drawing.Size(694, 290);
            this.lstfn1_lstbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crea cartelle da file";
            // 
            // Path_txtbox
            // 
            this.Path_txtbox.Location = new System.Drawing.Point(74, 46);
            this.Path_txtbox.Name = "Path_txtbox";
            this.Path_txtbox.ReadOnly = true;
            this.Path_txtbox.Size = new System.Drawing.Size(589, 20);
            this.Path_txtbox.TabIndex = 1;
            this.Path_txtbox.TextChanged += new System.EventHandler(this.Path_txtbox_TextChanged);
            // 
            // Browse_btn
            // 
            this.Browse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse_btn.Location = new System.Drawing.Point(669, 44);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.Size = new System.Drawing.Size(42, 23);
            this.Browse_btn.TabIndex = 0;
            this.Browse_btn.Text = "...";
            this.Browse_btn.UseVisualStyleBackColor = true;
            this.Browse_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Barra_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Barra_pnl.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.fn1_pnl.ResumeLayout(false);
            this.fn1_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_pnl;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Fn1_btn;
        private System.Windows.Forms.Panel fn1_pnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Path_txtbox;
        private System.Windows.Forms.Button Browse_btn;
        private System.Windows.Forms.ListBox lstfn1_lstbox;
        private System.Windows.Forms.Button Start_fn1_btn;
        private System.Windows.Forms.CheckBox opz1_chkbox;
        private System.Windows.Forms.Button button1;
    }
}

