namespace AverageTool;

partial class Exame
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

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exame));
        panel1 = new Panel();
        label1 = new Label();
        Exame_Situacao = new Label();
        Exame_Formula = new Label();
        label6 = new Label();
        Exame_CampoResultado = new Label();
        label_divide = new Label();
        Label_MD = new Label();
        Exame_BotaoCalcular = new Button();
        Label_Prova = new Label();
        Exame_NotaExameTxt = new MaskedTextBox();
        Label_AVA = new Label();
        Exame_NotaMediaTxt = new MaskedTextBox();
        ExameTitulo = new Panel();
        LabelTitulo = new Label();
        fechar_botao = new PictureBox();
        panel1.SuspendLayout();
        ExameTitulo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)fechar_botao).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        resources.ApplyResources(panel1, "panel1");
        panel1.Controls.Add(label1);
        panel1.Controls.Add(Exame_Situacao);
        panel1.Controls.Add(Exame_Formula);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(Exame_CampoResultado);
        panel1.Controls.Add(label_divide);
        panel1.Controls.Add(Label_MD);
        panel1.Name = "panel1";
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.BackColor = Color.White;
        label1.ForeColor = SystemColors.ActiveCaptionText;
        label1.Name = "label1";
        // 
        // Exame_Situacao
        // 
        resources.ApplyResources(Exame_Situacao, "Exame_Situacao");
        Exame_Situacao.Name = "Exame_Situacao";
        // 
        // Exame_Formula
        // 
        resources.ApplyResources(Exame_Formula, "Exame_Formula");
        Exame_Formula.Name = "Exame_Formula";
        // 
        // label6
        // 
        resources.ApplyResources(label6, "label6");
        label6.Name = "label6";
        // 
        // Exame_CampoResultado
        // 
        resources.ApplyResources(Exame_CampoResultado, "Exame_CampoResultado");
        Exame_CampoResultado.Name = "Exame_CampoResultado";
        // 
        // label_divide
        // 
        resources.ApplyResources(label_divide, "label_divide");
        label_divide.Name = "label_divide";
        // 
        // Label_MD
        // 
        resources.ApplyResources(Label_MD, "Label_MD");
        Label_MD.BackColor = Color.White;
        Label_MD.ForeColor = SystemColors.ActiveCaptionText;
        Label_MD.Name = "Label_MD";
        // 
        // Exame_BotaoCalcular
        // 
        resources.ApplyResources(Exame_BotaoCalcular, "Exame_BotaoCalcular");
        Exame_BotaoCalcular.BackColor = Color.FromArgb(0, 56, 97);
        Exame_BotaoCalcular.Cursor = Cursors.Hand;
        Exame_BotaoCalcular.DialogResult = DialogResult.TryAgain;
        Exame_BotaoCalcular.FlatAppearance.BorderColor = Color.FromArgb(255, 187, 0);
        Exame_BotaoCalcular.FlatAppearance.BorderSize = 0;
        Exame_BotaoCalcular.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 187, 0);
        Exame_BotaoCalcular.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
        Exame_BotaoCalcular.ForeColor = Color.White;
        Exame_BotaoCalcular.Name = "Exame_BotaoCalcular";
        Exame_BotaoCalcular.UseVisualStyleBackColor = false;
        Exame_BotaoCalcular.Click += CalcularExame_Click;
        // 
        // Label_Prova
        // 
        resources.ApplyResources(Label_Prova, "Label_Prova");
        Label_Prova.Name = "Label_Prova";
        // 
        // Exame_NotaExameTxt
        // 
        resources.ApplyResources(Exame_NotaExameTxt, "Exame_NotaExameTxt");
        Exame_NotaExameTxt.Name = "Exame_NotaExameTxt";
        // 
        // Label_AVA
        // 
        resources.ApplyResources(Label_AVA, "Label_AVA");
        Label_AVA.Name = "Label_AVA";
        // 
        // Exame_NotaMediaTxt
        // 
        resources.ApplyResources(Exame_NotaMediaTxt, "Exame_NotaMediaTxt");
        Exame_NotaMediaTxt.Name = "Exame_NotaMediaTxt";
        Exame_NotaMediaTxt.Tag = "";
        Exame_NotaMediaTxt.ValidatingType = typeof(int);
        // 
        // ExameTitulo
        // 
        resources.ApplyResources(ExameTitulo, "ExameTitulo");
        ExameTitulo.BackColor = Color.FromArgb(0, 64, 64);
        ExameTitulo.Controls.Add(LabelTitulo);
        ExameTitulo.Controls.Add(fechar_botao);
        ExameTitulo.Name = "ExameTitulo";
        ExameTitulo.MouseDown += ExameTitulo_MouseDown;
        // 
        // LabelTitulo
        // 
        resources.ApplyResources(LabelTitulo, "LabelTitulo");
        LabelTitulo.ForeColor = SystemColors.ButtonHighlight;
        LabelTitulo.Name = "LabelTitulo";
        // 
        // fechar_botao
        // 
        resources.ApplyResources(fechar_botao, "fechar_botao");
        fechar_botao.Cursor = Cursors.Hand;
        fechar_botao.Image = Properties.Resources.close;
        fechar_botao.Name = "fechar_botao";
        fechar_botao.TabStop = false;
        fechar_botao.Click += FecharExame_Click;
        // 
        // Exame
        // 
        resources.ApplyResources(this, "$this");
        AllowDrop = true;
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        Controls.Add(ExameTitulo);
        Controls.Add(panel1);
        Controls.Add(Exame_BotaoCalcular);
        Controls.Add(Label_Prova);
        Controls.Add(Exame_NotaExameTxt);
        Controls.Add(Label_AVA);
        Controls.Add(Exame_NotaMediaTxt);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "Exame";
        SizeGripStyle = SizeGripStyle.Show;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ExameTitulo.ResumeLayout(false);
        ExameTitulo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)fechar_botao).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Panel panel1;
    private Label Exame_Situacao;
    private Label Exame_Formula;
    private Label label6;
    private Label Exame_CampoResultado;
    private Label label_divide;
    private Label Label_MD;
    private Button Exame_BotaoCalcular;
    private Label Label_Prova;
    private MaskedTextBox Exame_NotaExameTxt;
    private Label Label_AVA;
    private MaskedTextBox Exame_NotaMediaTxt;
    private Panel ExameTitulo;
    private Label LabelTitulo;
    private PictureBox fechar_botao;
    private Label label1;
}