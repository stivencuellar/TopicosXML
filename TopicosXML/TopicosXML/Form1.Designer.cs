namespace TopicosXML
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpDecorador = new System.Windows.Forms.GroupBox();
            this.rtxtDecorador = new System.Windows.Forms.RichTextBox();
            this.grpFuente = new System.Windows.Forms.GroupBox();
            this.rtxtFuente = new System.Windows.Forms.RichTextBox();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.rtxtResultado = new System.Windows.Forms.RichTextBox();
            this.ttpXMLDecorator = new System.Windows.Forms.ToolTip(this.components);
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnCargarFuente = new System.Windows.Forms.Button();
            this.btnCargarDecorador = new System.Windows.Forms.Button();
            this.ofdXMLSelector = new System.Windows.Forms.OpenFileDialog();
            this.grpDecorador.SuspendLayout();
            this.grpFuente.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDecorador
            // 
            this.grpDecorador.Controls.Add(this.rtxtDecorador);
            this.grpDecorador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDecorador.Location = new System.Drawing.Point(61, 37);
            this.grpDecorador.Name = "grpDecorador";
            this.grpDecorador.Size = new System.Drawing.Size(383, 453);
            this.grpDecorador.TabIndex = 2;
            this.grpDecorador.TabStop = false;
            this.grpDecorador.Text = "DECORADOR";
            this.grpDecorador.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rtxtDecorador
            // 
            this.rtxtDecorador.Location = new System.Drawing.Point(7, 26);
            this.rtxtDecorador.Name = "rtxtDecorador";
            this.rtxtDecorador.Size = new System.Drawing.Size(370, 419);
            this.rtxtDecorador.TabIndex = 0;
            this.rtxtDecorador.Text = "hola";
            // 
            // grpFuente
            // 
            this.grpFuente.Controls.Add(this.rtxtFuente);
            this.grpFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFuente.Location = new System.Drawing.Point(495, 37);
            this.grpFuente.Name = "grpFuente";
            this.grpFuente.Size = new System.Drawing.Size(383, 453);
            this.grpFuente.TabIndex = 3;
            this.grpFuente.TabStop = false;
            this.grpFuente.Text = "FUENTE";
            // 
            // rtxtFuente
            // 
            this.rtxtFuente.Location = new System.Drawing.Point(7, 25);
            this.rtxtFuente.Name = "rtxtFuente";
            this.rtxtFuente.Size = new System.Drawing.Size(370, 419);
            this.rtxtFuente.TabIndex = 1;
            this.rtxtFuente.Text = "mmmm";
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.rtxtResultado);
            this.grpResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultado.Location = new System.Drawing.Point(926, 37);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(383, 453);
            this.grpResultado.TabIndex = 4;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "RESULTADO";
            // 
            // rtxtResultado
            // 
            this.rtxtResultado.Location = new System.Drawing.Point(6, 25);
            this.rtxtResultado.Name = "rtxtResultado";
            this.rtxtResultado.Size = new System.Drawing.Size(370, 419);
            this.rtxtResultado.TabIndex = 1;
            this.rtxtResultado.Text = "";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackgroundImage = global::TopicosXML.Properties.Resources.WMP11;
            this.btnProcesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcesar.Location = new System.Drawing.Point(436, 573);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(93, 94);
            this.btnProcesar.TabIndex = 6;
            this.ttpXMLDecorator.SetToolTip(this.btnProcesar, "Cargar Decorador");
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnCargarFuente
            // 
            this.btnCargarFuente.BackgroundImage = global::TopicosXML.Properties.Resources.Arrow_Up;
            this.btnCargarFuente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargarFuente.Location = new System.Drawing.Point(666, 496);
            this.btnCargarFuente.Name = "btnCargarFuente";
            this.btnCargarFuente.Size = new System.Drawing.Size(67, 58);
            this.btnCargarFuente.TabIndex = 5;
            this.ttpXMLDecorator.SetToolTip(this.btnCargarFuente, "Cargar Fuente");
            this.btnCargarFuente.UseVisualStyleBackColor = true;
            this.btnCargarFuente.Click += new System.EventHandler(this.btnCargarFuente_Click);
            // 
            // btnCargarDecorador
            // 
            this.btnCargarDecorador.BackgroundImage = global::TopicosXML.Properties.Resources.Arrow_Up;
            this.btnCargarDecorador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargarDecorador.Location = new System.Drawing.Point(209, 496);
            this.btnCargarDecorador.Name = "btnCargarDecorador";
            this.btnCargarDecorador.Size = new System.Drawing.Size(67, 58);
            this.btnCargarDecorador.TabIndex = 0;
            this.ttpXMLDecorator.SetToolTip(this.btnCargarDecorador, "Cargar Decorador");
            this.btnCargarDecorador.UseVisualStyleBackColor = true;
            this.btnCargarDecorador.Click += new System.EventHandler(this.btnCargarDecorador_Click);
            // 
            // ofdXMLSelector
            // 
            this.ofdXMLSelector.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1308, 693);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnCargarFuente);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.grpFuente);
            this.Controls.Add(this.grpDecorador);
            this.Controls.Add(this.btnCargarDecorador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML DECORATOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDecorador.ResumeLayout(false);
            this.grpFuente.ResumeLayout(false);
            this.grpResultado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarDecorador;
        private System.Windows.Forms.GroupBox grpDecorador;
        private System.Windows.Forms.GroupBox grpFuente;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Button btnCargarFuente;
        private System.Windows.Forms.ToolTip ttpXMLDecorator;
        private System.Windows.Forms.RichTextBox rtxtDecorador;
        private System.Windows.Forms.RichTextBox rtxtFuente;
        private System.Windows.Forms.RichTextBox rtxtResultado;
        private System.Windows.Forms.OpenFileDialog ofdXMLSelector;
        private System.Windows.Forms.Button btnProcesar;
    }
}

