
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CalculoUNIP;
public partial class MediaUnip : Form
{
    public const int MediaDisciplina = 7;
    public MediaUnip() => InitializeComponent();

    private void BTN_CALCULAR_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(InputAVA.Text) || string.IsNullOrEmpty(InputPIM.Text) || string.IsNullOrEmpty(InputProva.Text))
                throw new Exception("NAO PODE ESTAR VAZIO");

            InputAVA.Text = InputAVA.Text.Replace("-", "").Replace(".", ",").Trim();
            InputPIM.Text = InputPIM.Text.Replace("-", "").Replace(".", ",").Trim();
            InputProva.Text = InputProva.Text.Replace("-", "").Replace(".", ",").Trim();

            double notaAva = double.Parse(InputAVA.Text);
            double notaProva = double.Parse(InputProva.Text);
            double notaPim = double.Parse(InputPIM.Text);

            if (notaAva is > 10 || notaProva is > 10 || notaPim is > 10)
                throw new Exception("Valor Excedido");

            double valorMedia = ((7 * notaProva) + (2 * notaPim) + (1 * notaAva)) / 10;
            LabelFormula.Text = $"(7x{notaProva})+(2x{notaPim})+(1x{notaAva})";

            //Formata para mostrar duas casas decimais 
            string mostrarMedia = valorMedia.ToString("F2");
            LabelResultado.Text = $"{mostrarMedia}";

            if (valorMedia >= 6.7 && valorMedia < MediaDisciplina)
            {
                valorMedia = MediaDisciplina;//Arredonda de acordo com Manual do Aluno
                Label_Situacao.Text = "APROVADO\nNota Arredondada ";
                Label_Situacao.ForeColor = Color.YellowGreen;
            }

            else if (valorMedia >= MediaDisciplina)
            {
                Label_Situacao.Text = "APROVADO";
                Label_Situacao.ForeColor = Color.Green;
            }
            else
            {
                Label_Situacao.Text = "FAZER O EXAME";
                Label_Situacao.ForeColor = Color.Red;
            }
        }

        catch (FormatException)
        {//Erro comum causado pelo usuario
            MessageBox.Show($"Preencha corretamente os Campos\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LimparCampos();
        }

        catch (ArgumentNullException)
        {
            MessageBox.Show($"Campos vazios\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        catch (Exception exe)
        {
            if (exe.Message.Contains("Valor Excedido"))
            {

                MessageBox.Show($"A Nota não deve ser maior que 10\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
            }
            else
            {
                MessageBox.Show($"{exe.Message}\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
            }
        }
    }

    private void LimparCampos()
    {
        InputAVA.Text = "";
        InputPIM.Text = "";
        InputProva.Text = "";
    }

    private void Fechar_botao_Click(object sender, EventArgs e)
        => Application.Exit();

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(nint hwnd, int wmsg, int wparam, int lparam);

    private void Titulo_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {
        AbrirSite("https://unip.br/");
        AbrirSite("https://github.com/CassioJhones?tab=repositories");
    }

    private void AbrirSite(string link)
    {
        try
        {
            ProcessStartInfo AbrirNavegador = new()
            {
                FileName = "cmd",
                Arguments = $"/c start {link}",
                UseShellExecute = false
            };

            Process.Start(AbrirNavegador);
        }
        catch (Exception)
        {
            MessageBox.Show($"Erro ao abrir navegador\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
}
