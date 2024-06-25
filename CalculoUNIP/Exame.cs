using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageTool;
public partial class Exame : Form
{
    public Exame()
    {
        InitializeComponent();
    }

    private void FecharExame_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void CalcularExame_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(Exame_NotaMediaTxt.Text) || string.IsNullOrEmpty(Exame_NotaExameTxt.Text))
                throw new Exception("NAO PODE ESTAR VAZIO");

            Exame_NotaMediaTxt.Text= Exame_NotaMediaTxt.Text.Replace("-","").Replace(".",",");
            Exame_NotaExameTxt.Text= Exame_NotaExameTxt.Text.Replace("-", "").Replace(".", ",");

            double doubleMedia = double.Parse(Exame_NotaMediaTxt.Text);
            double doubleExame = double.Parse(Exame_NotaExameTxt.Text);

            if(doubleExame is >10 || doubleMedia is > 10)
                throw new Exception("Valor Excedido");

            double valorMediaFinal = (doubleMedia+ doubleExame) / 2;

            Exame_CampoResultado.Text = $"{valorMediaFinal:F2}";
            Exame_Formula.Text = $"{doubleMedia} + {doubleExame}";


        }
        catch (Exception ex)
        {
            if (ex.Message.Contains("Valor Excedido"))
            {
                MessageBox.Show($"A Nota não deve ser maior que 10\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"{ex.Message}\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(nint hwnd, int wmsg, int wparam, int lparam);
    private void ExameTitulo_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }
}