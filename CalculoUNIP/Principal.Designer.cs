namespace AverageTool;
partial class Principal
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
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
        LabelTitulo = new Label();
        fechar_botao = new PictureBox();
        panel1 = new Panel();
        botaoExame = new Button();
        MenuContexto = new ContextMenuStrip(components);
        toolStripMenuItem1 = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        toolStripMenuItem2 = new ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)ImagemLogo).BeginInit();
        Titulo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)fechar_botao).BeginInit();
        panel1.SuspendLayout();
        MenuContexto.SuspendLayout();
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
        BotaoCalculo.DialogResult = DialogResult.TryAgain;
        BotaoCalculo.FlatAppearance.BorderColor = Color.FromArgb(255, 187, 0);
        BotaoCalculo.FlatAppearance.BorderSize = 10;
        BotaoCalculo.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 187, 0);
        BotaoCalculo.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
        BotaoCalculo.ForeColor = Color.Black;
        BotaoCalculo.Name = "BotaoCalculo";
        BotaoCalculo.UseVisualStyleBackColor = false;
        BotaoCalculo.Click += BotaoCalcular_Click;
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
        Titulo.BackColor = Color.FromArgb(0, 64, 64);
        Titulo.Controls.Add(LabelTitulo);
        Titulo.Controls.Add(fechar_botao);
        Titulo.Name = "Titulo";
        Titulo.MouseDown += Titulo_MouseDown;
        // 
        // LabelTitulo
        // 
        resources.ApplyResources(LabelTitulo, "LabelTitulo");
        LabelTitulo.ForeColor = SystemColors.ButtonHighlight;
        LabelTitulo.Name = "LabelTitulo";
        LabelTitulo.MouseDown += Titulo_MouseDown;
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
        panel1.Controls.Add(Label_Situacao);
        panel1.Controls.Add(LabelFormula);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(LabelResultado);
        panel1.Controls.Add(label_divide);
        panel1.Controls.Add(Label_Media);
        panel1.Controls.Add(Label_MD);
        panel1.Name = "panel1";
        // 
        // botaoExame
        // 
        resources.ApplyResources(botaoExame, "botaoExame");
        botaoExame.BackColor = Color.FromArgb(214, 72, 72);
        botaoExame.Cursor = Cursors.Hand;
        botaoExame.DialogResult = DialogResult.TryAgain;
        botaoExame.FlatAppearance.BorderColor = Color.FromArgb(214, 22, 72);
        botaoExame.FlatAppearance.BorderSize = 0;
        botaoExame.FlatAppearance.MouseDownBackColor = Color.FromArgb(214, 22, 72);
        botaoExame.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 72, 102);
        botaoExame.ForeColor = Color.AliceBlue;
        botaoExame.Name = "botaoExame";
        botaoExame.UseVisualStyleBackColor = false;
        botaoExame.Click += BotaoExame_Click;
        // 
        // MenuContexto
        // 
        resources.ApplyResources(MenuContexto, "MenuContexto");
        MenuContexto.BackColor = Color.White;
        MenuContexto.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripSeparator1, toolStripMenuItem2 });
        MenuContexto.Name = "contextMenuStrip1";
        MenuContexto.RenderMode = ToolStripRenderMode.Professional;
        // 
        // toolStripMenuItem1
        // 
        resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Click += SubMenuItem1_Click;
        // 
        // toolStripSeparator1
        // 
        resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
        toolStripSeparator1.Name = "toolStripSeparator1";
        // 
        // toolStripMenuItem2
        // 
        resources.ApplyResources(toolStripMenuItem2, "toolStripMenuItem2");
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        // 
        // Principal
        // 
        AcceptButton = BotaoCalculo;
        resources.ApplyResources(this, "$this");
        AllowDrop = true;
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        Controls.Add(botaoExame);
        Controls.Add(panel1);
        Controls.Add(Titulo);
        Controls.Add(ImagemLogo);
        Controls.Add(BotaoCalculo);
        Controls.Add(Label_Pim);
        Controls.Add(Label_Prova);
        Controls.Add(InputPIM);
        Controls.Add(InputProva);
        Controls.Add(Label_AVA);
        Controls.Add(InputAVA);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "Principal";
        MouseClick += Principal_MouseClick;
        ((System.ComponentModel.ISupportInitialize)ImagemLogo).EndInit();
        Titulo.ResumeLayout(false);
        Titulo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)fechar_botao).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        MenuContexto.ResumeLayout(false);
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
    private Label LabelTitulo;
    private Button botaoExame;
    private ContextMenuStrip MenuContexto;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem toolStripMenuItem2;
}