namespace CalculoUNIP;
partial class MediaUnip
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();

        base.Dispose(disposing);
    }
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaUnip));
        InputAVA = new MaskedTextBox();
        Label_AVA = new Label();
        Label_Prova = new Label();
        InputProva = new MaskedTextBox();
        Label_Media = new Label();
        LabelResultado = new Label();
        BotaoCalculo = new Button();
        label_divide = new Label();
        label6 = new Label();
        Label_Situacao = new Label();
        Label_Pim = new Label();
        InputPIM = new MaskedTextBox();
        Label_MD = new Label();
        LabelFormula = new Label();
        ImagemLogo = new PictureBox();
        Titulo = new Panel();
        fechar_botao = new PictureBox();
        panel1 = new Panel();
        ((System.ComponentModel.ISupportInitialize)ImagemLogo).BeginInit();
        Titulo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)fechar_botao).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // InputAVA
        // 
        resources.ApplyResources(InputAVA, "InputAVA");
        InputAVA.Name = "InputAVA";
        InputAVA.Tag = "";
        InputAVA.ValidatingType = typeof(int);
        // 
        // Label_AVA
        // 
        resources.ApplyResources(Label_AVA, "Label_AVA");
        Label_AVA.Name = "Label_AVA";
        // 
        // Label_Prova
        // 
        resources.ApplyResources(Label_Prova, "Label_Prova");
        Label_Prova.Name = "Label_Prova";
        // 
        // InputProva
        // 
        resources.ApplyResources(InputProva, "InputProva");
        InputProva.Name = "InputProva";
        // 
        // Label_Media
        // 
        resources.ApplyResources(Label_Media, "Label_Media");
        Label_Media.Name = "Label_Media";
        // 
        // LabelResultado
        // 
        resources.ApplyResources(LabelResultado, "LabelResultado");
        LabelResultado.Name = "LabelResultado";
        // 
        // BotaoCalculo
        // 
        resources.ApplyResources(BotaoCalculo, "BotaoCalculo");
        BotaoCalculo.BackColor = Color.FromArgb(255, 237, 0);
        BotaoCalculo.Cursor = Cursors.Hand;
        BotaoCalculo.FlatAppearance.BorderSize = 0;
        BotaoCalculo.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
        BotaoCalculo.ForeColor = Color.Navy;
        BotaoCalculo.Image = Properties.Resources.calc;
        BotaoCalculo.Name = "BotaoCalculo";
        BotaoCalculo.UseVisualStyleBackColor = false;
        BotaoCalculo.Click += BTN_CALCULAR_Click;
        // 
        // label_divide
        // 
        resources.ApplyResources(label_divide, "label_divide");
        label_divide.Name = "label_divide";
        // 
        // label6
        // 
        resources.ApplyResources(label6, "label6");
        label6.Name = "label6";
        // 
        // Label_Situacao
        // 
        resources.ApplyResources(Label_Situacao, "Label_Situacao");
        Label_Situacao.Name = "Label_Situacao";
        // 
        // Label_Pim
        // 
        resources.ApplyResources(Label_Pim, "Label_Pim");
        Label_Pim.Name = "Label_Pim";
        // 
        // InputPIM
        // 
        resources.ApplyResources(InputPIM, "InputPIM");
        InputPIM.Name = "InputPIM";
        // 
        // Label_MD
        // 
        resources.ApplyResources(Label_MD, "Label_MD");
        Label_MD.BackColor = Color.White;
        Label_MD.ForeColor = SystemColors.ActiveCaptionText;
        Label_MD.Name = "Label_MD";
        // 
        // LabelFormula
        // 
        resources.ApplyResources(LabelFormula, "LabelFormula");
        LabelFormula.Name = "LabelFormula";
        // 
        // ImagemLogo
        // 
        resources.ApplyResources(ImagemLogo, "ImagemLogo");
        ImagemLogo.Cursor = Cursors.Hand;
        ImagemLogo.Image = Properties.Resources.unip_logo;
        ImagemLogo.Name = "ImagemLogo";
        ImagemLogo.TabStop = false;
        ImagemLogo.Tag = "Abrir Site";
        ImagemLogo.Click += PictureBox1_Click;
        // 
        // Titulo
        // 
        resources.ApplyResources(Titulo, "Titulo");
        Titulo.BackColor = Color.FromArgb(246, 119, 4);
        Titulo.Controls.Add(fechar_botao);
        Titulo.Name = "Titulo";
        Titulo.MouseDown += Titulo_MouseDown;
        // 
        // fechar_botao
        // 
        resources.ApplyResources(fechar_botao, "fechar_botao");
        fechar_botao.Cursor = Cursors.Hand;
        fechar_botao.Image = Properties.Resources.close;
        fechar_botao.Name = "fechar_botao";
        fechar_botao.TabStop = false;
        fechar_botao.Click += Fechar_botao_Click;
        // 
        // panel1
        // 
        resources.ApplyResources(panel1, "panel1");
        panel1.Controls.Add(LabelFormula);
        panel1.Controls.Add(Label_MD);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(Label_Situacao);
        panel1.Controls.Add(label_divide);
        panel1.Name = "panel1";
        // 
        // MediaUnip
        // 
        resources.ApplyResources(this, "$this");
        AllowDrop = true;
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        Controls.Add(panel1);
        Controls.Add(Titulo);
        Controls.Add(ImagemLogo);
        Controls.Add(BotaoCalculo);
        Controls.Add(LabelResultado);
        Controls.Add(Label_Media);
        Controls.Add(Label_Pim);
        Controls.Add(Label_Prova);
        Controls.Add(InputPIM);
        Controls.Add(InputProva);
        Controls.Add(Label_AVA);
        Controls.Add(InputAVA);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        Name = "MediaUnip";
        TopMost = true;
        ((System.ComponentModel.ISupportInitialize)ImagemLogo).EndInit();
        Titulo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)fechar_botao).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private MaskedTextBox InputAVA;
    private Label Label_AVA;
    private Label Label_Prova;
    private MaskedTextBox InputProva;
    private Label Label_Media;
    private Label LabelResultado;
    private Button BotaoCalculo;
    private Label label_FORMULA;
    private Label label6;
    private Label Label_Situacao;
    private Label Label_Pim;
    private MaskedTextBox InputPIM;
    private Label Label_MD;
    private Label LabelFormula;
    private Label label_divide;
    private PictureBox ImagemLogo;
    private Panel Titulo;
    private PictureBox fechar_botao;
    private Panel panel1;
}