namespace HotelReservationSystem
{
    partial class Oda
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
            musteri = new Button();
            rezervasyon = new Button();
            roomPageLabel = new Label();
            odaListesi = new ListView();
            createRoomGroup = new GroupBox();
            priceText = new TextBox();
            roomTypeText = new TextBox();
            odaOlustur = new Button();
            priceLabel = new Label();
            roomTypeLabel = new Label();
            odaDuzenle = new Button();
            odaSIl = new Button();
            editRoomGroup = new GroupBox();
            roomIDText = new TextBox();
            roomIDLabel = new Label();
            editPriceText = new TextBox();
            editRoomTypeText = new TextBox();
            editPriceLabel = new Label();
            editRoomTypeLabel = new Label();
            deleteRoomGroup = new GroupBox();
            deletedRoomIDText = new TextBox();
            deletedRoomIDLabel = new Label();
            enrtyExitGroup = new GroupBox();
            cikisYap = new Button();
            entryExitRoomIDText = new TextBox();
            entryExitRoomIDLabel = new Label();
            girisYap = new Button();
            createRoomGroup.SuspendLayout();
            editRoomGroup.SuspendLayout();
            deleteRoomGroup.SuspendLayout();
            enrtyExitGroup.SuspendLayout();
            SuspendLayout();
            // 
            // musteri
            // 
            musteri.BackColor = SystemColors.ActiveCaptionText;
            musteri.ForeColor = SystemColors.ControlLightLight;
            musteri.Location = new Point(1251, 12);
            musteri.Name = "musteri";
            musteri.Size = new Size(161, 29);
            musteri.TabIndex = 4;
            musteri.Text = "Müşteri Yönetimi";
            musteri.UseVisualStyleBackColor = false;
            musteri.Click += musteri_Click;
            // 
            // rezervasyon
            // 
            rezervasyon.BackColor = SystemColors.ActiveCaptionText;
            rezervasyon.ForeColor = SystemColors.ControlLightLight;
            rezervasyon.Location = new Point(12, 12);
            rezervasyon.Name = "rezervasyon";
            rezervasyon.Size = new Size(161, 29);
            rezervasyon.TabIndex = 5;
            rezervasyon.Text = "Rezervasyon Yönetimi";
            rezervasyon.UseVisualStyleBackColor = false;
            rezervasyon.Click += rezervasyon_Click;
            // 
            // roomPageLabel
            // 
            roomPageLabel.AutoSize = true;
            roomPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            roomPageLabel.Location = new Point(615, 13);
            roomPageLabel.Name = "roomPageLabel";
            roomPageLabel.Size = new Size(212, 28);
            roomPageLabel.TabIndex = 6;
            roomPageLabel.Text = "Oda Yönetimi Sayfası";
            // 
            // odaListesi
            // 
            odaListesi.GridLines = true;
            odaListesi.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            odaListesi.Location = new Point(882, 116);
            odaListesi.MultiSelect = false;
            odaListesi.Name = "odaListesi";
            odaListesi.Size = new Size(520, 271);
            odaListesi.TabIndex = 7;
            odaListesi.UseCompatibleStateImageBehavior = false;
            odaListesi.View = View.Details;
            // 
            // createRoomGroup
            // 
            createRoomGroup.Controls.Add(priceText);
            createRoomGroup.Controls.Add(roomTypeText);
            createRoomGroup.Controls.Add(odaOlustur);
            createRoomGroup.Controls.Add(priceLabel);
            createRoomGroup.Controls.Add(roomTypeLabel);
            createRoomGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            createRoomGroup.Location = new Point(12, 116);
            createRoomGroup.Name = "createRoomGroup";
            createRoomGroup.Size = new Size(250, 268);
            createRoomGroup.TabIndex = 8;
            createRoomGroup.TabStop = false;
            createRoomGroup.Text = "Oda Oluştur";
            // 
            // priceText
            // 
            priceText.Location = new Point(125, 128);
            priceText.Name = "priceText";
            priceText.Size = new Size(125, 30);
            priceText.TabIndex = 3;
            // 
            // roomTypeText
            // 
            roomTypeText.Location = new Point(125, 57);
            roomTypeText.Name = "roomTypeText";
            roomTypeText.Size = new Size(125, 30);
            roomTypeText.TabIndex = 2;
            // 
            // odaOlustur
            // 
            odaOlustur.BackColor = SystemColors.ActiveCaptionText;
            odaOlustur.ForeColor = Color.Transparent;
            odaOlustur.Location = new Point(0, 217);
            odaOlustur.Name = "odaOlustur";
            odaOlustur.Size = new Size(250, 51);
            odaOlustur.TabIndex = 9;
            odaOlustur.Text = "Oda Oluştur";
            odaOlustur.UseVisualStyleBackColor = false;
            odaOlustur.Click += odaOlustur_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(34, 131);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(49, 23);
            priceLabel.TabIndex = 1;
            priceLabel.Text = "Fiyat";
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.Location = new Point(22, 60);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new Size(79, 23);
            roomTypeLabel.TabIndex = 0;
            roomTypeLabel.Text = "Oda Tipi";
            // 
            // odaDuzenle
            // 
            odaDuzenle.BackColor = Color.Black;
            odaDuzenle.ForeColor = Color.Transparent;
            odaDuzenle.Location = new Point(0, 217);
            odaDuzenle.Name = "odaDuzenle";
            odaDuzenle.Size = new Size(250, 51);
            odaDuzenle.TabIndex = 10;
            odaDuzenle.Text = "Odayı Düzenle";
            odaDuzenle.UseVisualStyleBackColor = false;
            odaDuzenle.Click += odaDuzenle_Click;
            // 
            // odaSIl
            // 
            odaSIl.BackColor = SystemColors.ActiveCaptionText;
            odaSIl.ForeColor = Color.Transparent;
            odaSIl.Location = new Point(0, 78);
            odaSIl.Name = "odaSIl";
            odaSIl.Size = new Size(250, 35);
            odaSIl.TabIndex = 11;
            odaSIl.Text = "Odayı Sil";
            odaSIl.UseVisualStyleBackColor = false;
            odaSIl.Click += odaSil_Click;
            // 
            // editRoomGroup
            // 
            editRoomGroup.Controls.Add(roomIDText);
            editRoomGroup.Controls.Add(roomIDLabel);
            editRoomGroup.Controls.Add(odaDuzenle);
            editRoomGroup.Controls.Add(editPriceText);
            editRoomGroup.Controls.Add(editRoomTypeText);
            editRoomGroup.Controls.Add(editPriceLabel);
            editRoomGroup.Controls.Add(editRoomTypeLabel);
            editRoomGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            editRoomGroup.Location = new Point(302, 116);
            editRoomGroup.Name = "editRoomGroup";
            editRoomGroup.Size = new Size(250, 268);
            editRoomGroup.TabIndex = 9;
            editRoomGroup.TabStop = false;
            editRoomGroup.Text = "Oda Düzenle";
            // 
            // roomIDText
            // 
            roomIDText.Location = new Point(119, 45);
            roomIDText.Name = "roomIDText";
            roomIDText.Size = new Size(125, 30);
            roomIDText.TabIndex = 9;
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Location = new Point(22, 45);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new Size(66, 23);
            roomIDLabel.TabIndex = 8;
            roomIDLabel.Text = "Oda ID";
            // 
            // editPriceText
            // 
            editPriceText.Location = new Point(119, 162);
            editPriceText.Name = "editPriceText";
            editPriceText.Size = new Size(125, 30);
            editPriceText.TabIndex = 3;
            // 
            // editRoomTypeText
            // 
            editRoomTypeText.Location = new Point(119, 102);
            editRoomTypeText.Name = "editRoomTypeText";
            editRoomTypeText.Size = new Size(125, 30);
            editRoomTypeText.TabIndex = 2;
            // 
            // editPriceLabel
            // 
            editPriceLabel.AutoSize = true;
            editPriceLabel.Location = new Point(22, 165);
            editPriceLabel.Name = "editPriceLabel";
            editPriceLabel.Size = new Size(49, 23);
            editPriceLabel.TabIndex = 1;
            editPriceLabel.Text = "Fiyat";
            // 
            // editRoomTypeLabel
            // 
            editRoomTypeLabel.AutoSize = true;
            editRoomTypeLabel.Location = new Point(22, 105);
            editRoomTypeLabel.Name = "editRoomTypeLabel";
            editRoomTypeLabel.Size = new Size(79, 23);
            editRoomTypeLabel.TabIndex = 0;
            editRoomTypeLabel.Text = "Oda Tipi";
            // 
            // deleteRoomGroup
            // 
            deleteRoomGroup.Controls.Add(deletedRoomIDText);
            deleteRoomGroup.Controls.Add(deletedRoomIDLabel);
            deleteRoomGroup.Controls.Add(odaSIl);
            deleteRoomGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            deleteRoomGroup.Location = new Point(592, 116);
            deleteRoomGroup.Name = "deleteRoomGroup";
            deleteRoomGroup.Size = new Size(250, 117);
            deleteRoomGroup.TabIndex = 12;
            deleteRoomGroup.TabStop = false;
            deleteRoomGroup.Text = "Oda Sil";
            // 
            // deletedRoomIDText
            // 
            deletedRoomIDText.Location = new Point(119, 39);
            deletedRoomIDText.Name = "deletedRoomIDText";
            deletedRoomIDText.Size = new Size(125, 30);
            deletedRoomIDText.TabIndex = 6;
            // 
            // deletedRoomIDLabel
            // 
            deletedRoomIDLabel.AutoSize = true;
            deletedRoomIDLabel.Location = new Point(22, 42);
            deletedRoomIDLabel.Name = "deletedRoomIDLabel";
            deletedRoomIDLabel.Size = new Size(66, 23);
            deletedRoomIDLabel.TabIndex = 6;
            deletedRoomIDLabel.Text = "Oda ID";
            // 
            // enrtyExitGroup
            // 
            enrtyExitGroup.Controls.Add(cikisYap);
            enrtyExitGroup.Controls.Add(entryExitRoomIDText);
            enrtyExitGroup.Controls.Add(entryExitRoomIDLabel);
            enrtyExitGroup.Controls.Add(girisYap);
            enrtyExitGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            enrtyExitGroup.Location = new Point(592, 230);
            enrtyExitGroup.Name = "enrtyExitGroup";
            enrtyExitGroup.Size = new Size(250, 154);
            enrtyExitGroup.TabIndex = 13;
            enrtyExitGroup.TabStop = false;
            enrtyExitGroup.Text = "Giriş ve Çıkış ";
            // 
            // cikisYap
            // 
            cikisYap.BackColor = Color.Black;
            cikisYap.ForeColor = Color.Transparent;
            cikisYap.Location = new Point(0, 125);
            cikisYap.Name = "cikisYap";
            cikisYap.Size = new Size(250, 32);
            cikisYap.TabIndex = 12;
            cikisYap.Text = "Çıkış Yap";
            cikisYap.UseVisualStyleBackColor = false;
            cikisYap.Click += cikisYap_Click;
            // 
            // entryExitRoomIDText
            // 
            entryExitRoomIDText.Location = new Point(119, 45);
            entryExitRoomIDText.Name = "entryExitRoomIDText";
            entryExitRoomIDText.Size = new Size(125, 30);
            entryExitRoomIDText.TabIndex = 6;
            // 
            // entryExitRoomIDLabel
            // 
            entryExitRoomIDLabel.AutoSize = true;
            entryExitRoomIDLabel.Location = new Point(22, 45);
            entryExitRoomIDLabel.Name = "entryExitRoomIDLabel";
            entryExitRoomIDLabel.Size = new Size(66, 23);
            entryExitRoomIDLabel.TabIndex = 6;
            entryExitRoomIDLabel.Text = "Oda ID";
            // 
            // girisYap
            // 
            girisYap.BackColor = SystemColors.ActiveCaptionText;
            girisYap.ForeColor = Color.Transparent;
            girisYap.Location = new Point(0, 90);
            girisYap.Name = "girisYap";
            girisYap.Size = new Size(250, 32);
            girisYap.TabIndex = 11;
            girisYap.Text = "Giriş Yap";
            girisYap.UseVisualStyleBackColor = false;
            girisYap.Click += girisYap_Click;
            // 
            // Oda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1424, 453);
            Controls.Add(enrtyExitGroup);
            Controls.Add(deleteRoomGroup);
            Controls.Add(editRoomGroup);
            Controls.Add(createRoomGroup);
            Controls.Add(odaListesi);
            Controls.Add(roomPageLabel);
            Controls.Add(rezervasyon);
            Controls.Add(musteri);
            Name = "Oda";
            Text = "Oda";
            Load += Oda_Load;
            createRoomGroup.ResumeLayout(false);
            createRoomGroup.PerformLayout();
            editRoomGroup.ResumeLayout(false);
            editRoomGroup.PerformLayout();
            deleteRoomGroup.ResumeLayout(false);
            deleteRoomGroup.PerformLayout();
            enrtyExitGroup.ResumeLayout(false);
            enrtyExitGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button musteri;
        private Button rezervasyon;
        private Label roomPageLabel;
        private ListView odaListesi;
        private GroupBox createRoomGroup;
        private Label priceLabel;
        private Label roomTypeLabel;
        private TextBox roomTypeText;
        private TextBox priceText;
        private Button odaOlustur;
        private Button odaDuzenle;
        private Button odaSIl;
        private GroupBox editRoomGroup;
        private TextBox editPriceText;
        private TextBox editRoomTypeText;
        private Label editPriceLabel;
        private Label editRoomTypeLabel;
        private TextBox roomIDText;
        private Label roomIDLabel;
        private GroupBox deleteRoomGroup;
        private Label deletedRoomIDLabel;
        private TextBox deletedRoomIDText;
        private GroupBox enrtyExitGroup;
        private TextBox entryExitRoomIDText;
        private Label entryExitRoomIDLabel;
        private Button girisYap;
        private Button cikisYap;
    }
}