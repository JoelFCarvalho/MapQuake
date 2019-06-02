namespace MapQuake
{
    partial class View
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerarMapa = new System.Windows.Forms.Button();
            this.boxMagMax = new System.Windows.Forms.TextBox();
            this.boxMagMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxRaio = new System.Windows.Forms.TextBox();
            this.boxLon = new System.Windows.Forms.TextBox();
            this.boxLat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxDataMax = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.boxDataMin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mapBox = new SharpMap.Forms.MapBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnGerarMapa);
            this.panel1.Controls.Add(this.boxMagMax);
            this.panel1.Controls.Add(this.boxMagMin);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.boxRaio);
            this.panel1.Controls.Add(this.boxLon);
            this.panel1.Controls.Add(this.boxLat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.boxDataMax);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.boxDataMin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(647, 38);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 18;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(647, 67);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerarMapa
            // 
            this.btnGerarMapa.Location = new System.Drawing.Point(647, 9);
            this.btnGerarMapa.Name = "btnGerarMapa";
            this.btnGerarMapa.Size = new System.Drawing.Size(75, 23);
            this.btnGerarMapa.TabIndex = 16;
            this.btnGerarMapa.Text = "Gerar Mapa";
            this.btnGerarMapa.UseVisualStyleBackColor = true;
            this.btnGerarMapa.Click += new System.EventHandler(this.btnGerarMapa_Click);
            // 
            // boxMagMax
            // 
            this.boxMagMax.Location = new System.Drawing.Point(588, 41);
            this.boxMagMax.Name = "boxMagMax";
            this.boxMagMax.Size = new System.Drawing.Size(21, 20);
            this.boxMagMax.TabIndex = 15;
            // 
            // boxMagMin
            // 
            this.boxMagMin.Location = new System.Drawing.Point(542, 41);
            this.boxMagMin.Name = "boxMagMin";
            this.boxMagMin.Size = new System.Drawing.Size(21, 20);
            this.boxMagMin.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Magnitude: De";
            // 
            // boxRaio
            // 
            this.boxRaio.Location = new System.Drawing.Point(368, 65);
            this.boxRaio.Name = "boxRaio";
            this.boxRaio.Size = new System.Drawing.Size(51, 20);
            this.boxRaio.TabIndex = 11;
            this.boxRaio.Text = "5";
            // 
            // boxLon
            // 
            this.boxLon.Location = new System.Drawing.Point(368, 41);
            this.boxLon.Name = "boxLon";
            this.boxLon.Size = new System.Drawing.Size(51, 20);
            this.boxLon.TabIndex = 10;
            this.boxLon.Text = "-9.13549";
            // 
            // boxLat
            // 
            this.boxLat.Location = new System.Drawing.Point(368, 18);
            this.boxLat.Name = "boxLat";
            this.boxLat.Size = new System.Drawing.Size(51, 20);
            this.boxLat.TabIndex = 9;
            this.boxLat.Text = "38.7071";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Raio";
            // 
            // boxDataMax
            // 
            this.boxDataMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boxDataMax.Location = new System.Drawing.Point(79, 60);
            this.boxDataMax.Name = "boxDataMax";
            this.boxDataMax.Size = new System.Drawing.Size(95, 20);
            this.boxDataMax.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lon.";
            // 
            // boxDataMin
            // 
            this.boxDataMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boxDataMin.Location = new System.Drawing.Point(79, 24);
            this.boxDataMin.Name = "boxDataMin";
            this.boxDataMin.Size = new System.Drawing.Size(95, 20);
            this.boxDataMin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lat.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ponto central em graus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intervalo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parâmetros";
            // 
            // mapBox
            // 
            this.mapBox.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.mapBox.BackColor = System.Drawing.Color.White;
            this.mapBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapBox.FineZoomFactor = 10D;
            this.mapBox.Location = new System.Drawing.Point(2, 109);
            this.mapBox.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.LayerByIndex;
            this.mapBox.Name = "mapBox";
            this.mapBox.QueryGrowFactor = 5F;
            this.mapBox.QueryLayerIndex = 0;
            this.mapBox.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapBox.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapBox.ShowProgressUpdate = false;
            this.mapBox.Size = new System.Drawing.Size(731, 405);
            this.mapBox.TabIndex = 1;
            this.mapBox.Text = "mapBox";
            this.mapBox.WheelZoomMagnitude = -2D;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 518);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "View";
            this.Text = "MapQuake";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker boxDataMax;
        private System.Windows.Forms.DateTimePicker boxDataMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxRaio;
        private System.Windows.Forms.TextBox boxLon;
        private System.Windows.Forms.TextBox boxLat;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerarMapa;
        private System.Windows.Forms.TextBox boxMagMax;
        private System.Windows.Forms.TextBox boxMagMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private SharpMap.Forms.MapBox mapBox;
    }
}