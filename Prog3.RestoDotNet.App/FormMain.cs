﻿using Prog3.RestoDotNet.App.XmlObjects;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Prog3.RestoDotNet.App
{
    public partial class FormMain : Form
    {
        private readonly IOrderSvc _orderSvc;
        private readonly ITableSvc _tableSvc;
        private OpenFileDialog openFile;
        private List<TableDto> tableObjs;

        public FormMain(IOrderSvc orderSvc, ITableSvc tableSvc)
        {
            InitializeComponent();
            _orderSvc = orderSvc;
            _tableSvc = tableSvc;
        }

        private async Task GetRelatedTables(Guid trackId)
        {
            var svcResp = await _tableSvc.GetAllByTrackId(trackId);

            tableObjs = svcResp.Data.ToList();
        }

        private void UpdateState()
        {
            foreach (MoveableTable item in PnlMapLoad.Controls.OfType<MoveableTable>())
            {

                switch (item.BindedEntity.State) 
                {
                    case TableStateEnum.DISPONIBLE:
                        item.BackColor = Color.Transparent;
                        break;
                    case TableStateEnum.OCUPADO:
                        item.BackColor = Color.Red;  
                        break;
                    case TableStateEnum.RESERVADO:
                        item.BackColor = Color.Yellow;  
                        break;
                    default:
                        item.BackColor = Color.Transparent; 
                        break;
                }
            }
        }

        private void VerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = (sender as ToolStripItem);
            if (item != null)
            {
                ContextMenuStrip owner = item.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    new FormTableStatus((MoveableTable)owner.SourceControl, _orderSvc).ShowDialog();
                }
            }

        }

        private async void CargarMapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.InitialDirectory = Directory.CreateDirectory($@"{Environment.CurrentDirectory}/Mapas").FullName;
            openFile.Multiselect = false;
            openFile.Filter = "|*.xml";
            openFile.ShowHelp = false;

            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            var path = openFile.FileName;

            XmlSerializer reader = new XmlSerializer(typeof(List<XmlTable>));

            StreamReader file = new StreamReader(path);
            var xmlTables = (List<XmlTable>)reader.Deserialize(file);

            //cargar mesas correspondientes al mapa
            await GetRelatedTables(xmlTables.First().TackId);

            foreach (XmlTable item in xmlTables)
            {

                MoveableObject temp = tableObjs.Any(t => t.MoveableTableId == item.Id)
                    ? new MoveableTable
                    {
                        BindedEntity = tableObjs.First(t => t.MoveableTableId == item.Id),
                        ContextMenuStrip = cMenuStripMapLoad
                    } : new MoveableObject();

                temp.Id = item.Id;
                temp.Height = item.Height;
                temp.Width = item.Width;
                temp.Left = item.Left;
                temp.Top = item.Top;
                Point loc = new Point();
                loc.X = item.X;
                loc.Y = item.Y;
                temp.Location = loc;
                temp.SizeMode = PictureBoxSizeMode.StretchImage;
                temp.BackColor = Color.Transparent;

                var dir = Directory.CreateDirectory($@"{Environment.CurrentDirectory}/Imagenes");
                var imgPath = $@"{dir.FullName}/{item.imageFile}";
                temp.Image = Image.FromFile(imgPath);

                this.PnlMapLoad.Controls.Add(temp);
            }

            file.Close();
            PnlMapLoad.Visible = PnlMapLoad.Controls.Count > 0;

            UpdateState();
        }

        private void CrearMapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormMapEdition(_tableSvc).ShowDialog();
        }

        private void CerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            UpdateState();
        }
    }
}
