using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjectMarouane;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;

namespace ProjectM.PL
{
    public partial class View : Form
    {
        ProjectMarouane.DAL.DataAccessLayer data = new ProjectMarouane.DAL.DataAccessLayer();
        public View()
        {
            InitializeComponent();
            
         

        }
        private string GetMatricule(string number)
        {

            int cmp = 8 - number.Length;
            string mt = "";
            for (int i = 0; i < cmp; i++)
            {
                mt += "0";
            }
            return mt + number;
        }
        DataTable fillData(string stored_procedure)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@numSale", SqlDbType.Int);
            param[0].Value = Program.i;
            return data.GetData(stored_procedure, param);


        }

        private void View_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataTable d = new DataTable();
                DataTable table = new DataTable();
                DataTable SizeR = new DataTable();
                dt = fillData("getFullSale");
                txtId.Text = dt.Rows[0][14].ToString();
                txtNomC.Text = dt.Rows[0][15].ToString();
                txtTele.Text = dt.Rows[0][16].ToString();
                txtEmail.Text = dt.Rows[0][17].ToString();
                txtAge.Text = dt.Rows[0][18].ToString();
                txtNumOS.Text = GetMatricule(Program.i.ToString());
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0][2]);
                txtDesc.Text = dt.Rows[0][1].ToString();
                cb_type.Text = dt.Rows[0][6].ToString();

                if (dt.Rows[0][5].ToString() == "Oui")
                {
                    rb_yes.Checked = true;
                }
                else
                {
                    rb_false.Checked = true;
                }
                table = fillData("getSizeL");
                SphVLL.Text = table.Rows[0][1].ToString();
                SphVPL.Text = table.Rows[0][2].ToString();
                CylVLL.Text = table.Rows[0][3].ToString();
                CylVPL.Text = table.Rows[0][4].ToString();
                AxeVLL.Text = table.Rows[0][5].ToString();
                AxeVPL.Text = table.Rows[0][6].ToString();
                VNLL.Text = table.Rows[0][7].ToString();
                VNPL.Text = table.Rows[0][8].ToString();
                AddL.Text = table.Rows[0][9].ToString();
                SizeR = fillData("getSizeR");
                SphVLR.Text = SizeR.Rows[0][1].ToString();
                SphVPR.Text = SizeR.Rows[0][2].ToString();
                CylVLR.Text = SizeR.Rows[0][3].ToString();
                CylVPR.Text = SizeR.Rows[0][4].ToString();
                AxeVLR.Text = SizeR.Rows[0][5].ToString();
                AxeVPR.Text = SizeR.Rows[0][6].ToString();
                VNLR.Text = SizeR.Rows[0][7].ToString();
                VNPR.Text = SizeR.Rows[0][8].ToString();
                AddR.Text = SizeR.Rows[0][9].ToString();
                d = fillData("getDetails");
                dgv_detaills.DataSource = d;
                txtSum.Text = dt.Rows[0][7].ToString();
                txtAv.Text = dt.Rows[0][8].ToString();
                txtRes.Text = (Convert.ToInt32(txtSum.Text) - Convert.ToInt32(txtAv.Text)).ToString();
            }
            catch
            {
                return;
            }
        
           
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.pdf)|*.pdf|All files (*.pdf)|*.pdf";
            if (save.ShowDialog()== DialogResult.OK)
            {
                float[] widiths = new float[] { 300 };
                MemoryStream ms = new MemoryStream();
                Document doc = new Document(PageSize.LETTER, 10, 10, 10, 10);
                PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));

                doc.Open();
                PdfContentByte cb = pdf.DirectContent;
                Properties.Resources.Optique.Save(ms, ImageFormat.Png);
                var img = ms.ToArray();
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(img);
                image.ScaleToFit(70, 50);
                image.SetAbsolutePosition(45, 700);
                doc.Add(image);
                PdfPTable tb = new PdfPTable(1);
                tb.SetWidths(widiths);
                tb.SetTotalWidth(widiths);

                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                PdfPCell cell1 = new PdfPCell(new Phrase(new Chunk("Maouan Tanouti", boldFont)));
                cell1.BorderWidth = 0;
                cell1.PaddingLeft = 0;
                PdfPCell cell2 = new PdfPCell(new Phrase("Opticien Optométriste"));
                cell2.BorderWidth = 0;
                cell2.PaddingLeft = 0;
                PdfPCell cell3 = new PdfPCell(new Phrase("Lotissement Majd LOT 479 AOUAMA-TANGER"));
                cell3.BorderWidth = 0;
                cell3.PaddingLeft = 0;

                tb.AddCell(cell1);
                tb.AddCell(cell2);
                tb.AddCell(cell3);
                tb.WriteSelectedRows(0, -1, 100, 750, cb);
                PdfPTable tbnum = new PdfPTable(1);//numero de facture et la date
                PdfPCell header = new PdfPCell(new Phrase(new Chunk("Facture " + txtNumOS.Text, boldFont)));
                PdfPCell cellCon = new PdfPCell(new Phrase("Tanger le " + dateTimePicker1.Value.ToShortDateString()));
                cellCon.BorderWidth = 0;
                header.BorderWidth = 0;
                tbnum.AddCell(header);

                tbnum.AddCell(cellCon);
                tbnum.SetTotalWidth(widiths);
                tbnum.DefaultCell.BorderWidth = 0;
                tbnum.WriteSelectedRows(0, -1, 45, 670, cb);

                //Client

                PdfPTable tbh = new PdfPTable(1);
                PdfPCell headerC = new PdfPCell(new Phrase(new Chunk("Client", boldFont)));
                headerC.BorderWidth = 0;
                headerC.HorizontalAlignment = 1;
                headerC.Padding = 3f;
                tbh.SetTotalWidth(new float[] { 400 });
                headerC.BackgroundColor = new BaseColor(153, 180, 209);
                tbh.AddCell(headerC);
                tbh.WriteSelectedRows(0, -1, 100, 620, cb);
                //label set name
                PdfPTable tbn = new PdfPTable(2);
                PdfPCell headern = new PdfPCell(new Phrase(new Chunk("Nom et prénom", boldFont)));
                headern.BorderWidth = 0;
                headern.Padding = 3f;
                //set name
                string name = txtNomC.Text;
                PdfPCell hn = new PdfPCell(new Phrase(new Chunk(name, boldFont)));
                hn.BorderWidth = 0;
                hn.HorizontalAlignment = 2;
                hn.Padding = 3f;
                //
                tbn.SetTotalWidth(new float[] { 200, 200 });
                tbn.AddCell(headern);
                tbn.AddCell(hn);
                tbn.WriteSelectedRows(0, -1, 100, 600, cb);
                //Set table Sales
                PdfPTable tbsale = new PdfPTable(3);
                //set cells
                PdfPCell qte = new PdfPCell(new Phrase(new Chunk("Qte", boldFont)));
                qte.BackgroundColor = new BaseColor(153, 180, 209);
                qte.Padding = 4f;
                qte.HorizontalAlignment = 1;
                PdfPCell Dés = new PdfPCell(new Phrase(new Chunk("Désignation", boldFont)));
                Dés.BackgroundColor = new BaseColor(153, 180, 209);
                Dés.Padding = 4f;
                Dés.HorizontalAlignment = 1;
                PdfPCell Total = new PdfPCell(new Phrase(new Chunk("Total", boldFont)));
                Total.BackgroundColor = new BaseColor(153, 180, 209);
                Total.Padding = 4f;
                Total.HorizontalAlignment = 1;
                tbsale.SetTotalWidth(new float[] { 40, 200, 60 });
                tbsale.AddCell(qte);
                tbsale.AddCell(Dés);
                tbsale.AddCell(Total);
                tbsale.DefaultCell.PaddingTop = 20f;
                tbsale.DefaultCell.PaddingBottom = 20f;
                tbsale.DefaultCell.BorderWidthBottom = 0;
                PdfPCell labelSum = new PdfPCell(new Phrase(new Chunk("Somme TTC : " + txtSum.Text + " Dh", boldFont)));
                labelSum.Colspan = 3;
                labelSum.HorizontalAlignment = 2;
                labelSum.BackgroundColor = new BaseColor(153, 180, 209);
                labelSum.Padding = 4f;
                DataTable dd = new DataTable();
                dd.Columns.Add("Qte"); dd.Columns.Add("Désignation"); dd.Columns.Add("Total");
                for (int i = 0; i < dgv_detaills.RowCount; i++)
                {
                    dd.Rows.Add(dgv_detaills.Rows[i].Cells[3].Value, dgv_detaills.Rows[i].Cells[2].Value, dgv_detaills.Rows[i].Cells[4].Value);
                }

                for (int i = 0; i < dd.Rows.Count; i++)
                    for (int j = 0; j < dd.Columns.Count; j++)
                    {

                        if (dd.Rows[i][j] != null)
                        {
                            tbsale.AddCell(dd.Rows[i][j].ToString());
                        }
                    }
                tbsale.AddCell(labelSum);


                iTextSharp.text.Rectangle page = doc.PageSize;
                tbsale.WriteSelectedRows(0, -1, 150, 540, cb);



                doc.Close();
                System.Diagnostics.Process.Start(save.FileName);
            }
            
        }
    }
}
