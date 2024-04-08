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
        MSK_AVA = new MaskedTextBox();
        Label_AVA = new Label();
        Label_Prova = new Label();
        MSK_PROVA = new MaskedTextBox();
        Label_Media = new Label();
        LB_RESULT = new Label();
        BTN_CALCULAR = new Button();
        label_divide = new Label();
        label6 = new Label();
        Label_Situacao = new Label();
        Label_Pim = new Label();
        MSK_PIM = new MaskedTextBox();
        Label_MD = new Label();
        label1_conta = new Label();
        pictureBox1 = new PictureBox();
        Titulo = new Panel();
        fechar_botao = new PictureBox();
        panel1 = new Panel();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        Titulo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)fechar_botao).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // MSK_AVA
        // 
        resources.ApplyResources(MSK_AVA, "MSK_AVA");
        MSK_AVA.Name = "MSK_AVA";
        MSK_AVA.ValidatingType = typeof(int);
        // 
        // LB_AVA
        // 
        resources.ApplyResources(Label_AVA, "LB_AVA");
        Label_AVA.Name = "LB_AVA";
        // 
        // LB_PROVA
        // 
        resources.ApplyResources(Label_Prova, "LB_PROVA");
        Label_Prova.Name = "LB_PROVA";
        // 
        // MSK_PROVA
        // 
        resources.ApplyResources(MSK_PROVA, "MSK_PROVA");
        MSK_PROVA.Name = "MSK_PROVA";
        // 
        // LB_MEDIA
        // 
        resources.ApplyResources(Label_Media, "LB_MEDIA");
        Label_Media.Name = "LB_MEDIA";
        // 
        // LB_RESULT
        // 
        resources.ApplyResources(LB_RESULT, "LB_RESULT");
        LB_RESULT.Name = "LB_RESULT";
        // 
        // BTN_CALCULAR
        // 
        resources.ApplyResources(BTN_CALCULAR, "BTN_CALCULAR");
        BTN_CALCULAR.BackColor = Color.FromArgb(255, 237, 0);
        BTN_CALCULAR.Cursor = Cursors.Hand;
        BTN_CALCULAR.FlatAppearance.BorderSize = 0;
        BTN_CALCULAR.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
        BTN_CALCULAR.ForeColor = Color.Navy;
        BTN_CALCULAR.Image = Properties.Resources.calc;
        BTN_CALCULAR.Name = "BTN_CALCULAR";
        BTN_CALCULAR.UseVisualStyleBackColor = false;
        BTN_CALCULAR.Click += BTN_CALCULAR_Click;
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
        // label_Situacao
        // 
        resources.ApplyResources(Label_Situacao, "label_Situacao");
        Label_Situacao.Name = "label_Situacao";
        // 
        // LB_PIM
        // 
        resources.ApplyResources(Label_Pim, "LB_PIM");
        Label_Pim.Name = "LB_PIM";
        // 
        // MSK_PIM
        // 
        resources.ApplyResources(MSK_PIM, "MSK_PIM");
        MSK_PIM.Name = "MSK_PIM";
        // 
        // LB_MD
        // 
        resources.ApplyResources(Label_MD, "LB_MD");
        Label_MD.BackColor = Color.White;
        Label_MD.ForeColor = SystemColors.ActiveCaptionText;
        Label_MD.Name = "LB_MD";
        // 
        // label1_conta
        // 
        resources.ApplyResources(label1_conta, "label1_conta");
        label1_conta.Name = "label1_conta";
        // 
        // pictureBox1
        // 
        resources.ApplyResources(pictureBox1, "pictureBox1");
        pictureBox1.Cursor = Cursors.Hand;
        pictureBox1.Image = Properties.Resources.unip_logo;
        pictureBox1.Name = "pictureBox1";
        pictureBox1.TabStop = false;
        pictureBox1.Tag = "Abrir Site";
        pictureBox1.Click += pictureBox1_Click;
        // 
        // Titulo
        // 
        resources.ApplyResources(Titulo, "Titulo");
        Titulo.BackColor = Color.FromArgb(255, 237, 0);
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
        panel1.Controls.Add(label1_conta);
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
        Controls.Add(pictureBox1);
        Controls.Add(BTN_CALCULAR);
        Controls.Add(LB_RESULT);
        Controls.Add(Label_Media);
        Controls.Add(Label_Pim);
        Controls.Add(Label_Prova);
        Controls.Add(MSK_PIM);
        Controls.Add(MSK_PROVA);
        Controls.Add(Label_AVA);
        Controls.Add(MSK_AVA);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        Name = "MediaUnip";
        TopMost = true;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        Titulo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)fechar_botao).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private MaskedTextBox MSK_AVA;
    private Label Label_AVA;
    private Label Label_Prova;
    private MaskedTextBox MSK_PROVA;
    private Label Label_Media;
    private Label LB_RESULT;
    private Button BTN_CALCULAR;
    private Label label_FORMULA;
    private Label label6;
    private Label Label_Situacao;
    private Label Label_Pim;
    private MaskedTextBox MSK_PIM;
    private Label Label_MD;
    private Label label1_conta;
    private Label label_divide;
    private PictureBox pictureBox1;
    private Panel Titulo;
    private PictureBox fechar_botao;
    private Panel panel1;
}