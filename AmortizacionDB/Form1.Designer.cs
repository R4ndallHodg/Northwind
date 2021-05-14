
namespace AmortizacionDB
{
    partial class frmAmortizacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAmortizacion = new System.Windows.Forms.Button();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAmortizacion = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmortizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(155)))), ((int)(((byte)(109)))));
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.txtIncremento);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtCorreo);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnAmortizacion);
            this.splitContainer1.Panel1.Controls.Add(this.txtCredito);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtPlazo);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtTasa);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(155)))), ((int)(((byte)(109)))));
            this.splitContainer1.Panel2.Controls.Add(this.dgvAmortizacion);
            this.splitContainer1.Size = new System.Drawing.Size(799, 621);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(112, 129);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(234, 33);
            this.txtIncremento.TabIndex = 4;
            this.txtIncremento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIncremento_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Incremento:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(112, 172);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(234, 33);
            this.txtCorreo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Correo:";
            // 
            // btnAmortizacion
            // 
            this.btnAmortizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(202)))), ((int)(((byte)(137)))));
            this.btnAmortizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmortizacion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAmortizacion.Location = new System.Drawing.Point(537, 47);
            this.btnAmortizacion.Name = "btnAmortizacion";
            this.btnAmortizacion.Size = new System.Drawing.Size(129, 76);
            this.btnAmortizacion.TabIndex = 6;
            this.btnAmortizacion.Text = "Generar calendario y reporte";
            this.btnAmortizacion.UseVisualStyleBackColor = false;
            this.btnAmortizacion.Click += new System.EventHandler(this.btnAmortizacion_Click);
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(112, 90);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(234, 33);
            this.txtCredito.TabIndex = 3;
            this.txtCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredito_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Credito:";
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(112, 51);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(234, 33);
            this.txtPlazo.TabIndex = 2;
            this.txtPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlazo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plazo:";
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(112, 12);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(234, 33);
            this.txtTasa.TabIndex = 1;
            this.txtTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasa:";
            // 
            // dgvAmortizacion
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAmortizacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAmortizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAmortizacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvAmortizacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAmortizacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAmortizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmortizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAmortizacion.Location = new System.Drawing.Point(0, 0);
            this.dgvAmortizacion.Name = "dgvAmortizacion";
            this.dgvAmortizacion.Size = new System.Drawing.Size(799, 391);
            this.dgvAmortizacion.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(202)))), ((int)(((byte)(137)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.Location = new System.Drawing.Point(537, 129);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 76);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmAmortizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 621);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmAmortizacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amortizacion ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmortizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvAmortizacion;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAmortizacion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh;
    }
}

