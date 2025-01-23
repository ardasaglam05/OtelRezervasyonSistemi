namespace HotelReservationSystem
{
    partial class Rezervasyon
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
            reservationPageLabel = new Label();
            musteri = new Button();
            oda = new Button();
            endDatePicker = new DateTimePicker();
            startDatePicker = new DateTimePicker();
            endingDateLabel = new Label();
            startingDateLabel = new Label();
            rezervasyonOlustur = new Button();
            createReservationGroup = new GroupBox();
            roomIDText = new TextBox();
            idText = new TextBox();
            roomIDLabel = new Label();
            idLabel = new Label();
            rezervasyonListesi = new ListView();
            editReservationGroup = new GroupBox();
            editEndDatePicker = new DateTimePicker();
            rezervasyonDuzenle = new Button();
            reservationIDText = new TextBox();
            editStartDatePicker = new DateTimePicker();
            reservationIDLabel = new Label();
            editEndingDateLabel = new Label();
            editStartingDateLabel = new Label();
            deleteReservationGroup = new GroupBox();
            rezervasyonSil = new Button();
            deleteReservationIDText = new TextBox();
            deleteReservationIDLabel = new Label();
            getReservationGroup = new GroupBox();
            rezervasyonBul = new Button();
            getCustomerIDText = new TextBox();
            getReservationIDLabel = new Label();
            openFileDialog1 = new OpenFileDialog();
            createReservationGroup.SuspendLayout();
            editReservationGroup.SuspendLayout();
            deleteReservationGroup.SuspendLayout();
            getReservationGroup.SuspendLayout();
            SuspendLayout();
            // 
            // reservationPageLabel
            // 
            reservationPageLabel.AutoSize = true;
            reservationPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            reservationPageLabel.ImageAlign = ContentAlignment.TopCenter;
            reservationPageLabel.Location = new Point(618, 9);
            reservationPageLabel.Name = "reservationPageLabel";
            reservationPageLabel.Size = new Size(205, 28);
            reservationPageLabel.TabIndex = 1;
            reservationPageLabel.Text = "Rezervasyon Sayfası";
            // 
            // musteri
            // 
            musteri.BackColor = SystemColors.ActiveCaptionText;
            musteri.ForeColor = SystemColors.ControlLightLight;
            musteri.Location = new Point(1251, 12);
            musteri.Name = "musteri";
            musteri.Size = new Size(161, 29);
            musteri.TabIndex = 2;
            musteri.Text = "Müşteri Yönetimi";
            musteri.UseVisualStyleBackColor = false;
            musteri.Click += musteri_Click;
            // 
            // oda
            // 
            oda.BackColor = SystemColors.ActiveCaptionText;
            oda.ForeColor = SystemColors.ControlLightLight;
            oda.Location = new Point(12, 12);
            oda.Name = "oda";
            oda.Size = new Size(161, 29);
            oda.TabIndex = 3;
            oda.Text = "Oda Yönetimi";
            oda.UseVisualStyleBackColor = false;
            oda.Click += oda_Click;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(139, 180);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(95, 30);
            endDatePicker.TabIndex = 8;
            endDatePicker.Value = new DateTime(2025, 1, 1, 18, 39, 0, 0);
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(139, 135);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(95, 30);
            startDatePicker.TabIndex = 7;
            startDatePicker.Value = new DateTime(2025, 1, 1, 18, 39, 0, 0);
            // 
            // endingDateLabel
            // 
            endingDateLabel.AutoSize = true;
            endingDateLabel.Location = new Point(22, 180);
            endingDateLabel.Name = "endingDateLabel";
            endingDateLabel.Size = new Size(95, 23);
            endingDateLabel.TabIndex = 5;
            endingDateLabel.Text = "Bitiş Tarihi";
            // 
            // startingDateLabel
            // 
            startingDateLabel.AutoSize = true;
            startingDateLabel.Location = new Point(22, 135);
            startingDateLabel.Name = "startingDateLabel";
            startingDateLabel.Size = new Size(135, 23);
            startingDateLabel.TabIndex = 4;
            startingDateLabel.Text = "Başlangıç ​​Tarihi";
            // 
            // rezervasyonOlustur
            // 
            rezervasyonOlustur.BackColor = SystemColors.ActiveCaptionText;
            rezervasyonOlustur.ForeColor = Color.Transparent;
            rezervasyonOlustur.Location = new Point(0, 228);
            rezervasyonOlustur.Name = "rezervasyonOlustur";
            rezervasyonOlustur.Size = new Size(250, 40);
            rezervasyonOlustur.TabIndex = 7;
            rezervasyonOlustur.Text = "Yeni Rezervasyon";
            rezervasyonOlustur.UseVisualStyleBackColor = false;
            rezervasyonOlustur.Click += rezervasyonOlustur_Click;
            // 
            // createReservationGroup
            // 
            createReservationGroup.Controls.Add(roomIDText);
            createReservationGroup.Controls.Add(idText);
            createReservationGroup.Controls.Add(endDatePicker);
            createReservationGroup.Controls.Add(roomIDLabel);
            createReservationGroup.Controls.Add(rezervasyonOlustur);
            createReservationGroup.Controls.Add(startDatePicker);
            createReservationGroup.Controls.Add(idLabel);
            createReservationGroup.Controls.Add(endingDateLabel);
            createReservationGroup.Controls.Add(startingDateLabel);
            createReservationGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            createReservationGroup.Location = new Point(12, 116);
            createReservationGroup.Name = "createReservationGroup";
            createReservationGroup.Size = new Size(250, 268);
            createReservationGroup.TabIndex = 8;
            createReservationGroup.TabStop = false;
            createReservationGroup.Text = "Yeni Rezervasyon";
            // 
            // roomIDText
            // 
            roomIDText.Location = new Point(119, 90);
            roomIDText.Name = "roomIDText";
            roomIDText.Size = new Size(125, 30);
            roomIDText.TabIndex = 12;
            // 
            // idText
            // 
            idText.Location = new Point(119, 45);
            idText.Name = "idText";
            idText.Size = new Size(125, 30);
            idText.TabIndex = 11;
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Location = new Point(22, 90);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new Size(66, 23);
            roomIDLabel.TabIndex = 10;
            roomIDLabel.Text = "Oda ID";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(22, 45);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(90, 23);
            idLabel.TabIndex = 9;
            idLabel.Text = "Kimlik No";
            // 
            // rezervasyonListesi
            // 
            rezervasyonListesi.GridLines = true;
            rezervasyonListesi.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            rezervasyonListesi.Location = new Point(882, 116);
            rezervasyonListesi.MultiSelect = false;
            rezervasyonListesi.Name = "rezervasyonListesi";
            rezervasyonListesi.Size = new Size(520, 268);
            rezervasyonListesi.TabIndex = 9;
            rezervasyonListesi.UseCompatibleStateImageBehavior = false;
            rezervasyonListesi.View = View.Details;
            // 
            // editReservationGroup
            // 
            editReservationGroup.Controls.Add(editEndDatePicker);
            editReservationGroup.Controls.Add(rezervasyonDuzenle);
            editReservationGroup.Controls.Add(reservationIDText);
            editReservationGroup.Controls.Add(editStartDatePicker);
            editReservationGroup.Controls.Add(reservationIDLabel);
            editReservationGroup.Controls.Add(editEndingDateLabel);
            editReservationGroup.Controls.Add(editStartingDateLabel);
            editReservationGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            editReservationGroup.Location = new Point(302, 116);
            editReservationGroup.Name = "editReservationGroup";
            editReservationGroup.Size = new Size(266, 268);
            editReservationGroup.TabIndex = 10;
            editReservationGroup.TabStop = false;
            editReservationGroup.Text = "Rezervasyon Düzenle";
            // 
            // editEndDatePicker
            // 
            editEndDatePicker.Location = new Point(156, 180);
            editEndDatePicker.Name = "editEndDatePicker";
            editEndDatePicker.Size = new Size(95, 30);
            editEndDatePicker.TabIndex = 16;
            editEndDatePicker.Value = new DateTime(2025, 1, 1, 18, 39, 0, 0);
            // 
            // rezervasyonDuzenle
            // 
            rezervasyonDuzenle.BackColor = SystemColors.ActiveCaptionText;
            rezervasyonDuzenle.ForeColor = Color.Transparent;
            rezervasyonDuzenle.Location = new Point(0, 227);
            rezervasyonDuzenle.Name = "rezervasyonDuzenle";
            rezervasyonDuzenle.Size = new Size(266, 41);
            rezervasyonDuzenle.TabIndex = 11;
            rezervasyonDuzenle.Text = "Rezervasyonu Düzenle";
            rezervasyonDuzenle.UseVisualStyleBackColor = false;
            rezervasyonDuzenle.Click += rezervasyonDuzenle_Click;
            // 
            // reservationIDText
            // 
            reservationIDText.Location = new Point(135, 60);
            reservationIDText.Name = "reservationIDText";
            reservationIDText.Size = new Size(125, 30);
            reservationIDText.TabIndex = 13;
            // 
            // editStartDatePicker
            // 
            editStartDatePicker.Location = new Point(156, 120);
            editStartDatePicker.Name = "editStartDatePicker";
            editStartDatePicker.Size = new Size(95, 30);
            editStartDatePicker.TabIndex = 15;
            editStartDatePicker.Value = new DateTime(2025, 1, 1, 18, 39, 0, 0);
            // 
            // reservationIDLabel
            // 
            reservationIDLabel.AutoSize = true;
            reservationIDLabel.Location = new Point(6, 63);
            reservationIDLabel.Name = "reservationIDLabel";
            reservationIDLabel.Size = new Size(132, 23);
            reservationIDLabel.TabIndex = 10;
            reservationIDLabel.Text = "Rezervasyon ID";
            // 
            // editEndingDateLabel
            // 
            editEndingDateLabel.AutoSize = true;
            editEndingDateLabel.Location = new Point(6, 179);
            editEndingDateLabel.Name = "editEndingDateLabel";
            editEndingDateLabel.Size = new Size(95, 23);
            editEndingDateLabel.TabIndex = 14;
            editEndingDateLabel.Text = "Bitiş Tarihi";
            // 
            // editStartingDateLabel
            // 
            editStartingDateLabel.AutoSize = true;
            editStartingDateLabel.Location = new Point(6, 126);
            editStartingDateLabel.Name = "editStartingDateLabel";
            editStartingDateLabel.Size = new Size(135, 23);
            editStartingDateLabel.TabIndex = 13;
            editStartingDateLabel.Text = "Başlangıç ​​Tarihi";
            // 
            // deleteReservationGroup
            // 
            deleteReservationGroup.Controls.Add(rezervasyonSil);
            deleteReservationGroup.Controls.Add(deleteReservationIDText);
            deleteReservationGroup.Controls.Add(deleteReservationIDLabel);
            deleteReservationGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            deleteReservationGroup.Location = new Point(592, 267);
            deleteReservationGroup.Name = "deleteReservationGroup";
            deleteReservationGroup.Size = new Size(266, 117);
            deleteReservationGroup.TabIndex = 12;
            deleteReservationGroup.TabStop = false;
            deleteReservationGroup.Text = "Rezervasyon Sil";
            // 
            // rezervasyonSil
            // 
            rezervasyonSil.BackColor = SystemColors.ActiveCaptionText;
            rezervasyonSil.ForeColor = Color.Transparent;
            rezervasyonSil.Location = new Point(0, 77);
            rezervasyonSil.Name = "rezervasyonSil";
            rezervasyonSil.Size = new Size(266, 41);
            rezervasyonSil.TabIndex = 13;
            rezervasyonSil.Text = "Rezervasyonu Sil";
            rezervasyonSil.UseVisualStyleBackColor = false;
            rezervasyonSil.Click += rezervasyonSil_Click;
            // 
            // deleteReservationIDText
            // 
            deleteReservationIDText.Location = new Point(135, 33);
            deleteReservationIDText.Name = "deleteReservationIDText";
            deleteReservationIDText.Size = new Size(125, 30);
            deleteReservationIDText.TabIndex = 13;
            // 
            // deleteReservationIDLabel
            // 
            deleteReservationIDLabel.AutoSize = true;
            deleteReservationIDLabel.Location = new Point(6, 36);
            deleteReservationIDLabel.Name = "deleteReservationIDLabel";
            deleteReservationIDLabel.Size = new Size(132, 23);
            deleteReservationIDLabel.TabIndex = 13;
            deleteReservationIDLabel.Text = "Rezervasyon ID";
            // 
            // getReservationGroup
            // 
            getReservationGroup.Controls.Add(rezervasyonBul);
            getReservationGroup.Controls.Add(getCustomerIDText);
            getReservationGroup.Controls.Add(getReservationIDLabel);
            getReservationGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            getReservationGroup.Location = new Point(592, 116);
            getReservationGroup.Name = "getReservationGroup";
            getReservationGroup.Size = new Size(266, 117);
            getReservationGroup.TabIndex = 14;
            getReservationGroup.TabStop = false;
            getReservationGroup.Text = "Rezervasyon Bul";
            // 
            // rezervasyonBul
            // 
            rezervasyonBul.BackColor = SystemColors.ActiveCaptionText;
            rezervasyonBul.ForeColor = Color.Transparent;
            rezervasyonBul.Location = new Point(0, 75);
            rezervasyonBul.Name = "rezervasyonBul";
            rezervasyonBul.Size = new Size(266, 41);
            rezervasyonBul.TabIndex = 13;
            rezervasyonBul.Text = "Rezervasyonu Bul";
            rezervasyonBul.UseVisualStyleBackColor = false;
            rezervasyonBul.Click += rezervasyonBul_Click;
            // 
            // getCustomerIDText
            // 
            getCustomerIDText.Location = new Point(135, 29);
            getCustomerIDText.Name = "getCustomerIDText";
            getCustomerIDText.Size = new Size(125, 30);
            getCustomerIDText.TabIndex = 13;
            // 
            // getReservationIDLabel
            // 
            getReservationIDLabel.AutoSize = true;
            getReservationIDLabel.Location = new Point(24, 32);
            getReservationIDLabel.Name = "getReservationIDLabel";
            getReservationIDLabel.Size = new Size(94, 23);
            getReservationIDLabel.TabIndex = 13;
            getReservationIDLabel.Text = "Müşteri ID";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Rezervasyon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1424, 453);
            Controls.Add(getReservationGroup);
            Controls.Add(deleteReservationGroup);
            Controls.Add(editReservationGroup);
            Controls.Add(rezervasyonListesi);
            Controls.Add(createReservationGroup);
            Controls.Add(oda);
            Controls.Add(musteri);
            Controls.Add(reservationPageLabel);
            Name = "Rezervasyon";
            Text = "Rezervasyon";
            Load += Rezervasyon_Load;
            createReservationGroup.ResumeLayout(false);
            createReservationGroup.PerformLayout();
            editReservationGroup.ResumeLayout(false);
            editReservationGroup.PerformLayout();
            deleteReservationGroup.ResumeLayout(false);
            deleteReservationGroup.PerformLayout();
            getReservationGroup.ResumeLayout(false);
            getReservationGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label reservationPageLabel;
        private Button musteri;
        private Button oda;
        private Label startingDateLabel;
        private DateTimePicker endDatePicker;
        private DateTimePicker startDatePicker;
        private Label endingDateLabel;
        private Button rezervasyonOlustur;
        private GroupBox createReservationGroup;
        private Label idLabel;
        private Label roomIDLabel;
        private TextBox roomIDText;
        private TextBox idText;
        private ListView rezervasyonListesi;
        private GroupBox editReservationGroup;
        private DateTimePicker editEndDatePicker;
        private TextBox reservationIDText;
        private DateTimePicker editStartDatePicker;
        private Label reservationIDLabel;
        private Label editEndingDateLabel;
        private Label editStartingDateLabel;
        private Button rezervasyonDuzenle;
        private GroupBox deleteReservationGroup;
        private TextBox deleteReservationIDText;
        private Label deleteReservationIDLabel;
        private Button rezervasyonSil;
        private GroupBox getReservationGroup;
        private Button rezervasyonBul;
        private TextBox getCustomerIDText;
        private Label getReservationIDLabel;
        private OpenFileDialog openFileDialog1;
    }
}