using System.Runtime.InteropServices;

namespace AverageTool;
public partial class Exame : Form
{
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(nint hwnd, int wmsg, int wparam, int lparam);
    public Exame() => InitializeComponent();
    private void FecharExame_Click(object sender, EventArgs e) => this.Close();

    private void CalcularExame_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(Exame_NotaMediaTxt.Text) || string.IsNullOrEmpty(Exame_NotaExameTxt.Text))
                throw new Exception("NAO PODE ESTAR VAZIO");

            Exame_NotaMediaTxt.Text = Exame_NotaMediaTxt.Text.Replace("-", "").Replace(".", ",");
            Exame_NotaExameTxt.Text = Exame_NotaExameTxt.Text.Replace("-", "").Replace(".", ",");

            double doubleMedia = double.Parse(Exame_NotaMediaTxt.Text);
            double doubleExame = double.Parse(Exame_NotaExameTxt.Text);

            if (doubleExame is > 10 || doubleMedia is > 10)
                throw new Exception("Valor Excedido");

            double valorMediaFinal = (doubleMedia + doubleExame) / 2;

            Exame_CampoResultado.Text = $"{valorMediaFinal:F2}";
            Exame_Formula.Text = $"{doubleMedia} + {doubleExame}";

            if (valorMediaFinal >= 5)
            {
                Exame_Situacao.Text = "Aprovado";
                Exame_Situacao.ForeColor = Color.Green;
                Exame_CampoResultado.ForeColor = Color.Green;
            }
            else
            {
                Exame_Situacao.Text = "Reprovado";
                Exame_Situacao.ForeColor = Color.Red;
                Exame_CampoResultado.ForeColor = Color.Red;
            }
        }
        catch (Exception ex)
        {
            if (ex.Message.Contains("Valor Excedido"))
                MessageBox.Show($"A Nota não deve ser maior que 10\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show($"{ex.Message}\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ExameTitulo_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }
}