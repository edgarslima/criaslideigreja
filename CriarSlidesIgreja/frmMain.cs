using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;
using System.Collections;
using System.IO;

namespace CriarSlidesIgreja
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                string strArqSaida = Path.GetFullPath(tbPastaSaida.Text) + "\\" + tbTituloMusica.Text + ".pptx";
                string strArqModelo = tbArquivoModelo.Text;
                criaArquivoPPT(strArqModelo, strArqSaida);

                MessageBox.Show(this, $"Arquivo gerado com sucesso.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace);
            }


        }

        private void btnCorFonte_Click(object sender, EventArgs e)
        {
            colorDialogFonte.ShowDialog(this);
            btnCorFonte.BackColor = colorDialogFonte.Color;
        }

        private int BGR(Color color)
        {
            // PowerPoint's color codes seem to be reversed (i.e., BGR) not RGB
            //      0x0000FF    produces RED not BLUE
            //      0xFF0000    produces BLUE not RED
            // so we have to produce the color "in reverse"

            int iColor = (color.A << 24) | (color.B << 16) | (color.G << 8) | color.R;
            return iColor;
        }

        private void criaArquivoPPT(string strArqModelo, string strArqSaida)
        {
            try
            {
                PowerPoint.Application pptApplication = new PowerPoint.Application();

                Microsoft.Office.Interop.PowerPoint.Slides slides;
                Microsoft.Office.Interop.PowerPoint._Slide slide;
                Microsoft.Office.Interop.PowerPoint.TextRange objText;
                int i = 1;

                PowerPoint.Presentation pptPresentation = pptApplication.Presentations.Open(strArqModelo, MsoTriState.msoTrue);

                Microsoft.Office.Interop.PowerPoint.CustomLayout customLayout = pptPresentation.Slides[1].CustomLayout;

                slides = pptPresentation.Slides;


                string[] linhas = tbLetra.Lines;
                ArrayList conjuntoLinhas = new ArrayList();
                int totalLinhas = int.Parse(numLinhas.Value.ToString());
                string strTemp = "";

                i = 1;
                foreach (string linha in linhas)
                {
                    string strLinha = linha.Trim();

                    if (strLinha.Trim().Length == 0)
                        continue;

                    if (chkLetrasMaiusculas.Checked == true)
                    {
                        strLinha = strLinha.ToUpper();
                    }

                    if (strTemp.Trim().Length > 1)
                    {
                        strTemp += Environment.NewLine;
                    }
                    strTemp += strLinha;
                    if (i == totalLinhas)
                    {
                        i = 0;
                        conjuntoLinhas.Add(strTemp);
                        strTemp = "";
                    }
                    i++;
                }
                if (strTemp.Trim().Length > 1)
                {
                    conjuntoLinhas.Add(strTemp);
                }

                i = 1;

                slide = slides.AddSlide(i, customLayout);
                i++;
                objText = slide.Shapes[1].TextFrame.TextRange;
                objText.Text = tbTituloMusica.Text;
                if (chkLetrasMaiusculas.Checked == true)
                {
                    objText.Text = objText.Text.ToUpper();
                }
                objText.Font.Name = "Arial Black";
                objText.Font.Bold = MsoTriState.msoTrue;
                objText.Font.Size = int.Parse(numTamanhoTitulo.Value.ToString());
                objText.Font.Color.RGB = BGR(btnCorFonte.BackColor);

                objText = slide.Shapes[2].TextFrame.TextRange;
                objText.Text = " ";
                objText.Font.Name = "Arial";
                objText.Font.Size = 10;

                foreach (string linha in conjuntoLinhas)
                {
                    if (linha.Trim().Length == 0)
                        continue;

                    slide = slides.AddSlide(i, customLayout);
                    i++;

                    objText = slide.Shapes[1].TextFrame.TextRange;
                    objText.Text = linha;
                    objText.Font.Name = "Arial";
                    objText.Font.Size = int.Parse(numTamanhoFonte.Value.ToString());
                    objText.Font.Color.RGB = BGR(btnCorFonte.BackColor);

                    objText = slide.Shapes[2].TextFrame.TextRange;
                    objText.Text = " ";
                    objText.Font.Name = "Arial";
                    objText.Font.Size = 10;

                }

                pptPresentation.Slides[i].Delete();

                pptPresentation.SaveAs(strArqSaida, Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string strArqModelo = Path.GetFullPath(getPastaDocumentos()) + "\\modelo.pptx";

                if (File.Exists(strArqModelo))
                {
                    tbArquivoModelo.Text = strArqModelo;
                }
                tbPastaSaida.Text = getPastaDocumentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Erro ao verificar arquivo de modelo. {Environment.NewLine} {ex.Message}");
            }
        }

        private string getPastaDocumentos()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
        private void btnPastaSaida_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserTela.SelectedPath = getPastaDocumentos();
                folderBrowserTela.ShowDialog(this);
                if (folderBrowserTela.SelectedPath.Length <= 2)
                {
                    MessageBox.Show(this, "É necessário selecionar uma pasta para gravação do arquivo de saída.");
                    return;
                }
                tbPastaSaida.Text = folderBrowserTela.SelectedPath;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Erro ao selecionar arquivo de modelo: {ex.Message}{Environment.NewLine}{Environment.NewLine}{ex.StackTrace}");
            }
        }

        private void btnArquivoModelo_Click(object sender, EventArgs e)
        {
            try
            {
                openFileTela.Title = "Selecione o arquivo de modelo";
                openFileTela.FileName = "modelo.pptx";
                openFileTela.Filter = "Arquivo PPTX|*.pptx|Arquivo PPT|*.ppt";
                openFileTela.ShowDialog(this);
                if (File.Exists(openFileTela.FileName) == false)
                {
                    MessageBox.Show(this, "É necessário selecionar um arquivo de modelo.");
                    return;
                }
                tbArquivoModelo.Text = openFileTela.FileName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Erro ao selecionar arquivo de modelo: {ex.Message}{Environment.NewLine}{Environment.NewLine}{ex.StackTrace}");
            }
        }

        private void btnAbrirLetra_Click(object sender, EventArgs e)
        {
            try
            {
                openFileTela.Title = "Selecione um arquivo de texto (TXT) com a letra da música";
                openFileTela.FileName = "letra.txt";
                openFileTela.Filter = "Arquivo txt|*.txt";
                openFileTela.ShowDialog(this);
                if (File.Exists(openFileTela.FileName) == false)
                {
                    MessageBox.Show(this, "É necessário selecionar um arquivo de texto.");
                    return;
                }
                tbLetra.Text = File.ReadAllText(openFileTela.FileName);
                tbTituloMusica.Text = openFileTela.SafeFileName.Replace(".txt", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Erro ao selecionar arquivo de modelo: {ex.Message}{Environment.NewLine}{Environment.NewLine}{ex.StackTrace}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
