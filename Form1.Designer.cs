namespace showIn4
{
    partial class In4
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.name.Location = new System.Drawing.Point(28, 93);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 26);
            this.name.TabIndex = 1;
            this.name.Text = "label2";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.id.Location = new System.Drawing.Point(28, 144);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(70, 26);
            this.id.TabIndex = 2;
            this.id.Text = "label2";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gender.Location = new System.Drawing.Point(28, 194);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(70, 26);
            this.gender.TabIndex = 3;
            this.gender.Text = "label2";
            // 
            // birth
            // 
            this.birth.AutoSize = true;
            this.birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.birth.Location = new System.Drawing.Point(28, 245);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(70, 26);
            this.birth.TabIndex = 4;
            this.birth.Text = "label2";
            // 
            // In4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 645);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "In4";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.In4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label birth;
    }
}

