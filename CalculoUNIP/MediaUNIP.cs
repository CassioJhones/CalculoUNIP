
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CalculoUNIP;
public partial class MediaUnip : Form
{
    public const int MediaDisciplina = 7;
    public MediaUnip()
    {
        InitializeComponent();

    }

    private void BTN_CALCULAR_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(MSK_AVA.Text) || string.IsNullOrEmpty(MSK_PIM.Text) || string.IsNullOrEmpty(MSK_PROVA.Text))
                throw new Exception("NAO PODE ESTAR VAZIO");

            MSK_AVA.Text = MSK_AVA.Text.Replace("-", "").Replace(".", ",").Trim();
            MSK_PIM.Text = MSK_PIM.Text.Replace("-", "").Replace(".", ",").Trim();
            MSK_PROVA.Text = MSK_PROVA.Text.Replace("-", "").Replace(".", ",").Trim();


            //converte string em double para fazer o calculo
            double notaAva = double.Parse(MSK_AVA.Text);
            double notaProva = double.Parse(MSK_PROVA.Text);
            double notaPim = double.Parse(MSK_PIM.Text);

            double valorMedia = ((7 * notaProva) + (2 * notaPim) + (1 * notaAva)) / 10;
            label1_conta.Text = $"(7x{notaProva})+(2x{notaPim})+(1x{notaAva})";
            //Formata para mostrar duas casas decimais 
            string mostrarMedia = valorMedia.ToString("F2");
            LB_RESULT.Text = $"{mostrarMedia}";


            if (valorMedia >= 6.7 && valorMedia < MediaDisciplina)
            {
                valorMedia = MediaDisciplina;//Arredonda de acordo com Manual do Aluno
                Label_Situacao.Text = " APROVADO\nNota Arredondada ";
                Label_Situacao.ForeColor = Color.YellowGreen;
            }

            else if (valorMedia >= MediaDisciplina)
            {
                Label_Situacao.Text = " APROVADO ";
                Label_Situacao.ForeColor = Color.Green;
            }
            else
            {
                Label_Situacao.Text = " FAZER O EXAME ";
                Label_Situacao.ForeColor = Color.Red;
            }
        }

        catch (FormatException)
        {//Erro comum causado pelo usuario
            MessageBox.Show($"Preencha corretamente os Campos\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        catch (ArgumentNullException)
        {
            MessageBox.Show($"CAMPOS ESTAO VAZIOS\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        catch (Exception)
        {
            MessageBox.Show($"Preencha corretamente os Campos\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Fechar_botao_Click(object sender, EventArgs e) => Application.Exit();

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(nint hwnd, int wmsg, int wparam, int lparam);

    private void Titulo_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        try
        {
            string link = "https://unip.br/";
            string github = "https://github.com/CassioJhones?tab=repositories";
            ProcessStartInfo SiteFaculdade = new()
            {
                FileName = "cmd",
                Arguments = $"/c start {link}",
                UseShellExecute = false
            };
            ProcessStartInfo GitHubCassio = new()
            {
                FileName = "cmd",
                Arguments = $"/c start {github}",
                UseShellExecute = false
            };
            Process.Start(SiteFaculdade);
            Process.Start(GitHubCassio);
        }
        catch (Exception)
        {
            MessageBox.Show($"Erro ao abrir navegador\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}