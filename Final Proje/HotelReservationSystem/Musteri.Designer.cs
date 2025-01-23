namespace HotelReservationSystem
{
    partial class Musteri
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            oda = new Button();
            rezervasyon = new Button();
            musteriLabel = new Label();
            createCustomerGroup = new GroupBox();
            phoneNumberText = new TextBox();
            idText = new TextBox();
            surnameText = new TextBox();
            musteriOlustur = new Button();
            nameText = new TextBox();
            phoneNumberLabel = new Label();
            idLabel = new Label();
            surnameLabel = new Label();
            nameLabel = new Label();
            editCustomerGroup = new GroupBox();
            musteriDuzenle = new Button();
            editPhoneNumberText = new TextBox();
            editCustomerIDText = new TextBox();
            editSurnameText = new TextBox();
            editNameText = new TextBox();
            editPhoneNumberLabel = new Label();
            editIDLabel = new Label();
            editSurnameLabel = new Label();
            editNameLabel = new Label();
            deleteCustomerGroup = new GroupBox();
            deletedCustomerIDText = new TextBox();
            musteriSil = new Button();
            deletedCustomerIDLabel = new Label();
            label1 = new Label();
            musteriListesi = new ListView();
            getCustomerGroup = new GroupBox();
            getCustomerIDText = new TextBox();
            musteriBul = new Button();
            getCustomerIDLabel = new Label();
            label3 = new Label();
            createCustomerGroup.SuspendLayout();
            editCustomerGroup.SuspendLayout();
            deleteCustomerGroup.SuspendLayout();
            getCustomerGroup.SuspendLayout();
            SuspendLayout();
            // 
            // oda
            // 
            oda.BackColor = SystemColors.ActiveCaptionText;
            oda.ForeColor = SystemColors.ControlLightLight;
            oda.Location = new Point(1251, 12);
            oda.Name = "oda";
            oda.Size = new Size(161, 29);
            oda.TabIndex = 3;
            oda.Text = "Oda Yönetimi";
            oda.UseVisualStyleBackColor = false;
            oda.Click += oda_Click;
            // 
            // rezervasyon
            // 
            rezervasyon.BackColor = SystemColors.ActiveCaptionText;
            rezervasyon.ForeColor = SystemColors.ControlLightLight;
            rezervasyon.Location = new Point(12, 12);
            rezervasyon.Name = "rezervasyon";
            rezervasyon.Size = new Size(161, 29);
            rezervasyon.TabIndex = 4;
            rezervasyon.Text = "Rezervasyon Yönetimi";
            rezervasyon.UseVisualStyleBackColor = false;
            rezervasyon.Click += rezervasyon_Click;
            // 
            // musteriLabel
            // 
            musteriLabel.AutoSize = true;
            musteriLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            musteriLabel.Location = new Point(597, 13);
            musteriLabel.Name = "musteriLabel";
            musteriLabel.Size = new Size(247, 28);
            musteriLabel.TabIndex = 5;
            musteriLabel.Text = "Müşteri Yönetimi Sayfası";
            // 
            // createCustomerGroup
            // 
            createCustomerGroup.Controls.Add(phoneNumberText);
            createCustomerGroup.Controls.Add(idText);
            createCustomerGroup.Controls.Add(surnameText);
            createCustomerGroup.Controls.Add(musteriOlustur);
            createCustomerGroup.Controls.Add(nameText);
            createCustomerGroup.Controls.Add(phoneNumberLabel);
            createCustomerGroup.Controls.Add(idLabel);
            createCustomerGroup.Controls.Add(surnameLabel);
            createCustomerGroup.Controls.Add(nameLabel);
            createCustomerGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            createCustomerGroup.Location = new Point(12, 116);
            createCustomerGroup.Name = "createCustomerGroup";
            createCustomerGroup.Size = new Size(250, 268);
            createCustomerGroup.TabIndex = 6;
            createCustomerGroup.TabStop = false;
            createCustomerGroup.Text = "Müşteri Oluştur";
            // 
            // phoneNumberText
            // 
            phoneNumberText.Location = new Point(119, 180);
            phoneNumberText.Name = "phoneNumberText";
            phoneNumberText.Size = new Size(125, 30);
            phoneNumberText.TabIndex = 7;
            // 
            // idText
            // 
            idText.Location = new Point(119, 135);
            idText.Name = "idText";
            idText.Size = new Size(125, 30);
            idText.TabIndex = 6;
            // 
            // surnameText
            // 
            surnameText.Location = new Point(119, 90);
            surnameText.Name = "surnameText";
            surnameText.Size = new Size(125, 30);
            surnameText.TabIndex = 5;
            // 
            // musteriOlustur
            // 
            musteriOlustur.BackColor = SystemColors.ActiveCaptionText;
            musteriOlustur.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            musteriOlustur.ForeColor = Color.Transparent;
            musteriOlustur.Location = new Point(0, 224);
            musteriOlustur.Name = "musteriOlustur";
            musteriOlustur.Size = new Size(250, 44);
            musteriOlustur.TabIndex = 10;
            musteriOlustur.Text = "Müşteri Oluştur";
            musteriOlustur.UseVisualStyleBackColor = false;
            musteriOlustur.Click += musteriOlustur_Click;
            // 
            // nameText
            // 
            nameText.Location = new Point(119, 45);
            nameText.Name = "nameText";
            nameText.Size = new Size(125, 30);
            nameText.TabIndex = 4;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(22, 180);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(60, 23);
            phoneNumberLabel.TabIndex = 3;
            phoneNumberLabel.Text = "Tel No";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(22, 135);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(90, 23);
            idLabel.TabIndex = 2;
            idLabel.Text = "Kimlik No";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(22, 90);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(59, 23);
            surnameLabel.TabIndex = 1;
            surnameLabel.Text = "Soyad";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(22, 45);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(33, 23);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Ad";
            // 
            // editCustomerGroup
            // 
            editCustomerGroup.Controls.Add(musteriDuzenle);
            editCustomerGroup.Controls.Add(editPhoneNumberText);
            editCustomerGroup.Controls.Add(editCustomerIDText);
            editCustomerGroup.Controls.Add(editSurnameText);
            editCustomerGroup.Controls.Add(editNameText);
            editCustomerGroup.Controls.Add(editPhoneNumberLabel);
            editCustomerGroup.Controls.Add(editIDLabel);
            editCustomerGroup.Controls.Add(editSurnameLabel);
            editCustomerGroup.Controls.Add(editNameLabel);
            editCustomerGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            editCustomerGroup.Location = new Point(302, 116);
            editCustomerGroup.Name = "editCustomerGroup";
            editCustomerGroup.Size = new Size(250, 268);
            editCustomerGroup.TabIndex = 8;
            editCustomerGroup.TabStop = false;
            editCustomerGroup.Text = "Müşteri Düzenle";
            // 
            // musteriDuzenle
            // 
            musteriDuzenle.BackColor = SystemColors.ActiveCaptionText;
            musteriDuzenle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            musteriDuzenle.ForeColor = Color.Transparent;
            musteriDuzenle.Location = new Point(0, 224);
            musteriDuzenle.Name = "musteriDuzenle";
            musteriDuzenle.Size = new Size(250, 44);
            musteriDuzenle.TabIndex = 11;
            musteriDuzenle.Text = "Müşteri Duzenle";
            musteriDuzenle.UseVisualStyleBackColor = false;
            musteriDuzenle.Click += musteriDuzenle_Click;
            // 
            // editPhoneNumberText
            // 
            editPhoneNumberText.Location = new Point(119, 180);
            editPhoneNumberText.Name = "editPhoneNumberText";
            editPhoneNumberText.Size = new Size(125, 30);
            editPhoneNumberText.TabIndex = 7;
            // 
            // editCustomerIDText
            // 
            editCustomerIDText.Location = new Point(119, 45);
            editCustomerIDText.Name = "editCustomerIDText";
            editCustomerIDText.Size = new Size(125, 30);
            editCustomerIDText.TabIndex = 6;
            // 
            // editSurnameText
            // 
            editSurnameText.Location = new Point(119, 135);
            editSurnameText.Name = "editSurnameText";
            editSurnameText.Size = new Size(125, 30);
            editSurnameText.TabIndex = 5;
            // 
            // editNameText
            // 
            editNameText.Location = new Point(119, 90);
            editNameText.Name = "editNameText";
            editNameText.Size = new Size(125, 30);
            editNameText.TabIndex = 4;
            // 
            // editPhoneNumberLabel
            // 
            editPhoneNumberLabel.AutoSize = true;
            editPhoneNumberLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            editPhoneNumberLabel.Location = new Point(22, 180);
            editPhoneNumberLabel.Name = "editPhoneNumberLabel";
            editPhoneNumberLabel.Size = new Size(60, 23);
            editPhoneNumberLabel.TabIndex = 3;
            editPhoneNumberLabel.Text = "Tel No";
            // 
            // editIDLabel
            // 
            editIDLabel.AutoSize = true;
            editIDLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            editIDLabel.Location = new Point(22, 45);
            editIDLabel.Name = "editIDLabel";
            editIDLabel.Size = new Size(90, 23);
            editIDLabel.TabIndex = 2;
            editIDLabel.Text = "Kimlik No";
            // 
            // editSurnameLabel
            // 
            editSurnameLabel.AutoSize = true;
            editSurnameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            editSurnameLabel.Location = new Point(22, 135);
            editSurnameLabel.Name = "editSurnameLabel";
            editSurnameLabel.Size = new Size(59, 23);
            editSurnameLabel.TabIndex = 1;
            editSurnameLabel.Text = "Soyad";
            // 
            // editNameLabel
            // 
            editNameLabel.AutoSize = true;
            editNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            editNameLabel.Location = new Point(22, 90);
            editNameLabel.Name = "editNameLabel";
            editNameLabel.Size = new Size(33, 23);
            editNameLabel.TabIndex = 0;
            editNameLabel.Text = "Ad";
            // 
            // deleteCustomerGroup
            // 
            deleteCustomerGroup.Controls.Add(deletedCustomerIDText);
            deleteCustomerGroup.Controls.Add(musteriSil);
            deleteCustomerGroup.Controls.Add(deletedCustomerIDLabel);
            deleteCustomerGroup.Controls.Add(label1);
            deleteCustomerGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            deleteCustomerGroup.Location = new Point(592, 116);
            deleteCustomerGroup.Name = "deleteCustomerGroup";
            deleteCustomerGroup.Size = new Size(250, 117);
            deleteCustomerGroup.TabIndex = 12;
            deleteCustomerGroup.TabStop = false;
            deleteCustomerGroup.Text = "Müşteri Sil";
            // 
            // deletedCustomerIDText
            // 
            deletedCustomerIDText.Location = new Point(119, 45);
            deletedCustomerIDText.Name = "deletedCustomerIDText";
            deletedCustomerIDText.Size = new Size(125, 30);
            deletedCustomerIDText.TabIndex = 8;
            // 
            // musteriSil
            // 
            musteriSil.BackColor = SystemColors.ActiveCaptionText;
            musteriSil.ForeColor = Color.Transparent;
            musteriSil.Location = new Point(0, 81);
            musteriSil.Name = "musteriSil";
            musteriSil.Size = new Size(250, 36);
            musteriSil.TabIndex = 13;
            musteriSil.Text = "Müşteri Sil";
            musteriSil.UseVisualStyleBackColor = false;
            musteriSil.Click += musteriSil_Click;
            // 
            // deletedCustomerIDLabel
            // 
            deletedCustomerIDLabel.AutoSize = true;
            deletedCustomerIDLabel.Location = new Point(22, 45);
            deletedCustomerIDLabel.Name = "deletedCustomerIDLabel";
            deletedCustomerIDLabel.Size = new Size(90, 23);
            deletedCustomerIDLabel.TabIndex = 8;
            deletedCustomerIDLabel.Text = "Kimlik No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 8;
            // 
            // musteriListesi
            // 
            musteriListesi.GridLines = true;
            musteriListesi.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            musteriListesi.Location = new Point(882, 116);
            musteriListesi.MultiSelect = false;
            musteriListesi.Name = "musteriListesi";
            musteriListesi.Size = new Size(520, 268);
            musteriListesi.TabIndex = 14;
            musteriListesi.UseCompatibleStateImageBehavior = false;
            musteriListesi.View = View.Details;
            musteriListesi.SelectedIndexChanged += musteriListesi_SelectedIndexChanged;
            // 
            // getCustomerGroup
            // 
            getCustomerGroup.Controls.Add(getCustomerIDText);
            getCustomerGroup.Controls.Add(musteriBul);
            getCustomerGroup.Controls.Add(getCustomerIDLabel);
            getCustomerGroup.Controls.Add(label3);
            getCustomerGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            getCustomerGroup.Location = new Point(592, 267);
            getCustomerGroup.Name = "getCustomerGroup";
            getCustomerGroup.Size = new Size(250, 117);
            getCustomerGroup.TabIndex = 14;
            getCustomerGroup.TabStop = false;
            getCustomerGroup.Text = "Müşteri Bul";
            // 
            // getCustomerIDText
            // 
            getCustomerIDText.Location = new Point(119, 45);
            getCustomerIDText.Name = "getCustomerIDText";
            getCustomerIDText.Size = new Size(125, 30);
            getCustomerIDText.TabIndex = 8;
            // 
            // musteriBul
            // 
            musteriBul.BackColor = SystemColors.ActiveCaptionText;
            musteriBul.ForeColor = Color.Transparent;
            musteriBul.Location = new Point(0, 81);
            musteriBul.Name = "musteriBul";
            musteriBul.Size = new Size(250, 36);
            musteriBul.TabIndex = 13;
            musteriBul.Text = "Müşteriyi Bul";
            musteriBul.UseVisualStyleBackColor = false;
            musteriBul.Click += musteriBul_Click;
            // 
            // getCustomerIDLabel
            // 
            getCustomerIDLabel.AutoSize = true;
            getCustomerIDLabel.Location = new Point(22, 45);
            getCustomerIDLabel.Name = "getCustomerIDLabel";
            getCustomerIDLabel.Size = new Size(90, 23);
            getCustomerIDLabel.TabIndex = 8;
            getCustomerIDLabel.Text = "Kimlik No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 48);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 8;
            // 
            // Musteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1424, 453);
            Controls.Add(getCustomerGroup);
            Controls.Add(musteriListesi);
            Controls.Add(deleteCustomerGroup);
            Controls.Add(editCustomerGroup);
            Controls.Add(createCustomerGroup);
            Controls.Add(musteriLabel);
            Controls.Add(rezervasyon);
            Controls.Add(oda);
            Name = "Musteri";
            Text = "Musteri";
            Load += Musteri_Load;
            createCustomerGroup.ResumeLayout(false);
            createCustomerGroup.PerformLayout();
            editCustomerGroup.ResumeLayout(false);
            editCustomerGroup.PerformLayout();
            deleteCustomerGroup.ResumeLayout(false);
            deleteCustomerGroup.PerformLayout();
            getCustomerGroup.ResumeLayout(false);
            getCustomerGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button oda;
        private Button rezervasyon;
        private Label musteriLabel;
        private GroupBox createCustomerGroup;
        private TextBox phoneNumberText;
        private TextBox idText;
        private TextBox surnameText;
        private TextBox nameText;
        private Label phoneNumberLabel;
        private Label idLabel;
        private Label surnameLabel;
        private Label nameLabel;
        private GroupBox editCustomerGroup;
        private TextBox editPhoneNumberText;
        private TextBox editCustomerIDText;
        private TextBox editSurnameText;
        private TextBox editNameText;
        private Label editPhoneNumberLabel;
        private Label editIDLabel;
        private Label editSurnameLabel;
        private Label editNameLabel;
        private Button musteriOlustur;
        private GroupBox deleteCustomerGroup;
        private TextBox deletedCustomerIDText;
        private Label deletedCustomerIDLabel;
        private Label label1;
        private Button musteriSil;
        private ListView musteriListesi;
        private GroupBox getCustomerGroup;
        private TextBox getCustomerIDText;
        private Button musteriBul;
        private Label getCustomerIDLabel;
        private Label label3;
        private Button musteriDuzenle;
    }
}