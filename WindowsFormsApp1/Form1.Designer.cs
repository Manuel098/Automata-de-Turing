namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Star = new System.Windows.Forms.Button();
            this.inputData = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.subirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalidadDelAutomataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parDe0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameAuto = new System.Windows.Forms.Label();
            this.inputMessage = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizar = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Star
            // 
            this.Star.Location = new System.Drawing.Point(25, 105);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(161, 49);
            this.Star.TabIndex = 0;
            this.Star.Text = "Iniciar";
            this.Star.UseVisualStyleBackColor = true;
            this.Star.Click += new System.EventHandler(this.Star_Click);
            // 
            // inputData
            // 
            this.inputData.Location = new System.Drawing.Point(25, 54);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(339, 26);
            this.inputData.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subirArchivoToolStripMenuItem,
            this.modalidadDelAutomataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // subirArchivoToolStripMenuItem
            // 
            this.subirArchivoToolStripMenuItem.Name = "subirArchivoToolStripMenuItem";
            this.subirArchivoToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.subirArchivoToolStripMenuItem.Text = "Subir Archivo";
            this.subirArchivoToolStripMenuItem.Click += new System.EventHandler(this.subirArchivoToolStripMenuItem_Click);
            // 
            // modalidadDelAutomataToolStripMenuItem
            // 
            this.modalidadDelAutomataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumadorToolStripMenuItem,
            this.restadorToolStripMenuItem,
            this.parDe0ToolStripMenuItem});
            this.modalidadDelAutomataToolStripMenuItem.Name = "modalidadDelAutomataToolStripMenuItem";
            this.modalidadDelAutomataToolStripMenuItem.Size = new System.Drawing.Size(223, 29);
            this.modalidadDelAutomataToolStripMenuItem.Text = "Modalidad del Automata";
            // 
            // sumadorToolStripMenuItem
            // 
            this.sumadorToolStripMenuItem.Name = "sumadorToolStripMenuItem";
            this.sumadorToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.sumadorToolStripMenuItem.Text = "Sumador";
            this.sumadorToolStripMenuItem.Click += new System.EventHandler(this.sumadorToolStripMenuItem_Click);
            // 
            // restadorToolStripMenuItem
            // 
            this.restadorToolStripMenuItem.Name = "restadorToolStripMenuItem";
            this.restadorToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.restadorToolStripMenuItem.Text = "Restador";
            this.restadorToolStripMenuItem.Click += new System.EventHandler(this.restadorToolStripMenuItem_Click);
            // 
            // parDe0ToolStripMenuItem
            // 
            this.parDe0ToolStripMenuItem.Name = "parDe0ToolStripMenuItem";
            this.parDe0ToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.parDe0ToolStripMenuItem.Text = "Par de 0";
            this.parDe0ToolStripMenuItem.Click += new System.EventHandler(this.parDe0ToolStripMenuItem_Click);
            // 
            // nameAuto
            // 
            this.nameAuto.AutoSize = true;
            this.nameAuto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.nameAuto.Location = new System.Drawing.Point(32, 18);
            this.nameAuto.Name = "nameAuto";
            this.nameAuto.Size = new System.Drawing.Size(0, 25);
            this.nameAuto.TabIndex = 5;
            // 
            // inputMessage
            // 
            this.inputMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.inputMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.inputMessage.Location = new System.Drawing.Point(415, 18);
            this.inputMessage.Name = "inputMessage";
            this.inputMessage.Size = new System.Drawing.Size(375, 384);
            this.inputMessage.TabIndex = 6;
            this.inputMessage.Text = "";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(203, 105);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(161, 49);
            this.save.TabIndex = 7;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(86)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.inputData);
            this.panel1.Controls.Add(this.nameAuto);
            this.panel1.Controls.Add(this.inputMessage);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.Star);
            this.panel1.Location = new System.Drawing.Point(-2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 420);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(768, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // minimizar
            // 
            this.minimizar.AutoSize = true;
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Location = new System.Drawing.Point(733, 7);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(18, 20);
            this.minimizar.TabIndex = 8;
            this.minimizar.Text = "_";
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Automata de Turing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Star;
        private System.Windows.Forms.TextBox inputData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modalidadDelAutomataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parDe0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subirArchivoToolStripMenuItem;
        private System.Windows.Forms.Label nameAuto;
        private System.Windows.Forms.RichTextBox inputMessage;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimizar;
    }
}

