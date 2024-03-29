﻿namespace Prog3.RestoDotNet.App
{
    partial class FormTableStatus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableStatus));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbMesero = new System.Windows.Forms.ComboBox();
            this.waiterDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rTBoxNotes = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxChair = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.dTPickerReserved = new System.Windows.Forms.DateTimePicker();
            this.cBoxReserved = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pBoxImageTable = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.btnDeletedMeal = new System.Windows.Forms.Button();
            this.CmbComidas = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.btnSaveTableState = new System.Windows.Forms.Button();
            this.GpbReserva = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waiterDtoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImageTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealDtoBindingSource)).BeginInit();
            this.GpbReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbMesero);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cBoxState);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rTBoxNotes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tBoxChair);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBoxDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBoxID);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de Mesa";
            // 
            // CmbMesero
            // 
            this.CmbMesero.DataSource = this.waiterDtoBindingSource;
            this.CmbMesero.DisplayMember = "Name";
            this.CmbMesero.FormattingEnabled = true;
            this.CmbMesero.Location = new System.Drawing.Point(6, 113);
            this.CmbMesero.Name = "CmbMesero";
            this.CmbMesero.Size = new System.Drawing.Size(300, 21);
            this.CmbMesero.TabIndex = 15;
            this.CmbMesero.ValueMember = "Id";
            this.CmbMesero.SelectedValueChanged += new System.EventHandler(this.CmbMesero_SelectedValueChanged);
            // 
            // waiterDtoBindingSource
            // 
            this.waiterDtoBindingSource.DataSource = typeof(Prog3.RestoDotNet.Model.Dtos.WaiterDto);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado:";
            // 
            // cBoxState
            // 
            this.cBoxState.Enabled = false;
            this.cBoxState.FormattingEnabled = true;
            this.cBoxState.Items.AddRange(new object[] {
            "Libre",
            "Ocupado",
            "Reservado"});
            this.cBoxState.Location = new System.Drawing.Point(160, 75);
            this.cBoxState.Name = "cBoxState";
            this.cBoxState.Size = new System.Drawing.Size(145, 21);
            this.cBoxState.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Notas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mesero:";
            // 
            // rTBoxNotes
            // 
            this.rTBoxNotes.Location = new System.Drawing.Point(6, 160);
            this.rTBoxNotes.Name = "rTBoxNotes";
            this.rTBoxNotes.Size = new System.Drawing.Size(299, 78);
            this.rTBoxNotes.TabIndex = 10;
            this.rTBoxNotes.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notas:";
            // 
            // tBoxChair
            // 
            this.tBoxChair.Enabled = false;
            this.tBoxChair.Location = new System.Drawing.Point(160, 36);
            this.tBoxChair.Name = "tBoxChair";
            this.tBoxChair.Size = new System.Drawing.Size(63, 20);
            this.tBoxChair.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sillas:";
            // 
            // tBoxDescription
            // 
            this.tBoxDescription.Location = new System.Drawing.Point(6, 75);
            this.tBoxDescription.Name = "tBoxDescription";
            this.tBoxDescription.Size = new System.Drawing.Size(139, 20);
            this.tBoxDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detalle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // tBoxID
            // 
            this.tBoxID.Enabled = false;
            this.tBoxID.Location = new System.Drawing.Point(6, 36);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(63, 20);
            this.tBoxID.TabIndex = 0;
            // 
            // dTPickerReserved
            // 
            this.dTPickerReserved.Enabled = false;
            this.dTPickerReserved.Location = new System.Drawing.Point(305, 10);
            this.dTPickerReserved.Name = "dTPickerReserved";
            this.dTPickerReserved.Size = new System.Drawing.Size(220, 20);
            this.dTPickerReserved.TabIndex = 8;
            // 
            // cBoxReserved
            // 
            this.cBoxReserved.AutoSize = true;
            this.cBoxReserved.Location = new System.Drawing.Point(5, 12);
            this.cBoxReserved.Name = "cBoxReserved";
            this.cBoxReserved.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cBoxReserved.Size = new System.Drawing.Size(98, 17);
            this.cBoxReserved.TabIndex = 7;
            this.cBoxReserved.Text = "Reservar Mesa";
            this.cBoxReserved.UseVisualStyleBackColor = true;
            this.cBoxReserved.CheckedChanged += new System.EventHandler(this.CBoxReserved_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pBoxImageTable);
            this.groupBox2.Location = new System.Drawing.Point(344, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gráfico";
            // 
            // pBoxImageTable
            // 
            this.pBoxImageTable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pBoxImageTable.Location = new System.Drawing.Point(7, 20);
            this.pBoxImageTable.Name = "pBoxImageTable";
            this.pBoxImageTable.Size = new System.Drawing.Size(188, 142);
            this.pBoxImageTable.TabIndex = 0;
            this.pBoxImageTable.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAgregar);
            this.groupBox3.Controls.Add(this.btnDeletedMeal);
            this.groupBox3.Controls.Add(this.CmbComidas);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 215);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comidas:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(370, 186);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnDeletedMeal
            // 
            this.btnDeletedMeal.Location = new System.Drawing.Point(451, 186);
            this.btnDeletedMeal.Name = "btnDeletedMeal";
            this.btnDeletedMeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeletedMeal.TabIndex = 2;
            this.btnDeletedMeal.Text = "Borrar";
            this.btnDeletedMeal.UseVisualStyleBackColor = true;
            this.btnDeletedMeal.Click += new System.EventHandler(this.BtnDeletedMeal_Click);
            // 
            // CmbComidas
            // 
            this.CmbComidas.FormattingEnabled = true;
            this.CmbComidas.Location = new System.Drawing.Point(6, 187);
            this.CmbComidas.Name = "CmbComidas";
            this.CmbComidas.Size = new System.Drawing.Size(266, 21);
            this.CmbComidas.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mealDtoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(520, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mealDtoBindingSource
            // 
            this.mealDtoBindingSource.DataSource = typeof(Prog3.RestoDotNet.Model.Dtos.MealDto);
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseTable.Enabled = false;
            this.btnCloseTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseTable.Location = new System.Drawing.Point(297, 536);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(248, 27);
            this.btnCloseTable.TabIndex = 3;
            this.btnCloseTable.Text = "CERRAR PEDIDO";
            this.btnCloseTable.UseVisualStyleBackColor = false;
            this.btnCloseTable.Click += new System.EventHandler(this.BtnCloseTable_Click);
            // 
            // btnSaveTableState
            // 
            this.btnSaveTableState.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveTableState.Enabled = false;
            this.btnSaveTableState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTableState.Location = new System.Drawing.Point(12, 536);
            this.btnSaveTableState.Name = "btnSaveTableState";
            this.btnSaveTableState.Size = new System.Drawing.Size(272, 27);
            this.btnSaveTableState.TabIndex = 4;
            this.btnSaveTableState.Text = "GUARDAR CAMBIOS";
            this.btnSaveTableState.UseVisualStyleBackColor = false;
            this.btnSaveTableState.Click += new System.EventHandler(this.BtnSaveTable_Click);
            // 
            // GpbReserva
            // 
            this.GpbReserva.Controls.Add(this.dTPickerReserved);
            this.GpbReserva.Controls.Add(this.cBoxReserved);
            this.GpbReserva.Controls.Add(this.label8);
            this.GpbReserva.Location = new System.Drawing.Point(13, 272);
            this.GpbReserva.Name = "GpbReserva";
            this.GpbReserva.Size = new System.Drawing.Size(532, 35);
            this.GpbReserva.TabIndex = 5;
            this.GpbReserva.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Hasta:";
            // 
            // FormTableStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 575);
            this.Controls.Add(this.GpbReserva);
            this.Controls.Add(this.btnSaveTableState);
            this.Controls.Add(this.btnCloseTable);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTableStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguimiento de Mesa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waiterDtoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImageTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealDtoBindingSource)).EndInit();
            this.GpbReserva.ResumeLayout(false);
            this.GpbReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rTBoxNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPickerReserved;
        private System.Windows.Forms.CheckBox cBoxReserved;
        private System.Windows.Forms.TextBox tBoxChair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pBoxImageTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeletedMeal;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBoxState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveTableState;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox CmbComidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mealDtoBindingSource;
        private System.Windows.Forms.ComboBox CmbMesero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GpbReserva;
        private System.Windows.Forms.BindingSource waiterDtoBindingSource;
        private System.Windows.Forms.Label label8;
    }
}