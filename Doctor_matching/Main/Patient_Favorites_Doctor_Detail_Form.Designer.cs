﻿
namespace Main
{
    partial class Patient_Favorites_Doctor_Detail_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Favorites_Doctor_Detail_Form));
            this.doctor_detail_box = new System.Windows.Forms.GroupBox();
            this.doctor_coment_view = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.write_coment_btn = new System.Windows.Forms.Button();
            this.reservation_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.favorites_cancel_btn = new System.Windows.Forms.Button();
            this.recommend_btn = new System.Windows.Forms.Button();
            this.hospital_detail_btn = new System.Windows.Forms.Button();
            this.introduce_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.phone_num_label = new System.Windows.Forms.Label();
            this.department_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hospital_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.doctor_image = new System.Windows.Forms.PictureBox();
            this.doctor_detail_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_coment_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_image)).BeginInit();
            this.SuspendLayout();
            // 
            // doctor_detail_box
            // 
            this.doctor_detail_box.Controls.Add(this.doctor_coment_view);
            this.doctor_detail_box.Controls.Add(this.write_coment_btn);
            this.doctor_detail_box.Controls.Add(this.reservation_btn);
            this.doctor_detail_box.Controls.Add(this.back_btn);
            this.doctor_detail_box.Controls.Add(this.favorites_cancel_btn);
            this.doctor_detail_box.Controls.Add(this.recommend_btn);
            this.doctor_detail_box.Controls.Add(this.hospital_detail_btn);
            this.doctor_detail_box.Controls.Add(this.introduce_label);
            this.doctor_detail_box.Controls.Add(this.email_label);
            this.doctor_detail_box.Controls.Add(this.phone_num_label);
            this.doctor_detail_box.Controls.Add(this.department_label);
            this.doctor_detail_box.Controls.Add(this.label7);
            this.doctor_detail_box.Controls.Add(this.label6);
            this.doctor_detail_box.Controls.Add(this.label5);
            this.doctor_detail_box.Controls.Add(this.hospital_label);
            this.doctor_detail_box.Controls.Add(this.label3);
            this.doctor_detail_box.Controls.Add(this.label2);
            this.doctor_detail_box.Controls.Add(this.name_label);
            this.doctor_detail_box.Controls.Add(this.doctor_image);
            this.doctor_detail_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_detail_box.Location = new System.Drawing.Point(27, 12);
            this.doctor_detail_box.Name = "doctor_detail_box";
            this.doctor_detail_box.Size = new System.Drawing.Size(1140, 792);
            this.doctor_detail_box.TabIndex = 6;
            this.doctor_detail_box.TabStop = false;
            this.doctor_detail_box.Text = "의사정보";
            // 
            // doctor_coment_view
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctor_coment_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.doctor_coment_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctor_coment_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doctor_coment_view.DefaultCellStyle = dataGridViewCellStyle6;
            this.doctor_coment_view.Location = new System.Drawing.Point(16, 359);
            this.doctor_coment_view.Name = "doctor_coment_view";
            this.doctor_coment_view.RowTemplate.Height = 37;
            this.doctor_coment_view.Size = new System.Drawing.Size(1068, 427);
            this.doctor_coment_view.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "작성자";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "댓글내용";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "추천수";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "추천하기";
            this.Column4.Name = "Column4";
            this.Column4.Width = 76;
            // 
            // write_coment_btn
            // 
            this.write_coment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.write_coment_btn.Location = new System.Drawing.Point(967, 307);
            this.write_coment_btn.Name = "write_coment_btn";
            this.write_coment_btn.Size = new System.Drawing.Size(117, 43);
            this.write_coment_btn.TabIndex = 17;
            this.write_coment_btn.Text = "댓글쓰기";
            this.write_coment_btn.UseVisualStyleBackColor = true;
            // 
            // reservation_btn
            // 
            this.reservation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_btn.Location = new System.Drawing.Point(924, 103);
            this.reservation_btn.Name = "reservation_btn";
            this.reservation_btn.Size = new System.Drawing.Size(160, 152);
            this.reservation_btn.TabIndex = 16;
            this.reservation_btn.Text = "예약하기";
            this.reservation_btn.UseVisualStyleBackColor = true;
            this.reservation_btn.Click += new System.EventHandler(this.reservation_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(924, 28);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(160, 38);
            this.back_btn.TabIndex = 15;
            this.back_btn.Text = "뒤로가기";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // favorites_cancel_btn
            // 
            this.favorites_cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorites_cancel_btn.Location = new System.Drawing.Point(713, 28);
            this.favorites_cancel_btn.Name = "favorites_cancel_btn";
            this.favorites_cancel_btn.Size = new System.Drawing.Size(160, 38);
            this.favorites_cancel_btn.TabIndex = 14;
            this.favorites_cancel_btn.Text = "즐겨찾기해지";
            this.favorites_cancel_btn.UseVisualStyleBackColor = true;
            this.favorites_cancel_btn.Click += new System.EventHandler(this.favorites_cancel_btn_Click);
            // 
            // recommend_btn
            // 
            this.recommend_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommend_btn.Location = new System.Drawing.Point(506, 28);
            this.recommend_btn.Name = "recommend_btn";
            this.recommend_btn.Size = new System.Drawing.Size(160, 38);
            this.recommend_btn.TabIndex = 13;
            this.recommend_btn.Text = "추천하기";
            this.recommend_btn.UseVisualStyleBackColor = true;
            this.recommend_btn.Click += new System.EventHandler(this.recommend_btn_Click);
            // 
            // hospital_detail_btn
            // 
            this.hospital_detail_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospital_detail_btn.Location = new System.Drawing.Point(293, 28);
            this.hospital_detail_btn.Name = "hospital_detail_btn";
            this.hospital_detail_btn.Size = new System.Drawing.Size(160, 38);
            this.hospital_detail_btn.TabIndex = 12;
            this.hospital_detail_btn.Text = "병원상세보기";
            this.hospital_detail_btn.UseVisualStyleBackColor = true;
            // 
            // introduce_label
            // 
            this.introduce_label.AutoSize = true;
            this.introduce_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.introduce_label.Location = new System.Drawing.Point(311, 284);
            this.introduce_label.Name = "introduce_label";
            this.introduce_label.Size = new System.Drawing.Size(495, 19);
            this.introduce_label.TabIndex = 11;
            this.introduce_label.Text = "안녕하세요 부천대학교에서 근무하고 있는 정유환입니다!";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.email_label.Location = new System.Drawing.Point(324, 236);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(184, 19);
            this.email_label.TabIndex = 10;
            this.email_label.Text = "bak3353@naver.com";
            // 
            // phone_num_label
            // 
            this.phone_num_label.AutoSize = true;
            this.phone_num_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phone_num_label.Location = new System.Drawing.Point(349, 191);
            this.phone_num_label.Name = "phone_num_label";
            this.phone_num_label.Size = new System.Drawing.Size(137, 19);
            this.phone_num_label.TabIndex = 9;
            this.phone_num_label.Text = "010-2204-7847";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.department_label.Location = new System.Drawing.Point(374, 149);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(66, 19);
            this.department_label.TabIndex = 8;
            this.department_label.Text = "신경과";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(246, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "소개 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(246, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "E_Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(246, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "전화번호 :";
            // 
            // hospital_label
            // 
            this.hospital_label.AutoSize = true;
            this.hospital_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hospital_label.Location = new System.Drawing.Point(349, 103);
            this.hospital_label.Name = "hospital_label";
            this.hospital_label.Size = new System.Drawing.Size(104, 19);
            this.hospital_label.TabIndex = 4;
            this.hospital_label.Text = "부천대학교";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(246, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "주요 진료과 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(246, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "소속병원 :";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_label.Location = new System.Drawing.Point(89, 319);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(66, 19);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "정유환";
            // 
            // doctor_image
            // 
            this.doctor_image.Image = global::Main.Properties.Resources.doctor_original;
            this.doctor_image.InitialImage = ((System.Drawing.Image)(resources.GetObject("doctor_image.InitialImage")));
            this.doctor_image.Location = new System.Drawing.Point(16, 103);
            this.doctor_image.Name = "doctor_image";
            this.doctor_image.Size = new System.Drawing.Size(200, 200);
            this.doctor_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doctor_image.TabIndex = 0;
            this.doctor_image.TabStop = false;
            // 
            // Patient_Favorites_Doctor_Detail_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1195, 816);
            this.Controls.Add(this.doctor_detail_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient_Favorites_Doctor_Detail_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Favorites_Doctor_Detail_Form";
            this.Load += new System.EventHandler(this.Patient_Favorites_Doctor_Detail_Form_Load);
            this.doctor_detail_box.ResumeLayout(false);
            this.doctor_detail_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_coment_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox doctor_detail_box;
        private System.Windows.Forms.DataGridView doctor_coment_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Button write_coment_btn;
        private System.Windows.Forms.Button reservation_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button favorites_cancel_btn;
        private System.Windows.Forms.Button recommend_btn;
        private System.Windows.Forms.Button hospital_detail_btn;
        private System.Windows.Forms.Label introduce_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phone_num_label;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hospital_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox doctor_image;
    }
}