﻿using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Prog3.RestoDotNet.App
{
    public partial class FormMapEdition : Form
    {

        MoveableTable moveableItem;
        private bool isPressedDown = false;
        Point initial;

        private readonly ITableSvc _tableSvc;

        public FormMapEdition(ITableSvc tableSvc)
        {
            InitializeComponent();
            _tableSvc = tableSvc;
        }

        private void SetAsMoveable()
        {

            // WHERE SPECIFIC CONTROL IN "FORM"
            // this.Controls.OfType<Control>().Where(ctr => ctr is Button).ToList().ForEach(ctr =>
            // SIMPLE ALL CONTROLS IN "FORM"
            // this.Controls.OfType<Control>().ToList().ForEach(ctr =>
            // SIMPLE ALL CONTROLS IN CONTAINER CONTROL IN "FORM"
            // this.groupBox1.Controls.OfType<Control>().ToList().ForEach(ctr =>

            //this.PnlMap.Controls
            //    .OfType<MoveableTable>()
            //    //.Where(ctr => ctr is MoveableTable)
            //    .ToList()
            //    .ForEach(ctr =>
            //        {
            //            ctr.MouseDown += Ctr_MouseDown;
            //            ctr.MouseUp += Ctr_MouseUp;
            //            ctr.MouseMove += Ctr_MouseMove;
            //        }
            //    )
            //;

            if (moveableItem != null)
            {
                moveableItem.MouseDown += Ctr_MouseDown;
                moveableItem.MouseUp += Ctr_MouseUp;
                moveableItem.MouseMove += Ctr_MouseMove;
            }
        }

        private void Ctr_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;

            if (isPressedDown)
            {
                ctr.Top += e.Y - initial.Y;
                ctr.Left += e.X - initial.X;
                // ctr.Left = e.X + ctr.Left - initial.X;
                // ctr.Top = e.Y + ctr.Top - initial.Y;
            }

        }

        private void Ctr_MouseUp(object sender, MouseEventArgs e) => isPressedDown = false;

        private void Ctr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPressedDown = true;
                initial = e.Location;
            }
        }

        private void Table_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveableItem = CreateMoveableTable(sender as PictureBox);
                moveableItem.Left = 300;
                moveableItem.Top = 300;
                moveableItem.Width = 90;
                moveableItem.Height = 90;
                moveableItem.SizeMode = PictureBoxSizeMode.StretchImage;

                moveableItem.ContextMenuStrip = this.cmenuStripTable;

                this.PnlMap.Controls.Add(moveableItem);
                this.SetAsMoveable();
            }
        }

        private MoveableTable CreateMoveableTable(PictureBox ctr)
        {
            return new MoveableTable
            {
                Image = ctr.Image,
                Location = ctr.Location,
                Name = "temp",
                Size = ctr.Size
            };
        }

        private void FijarToolStripMenuItem_Click(object sender, EventArgs e)
        {            

        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control ctr = (Control)sender; //ESTE ES EL CONTEXT MENU STRIP

            this.PnlMap.Controls.Remove(ctr);
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            //TODO: al presionar guardar llenar esta lista con las mesas creadas luego de ediar el mapa
            var tableList = new List<TableDto>();
            var svcResp = await _tableSvc.SetInitialTableArrangementAsync(tableList);

            if (svcResp.HasError)
            {
                //TODO tratar error
            }

            if (svcResp.Data)
            {
                //TODO: guardar antes el mapa
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}