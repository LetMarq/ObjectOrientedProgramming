namespace wfAnimation
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btRead_A = new System.Windows.Forms.Button();
            this.dgvAnimation = new System.Windows.Forms.DataGridView();
            this.tbGenreID = new System.Windows.Forms.TextBox();
            this.tbEpNum = new System.Windows.Forms.TextBox();
            this.tbAuthorID = new System.Windows.Forms.TextBox();
            this.btInsert_A = new System.Windows.Forms.Button();
            this.btUpdate_A = new System.Windows.Forms.Button();
            this.btDelete_A = new System.Windows.Forms.Button();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.tbStudID = new System.Windows.Forms.TextBox();
            this.tbReleaseDate = new System.Windows.Forms.TextBox();
            this.tbAnimName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btRead_Aut = new System.Windows.Forms.Button();
            this.btUpdate_Aut = new System.Windows.Forms.Button();
            this.tbAuthorFN = new System.Windows.Forms.TextBox();
            this.btDelet_Aut = new System.Windows.Forms.Button();
            this.btInsert_Aut = new System.Windows.Forms.Button();
            this.tbAuthorLN = new System.Windows.Forms.TextBox();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btRead_G = new System.Windows.Forms.Button();
            this.tbGenreName = new System.Windows.Forms.TextBox();
            this.btDelete_G = new System.Windows.Forms.Button();
            this.btInsert_G = new System.Windows.Forms.Button();
            this.btUpdate_G = new System.Windows.Forms.Button();
            this.dgvGenre = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btRead_S = new System.Windows.Forms.Button();
            this.tbStudioName = new System.Windows.Forms.TextBox();
            this.btDelete_S = new System.Windows.Forms.Button();
            this.btInsert_S = new System.Windows.Forms.Button();
            this.btUpdate_S = new System.Windows.Forms.Button();
            this.dgvStudio = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimation)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudio)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 348);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.btRead_A);
            this.tabPage1.Controls.Add(this.dgvAnimation);
            this.tabPage1.Controls.Add(this.tbGenreID);
            this.tabPage1.Controls.Add(this.tbEpNum);
            this.tabPage1.Controls.Add(this.tbAuthorID);
            this.tabPage1.Controls.Add(this.btInsert_A);
            this.tabPage1.Controls.Add(this.btUpdate_A);
            this.tabPage1.Controls.Add(this.btDelete_A);
            this.tabPage1.Controls.Add(this.tbScore);
            this.tabPage1.Controls.Add(this.tbStudID);
            this.tabPage1.Controls.Add(this.tbReleaseDate);
            this.tabPage1.Controls.Add(this.tbAnimName);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Animation";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btRead_A
            // 
            this.btRead_A.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btRead_A.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRead_A.Location = new System.Drawing.Point(563, 251);
            this.btRead_A.Name = "btRead_A";
            this.btRead_A.Size = new System.Drawing.Size(144, 52);
            this.btRead_A.TabIndex = 39;
            this.btRead_A.Text = "READ";
            this.btRead_A.UseVisualStyleBackColor = false;
            this.btRead_A.Click += new System.EventHandler(this.btRead_A_Click);
            // 
            // dgvAnimation
            // 
            this.dgvAnimation.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAnimation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimation.Location = new System.Drawing.Point(15, 6);
            this.dgvAnimation.Name = "dgvAnimation";
            this.dgvAnimation.Size = new System.Drawing.Size(692, 150);
            this.dgvAnimation.TabIndex = 38;
            this.dgvAnimation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimation_CellContentClick);
            // 
            // tbGenreID
            // 
            this.tbGenreID.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbGenreID.ForeColor = System.Drawing.SystemColors.Info;
            this.tbGenreID.Location = new System.Drawing.Point(479, 188);
            this.tbGenreID.Name = "tbGenreID";
            this.tbGenreID.Size = new System.Drawing.Size(100, 20);
            this.tbGenreID.TabIndex = 37;
            this.tbGenreID.Text = "Genre ID";
            this.tbGenreID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGenreID.TextChanged += new System.EventHandler(this.tbGenreID_TextChanged);
            // 
            // tbEpNum
            // 
            this.tbEpNum.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbEpNum.ForeColor = System.Drawing.SystemColors.Info;
            this.tbEpNum.Location = new System.Drawing.Point(241, 188);
            this.tbEpNum.Name = "tbEpNum";
            this.tbEpNum.Size = new System.Drawing.Size(103, 20);
            this.tbEpNum.TabIndex = 36;
            this.tbEpNum.Text = "Episodes Number";
            this.tbEpNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAuthorID
            // 
            this.tbAuthorID.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbAuthorID.ForeColor = System.Drawing.SystemColors.Info;
            this.tbAuthorID.Location = new System.Drawing.Point(356, 188);
            this.tbAuthorID.Name = "tbAuthorID";
            this.tbAuthorID.Size = new System.Drawing.Size(107, 20);
            this.tbAuthorID.TabIndex = 35;
            this.tbAuthorID.Text = "Author ID";
            this.tbAuthorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btInsert_A
            // 
            this.btInsert_A.BackColor = System.Drawing.Color.Chartreuse;
            this.btInsert_A.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btInsert_A.Location = new System.Drawing.Point(15, 251);
            this.btInsert_A.Name = "btInsert_A";
            this.btInsert_A.Size = new System.Drawing.Size(144, 52);
            this.btInsert_A.TabIndex = 34;
            this.btInsert_A.Text = "INSERT";
            this.btInsert_A.UseVisualStyleBackColor = false;
            this.btInsert_A.Click += new System.EventHandler(this.btInsert_A_Click);
            // 
            // btUpdate_A
            // 
            this.btUpdate_A.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btUpdate_A.Location = new System.Drawing.Point(200, 251);
            this.btUpdate_A.Name = "btUpdate_A";
            this.btUpdate_A.Size = new System.Drawing.Size(144, 52);
            this.btUpdate_A.TabIndex = 33;
            this.btUpdate_A.Text = "UPDATE";
            this.btUpdate_A.UseVisualStyleBackColor = false;
            this.btUpdate_A.Click += new System.EventHandler(this.btUpdate_A_Click);
            // 
            // btDelete_A
            // 
            this.btDelete_A.BackColor = System.Drawing.Color.Red;
            this.btDelete_A.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btDelete_A.Location = new System.Drawing.Point(383, 251);
            this.btDelete_A.Name = "btDelete_A";
            this.btDelete_A.Size = new System.Drawing.Size(144, 52);
            this.btDelete_A.TabIndex = 32;
            this.btDelete_A.Text = "DELETE";
            this.btDelete_A.UseVisualStyleBackColor = false;
            this.btDelete_A.Click += new System.EventHandler(this.btDelete_A_Click);
            // 
            // tbScore
            // 
            this.tbScore.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbScore.ForeColor = System.Drawing.SystemColors.Info;
            this.tbScore.Location = new System.Drawing.Point(15, 162);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(82, 20);
            this.tbScore.TabIndex = 7;
            this.tbScore.Text = "Score";
            this.tbScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbScore.TextChanged += new System.EventHandler(this.tbScore_TextChanged);
            // 
            // tbStudID
            // 
            this.tbStudID.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbStudID.ForeColor = System.Drawing.SystemColors.Info;
            this.tbStudID.Location = new System.Drawing.Point(598, 188);
            this.tbStudID.Name = "tbStudID";
            this.tbStudID.Size = new System.Drawing.Size(109, 20);
            this.tbStudID.TabIndex = 6;
            this.tbStudID.Text = "Studio ID";
            this.tbStudID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStudID.TextChanged += new System.EventHandler(this.tbStudID_TextChanged);
            // 
            // tbReleaseDate
            // 
            this.tbReleaseDate.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbReleaseDate.ForeColor = System.Drawing.SystemColors.Info;
            this.tbReleaseDate.Location = new System.Drawing.Point(116, 188);
            this.tbReleaseDate.Name = "tbReleaseDate";
            this.tbReleaseDate.Size = new System.Drawing.Size(107, 20);
            this.tbReleaseDate.TabIndex = 5;
            this.tbReleaseDate.Text = "Release Date";
            this.tbReleaseDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbReleaseDate.TextChanged += new System.EventHandler(this.tbReleaseDate_TextChanged);
            // 
            // tbAnimName
            // 
            this.tbAnimName.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbAnimName.ForeColor = System.Drawing.SystemColors.Info;
            this.tbAnimName.Location = new System.Drawing.Point(116, 162);
            this.tbAnimName.Name = "tbAnimName";
            this.tbAnimName.Size = new System.Drawing.Size(591, 20);
            this.tbAnimName.TabIndex = 2;
            this.tbAnimName.Text = "Animation Name";
            this.tbAnimName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnimName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btRead_Aut);
            this.tabPage2.Controls.Add(this.btUpdate_Aut);
            this.tabPage2.Controls.Add(this.tbAuthorFN);
            this.tabPage2.Controls.Add(this.btDelet_Aut);
            this.tabPage2.Controls.Add(this.btInsert_Aut);
            this.tabPage2.Controls.Add(this.tbAuthorLN);
            this.tabPage2.Controls.Add(this.dgvAuthor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Author";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btRead_Aut
            // 
            this.btRead_Aut.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btRead_Aut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRead_Aut.Location = new System.Drawing.Point(556, 248);
            this.btRead_Aut.Name = "btRead_Aut";
            this.btRead_Aut.Size = new System.Drawing.Size(144, 52);
            this.btRead_Aut.TabIndex = 40;
            this.btRead_Aut.Text = "READ";
            this.btRead_Aut.UseVisualStyleBackColor = false;
            this.btRead_Aut.Click += new System.EventHandler(this.btRead_Aut_Click);
            // 
            // btUpdate_Aut
            // 
            this.btUpdate_Aut.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btUpdate_Aut.Location = new System.Drawing.Point(200, 248);
            this.btUpdate_Aut.Name = "btUpdate_Aut";
            this.btUpdate_Aut.Size = new System.Drawing.Size(144, 52);
            this.btUpdate_Aut.TabIndex = 33;
            this.btUpdate_Aut.Text = "UPDATE";
            this.btUpdate_Aut.UseVisualStyleBackColor = false;
            this.btUpdate_Aut.Click += new System.EventHandler(this.btUpdate_Aut_Click);
            // 
            // tbAuthorFN
            // 
            this.tbAuthorFN.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbAuthorFN.ForeColor = System.Drawing.SystemColors.Info;
            this.tbAuthorFN.Location = new System.Drawing.Point(20, 163);
            this.tbAuthorFN.Name = "tbAuthorFN";
            this.tbAuthorFN.Size = new System.Drawing.Size(680, 20);
            this.tbAuthorFN.TabIndex = 32;
            this.tbAuthorFN.Text = "Author First Name";
            this.tbAuthorFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAuthorFN.TextChanged += new System.EventHandler(this.tbAuthorFN_TextChanged);
            // 
            // btDelet_Aut
            // 
            this.btDelet_Aut.BackColor = System.Drawing.Color.Red;
            this.btDelet_Aut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btDelet_Aut.Location = new System.Drawing.Point(383, 248);
            this.btDelet_Aut.Name = "btDelet_Aut";
            this.btDelet_Aut.Size = new System.Drawing.Size(144, 52);
            this.btDelet_Aut.TabIndex = 31;
            this.btDelet_Aut.Text = "DELETE";
            this.btDelet_Aut.UseVisualStyleBackColor = false;
            this.btDelet_Aut.Click += new System.EventHandler(this.btDelet_Aut_Click);
            // 
            // btInsert_Aut
            // 
            this.btInsert_Aut.BackColor = System.Drawing.Color.Chartreuse;
            this.btInsert_Aut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btInsert_Aut.Location = new System.Drawing.Point(20, 248);
            this.btInsert_Aut.Name = "btInsert_Aut";
            this.btInsert_Aut.Size = new System.Drawing.Size(144, 52);
            this.btInsert_Aut.TabIndex = 30;
            this.btInsert_Aut.Text = "INSERT";
            this.btInsert_Aut.UseVisualStyleBackColor = false;
            this.btInsert_Aut.Click += new System.EventHandler(this.btInsert_Aut_Click);
            // 
            // tbAuthorLN
            // 
            this.tbAuthorLN.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbAuthorLN.ForeColor = System.Drawing.SystemColors.Info;
            this.tbAuthorLN.Location = new System.Drawing.Point(20, 189);
            this.tbAuthorLN.Name = "tbAuthorLN";
            this.tbAuthorLN.Size = new System.Drawing.Size(680, 20);
            this.tbAuthorLN.TabIndex = 21;
            this.tbAuthorLN.Text = "Author Last Name";
            this.tbAuthorLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAuthorLN.TextChanged += new System.EventHandler(this.tbAuthorLN_TextChanged);
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Location = new System.Drawing.Point(20, 6);
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.Size = new System.Drawing.Size(680, 150);
            this.dgvAuthor.TabIndex = 0;
            this.dgvAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthor_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.btRead_G);
            this.tabPage3.Controls.Add(this.tbGenreName);
            this.tabPage3.Controls.Add(this.btDelete_G);
            this.tabPage3.Controls.Add(this.btInsert_G);
            this.tabPage3.Controls.Add(this.btUpdate_G);
            this.tabPage3.Controls.Add(this.dgvGenre);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(721, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Genre";
            // 
            // btRead_G
            // 
            this.btRead_G.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btRead_G.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRead_G.Location = new System.Drawing.Point(555, 248);
            this.btRead_G.Name = "btRead_G";
            this.btRead_G.Size = new System.Drawing.Size(144, 52);
            this.btRead_G.TabIndex = 40;
            this.btRead_G.Text = "READ";
            this.btRead_G.UseVisualStyleBackColor = false;
            this.btRead_G.Click += new System.EventHandler(this.btRead_G_Click);
            // 
            // tbGenreName
            // 
            this.tbGenreName.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbGenreName.ForeColor = System.Drawing.SystemColors.Window;
            this.tbGenreName.Location = new System.Drawing.Point(16, 162);
            this.tbGenreName.Name = "tbGenreName";
            this.tbGenreName.Size = new System.Drawing.Size(683, 20);
            this.tbGenreName.TabIndex = 32;
            this.tbGenreName.Text = "Genre Name";
            this.tbGenreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGenreName.TextChanged += new System.EventHandler(this.tbGenreName_TextChanged);
            // 
            // btDelete_G
            // 
            this.btDelete_G.BackColor = System.Drawing.Color.Red;
            this.btDelete_G.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btDelete_G.Location = new System.Drawing.Point(375, 248);
            this.btDelete_G.Name = "btDelete_G";
            this.btDelete_G.Size = new System.Drawing.Size(144, 52);
            this.btDelete_G.TabIndex = 31;
            this.btDelete_G.Text = "DELETE";
            this.btDelete_G.UseVisualStyleBackColor = false;
            this.btDelete_G.Click += new System.EventHandler(this.btDelete_G_Click);
            // 
            // btInsert_G
            // 
            this.btInsert_G.BackColor = System.Drawing.Color.Chartreuse;
            this.btInsert_G.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btInsert_G.Location = new System.Drawing.Point(16, 248);
            this.btInsert_G.Name = "btInsert_G";
            this.btInsert_G.Size = new System.Drawing.Size(144, 52);
            this.btInsert_G.TabIndex = 30;
            this.btInsert_G.Text = "INSERT";
            this.btInsert_G.UseVisualStyleBackColor = false;
            this.btInsert_G.Click += new System.EventHandler(this.btInsert_G_Click);
            // 
            // btUpdate_G
            // 
            this.btUpdate_G.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btUpdate_G.Location = new System.Drawing.Point(197, 248);
            this.btUpdate_G.Name = "btUpdate_G";
            this.btUpdate_G.Size = new System.Drawing.Size(144, 52);
            this.btUpdate_G.TabIndex = 29;
            this.btUpdate_G.Text = "UPDATE";
            this.btUpdate_G.UseVisualStyleBackColor = false;
            this.btUpdate_G.Click += new System.EventHandler(this.btUpdate_G_Click);
            // 
            // dgvGenre
            // 
            this.dgvGenre.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenre.Location = new System.Drawing.Point(16, 6);
            this.dgvGenre.Name = "dgvGenre";
            this.dgvGenre.Size = new System.Drawing.Size(683, 150);
            this.dgvGenre.TabIndex = 0;
            this.dgvGenre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenre_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.btRead_S);
            this.tabPage4.Controls.Add(this.tbStudioName);
            this.tabPage4.Controls.Add(this.btDelete_S);
            this.tabPage4.Controls.Add(this.btInsert_S);
            this.tabPage4.Controls.Add(this.btUpdate_S);
            this.tabPage4.Controls.Add(this.dgvStudio);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(721, 322);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Studio";
            // 
            // btRead_S
            // 
            this.btRead_S.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btRead_S.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRead_S.Location = new System.Drawing.Point(552, 248);
            this.btRead_S.Name = "btRead_S";
            this.btRead_S.Size = new System.Drawing.Size(144, 52);
            this.btRead_S.TabIndex = 40;
            this.btRead_S.Text = "READ";
            this.btRead_S.UseVisualStyleBackColor = false;
            this.btRead_S.Click += new System.EventHandler(this.btRead_S_Click);
            // 
            // tbStudioName
            // 
            this.tbStudioName.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbStudioName.ForeColor = System.Drawing.SystemColors.Window;
            this.tbStudioName.Location = new System.Drawing.Point(20, 162);
            this.tbStudioName.Name = "tbStudioName";
            this.tbStudioName.Size = new System.Drawing.Size(676, 20);
            this.tbStudioName.TabIndex = 33;
            this.tbStudioName.Text = "Studio Name";
            this.tbStudioName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStudioName.TextChanged += new System.EventHandler(this.tbStudioName_TextChanged);
            // 
            // btDelete_S
            // 
            this.btDelete_S.BackColor = System.Drawing.Color.Red;
            this.btDelete_S.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btDelete_S.Location = new System.Drawing.Point(377, 248);
            this.btDelete_S.Name = "btDelete_S";
            this.btDelete_S.Size = new System.Drawing.Size(144, 52);
            this.btDelete_S.TabIndex = 31;
            this.btDelete_S.Text = "DELETE";
            this.btDelete_S.UseVisualStyleBackColor = false;
            this.btDelete_S.Click += new System.EventHandler(this.btDelete_S_Click);
            // 
            // btInsert_S
            // 
            this.btInsert_S.BackColor = System.Drawing.Color.Chartreuse;
            this.btInsert_S.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btInsert_S.Location = new System.Drawing.Point(20, 248);
            this.btInsert_S.Name = "btInsert_S";
            this.btInsert_S.Size = new System.Drawing.Size(144, 52);
            this.btInsert_S.TabIndex = 30;
            this.btInsert_S.Text = "INSERT";
            this.btInsert_S.UseVisualStyleBackColor = false;
            this.btInsert_S.Click += new System.EventHandler(this.btInsert_S_Click);
            // 
            // btUpdate_S
            // 
            this.btUpdate_S.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btUpdate_S.Location = new System.Drawing.Point(198, 248);
            this.btUpdate_S.Name = "btUpdate_S";
            this.btUpdate_S.Size = new System.Drawing.Size(144, 52);
            this.btUpdate_S.TabIndex = 29;
            this.btUpdate_S.Text = "UPDATE";
            this.btUpdate_S.UseVisualStyleBackColor = false;
            this.btUpdate_S.Click += new System.EventHandler(this.btUpdate_S_Click);
            // 
            // dgvStudio
            // 
            this.dgvStudio.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvStudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudio.Location = new System.Drawing.Point(20, 6);
            this.dgvStudio.Name = "dgvStudio";
            this.dgvStudio.Size = new System.Drawing.Size(676, 150);
            this.dgvStudio.TabIndex = 0;
            this.dgvStudio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudio_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(737, 354);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimation)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbAnimName;
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.DataGridView dgvGenre;
        private System.Windows.Forms.DataGridView dgvStudio;
        private System.Windows.Forms.TextBox tbReleaseDate;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.TextBox tbStudID;
        private System.Windows.Forms.TextBox tbAuthorLN;
        private System.Windows.Forms.Button btDelet_Aut;
        private System.Windows.Forms.Button btInsert_Aut;
        private System.Windows.Forms.Button btDelete_G;
        private System.Windows.Forms.Button btInsert_G;
        private System.Windows.Forms.Button btUpdate_G;
        private System.Windows.Forms.Button btDelete_S;
        private System.Windows.Forms.Button btInsert_S;
        private System.Windows.Forms.Button btUpdate_S;
        private System.Windows.Forms.Button btDelete_A;
        private System.Windows.Forms.TextBox tbAuthorID;
        private System.Windows.Forms.Button btInsert_A;
        private System.Windows.Forms.Button btUpdate_A;
        private System.Windows.Forms.TextBox tbEpNum;
        private System.Windows.Forms.TextBox tbGenreID;
        private System.Windows.Forms.DataGridView dgvAnimation;
        private System.Windows.Forms.TextBox tbAuthorFN;
        private System.Windows.Forms.Button btUpdate_Aut;
        private System.Windows.Forms.TextBox tbGenreName;
        private System.Windows.Forms.TextBox tbStudioName;
        private System.Windows.Forms.Button btRead_A;
        private System.Windows.Forms.Button btRead_Aut;
        private System.Windows.Forms.Button btRead_G;
        private System.Windows.Forms.Button btRead_S;
    }
}

