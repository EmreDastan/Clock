
namespace Clock
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hhmm = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hhmm
            // 
            this.hhmm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hhmm.Font = new System.Drawing.Font("DS-Digital", 129.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hhmm.ForeColor = System.Drawing.Color.Green;
            this.hhmm.Location = new System.Drawing.Point(12, 17);
            this.hhmm.Name = "hhmm";
            this.hhmm.Size = new System.Drawing.Size(468, 197);
            this.hhmm.TabIndex = 0;
            this.hhmm.Text = "00:00";
            this.hhmm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss
            // 
            this.ss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ss.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss.ForeColor = System.Drawing.Color.Green;
            this.ss.Location = new System.Drawing.Point(496, 96);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(166, 94);
            this.ss.TabIndex = 1;
            this.ss.Text = "ss";
            this.ss.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // date
            // 
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Green;
            this.date.Location = new System.Drawing.Point(32, 233);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(354, 86);
            this.date.TabIndex = 2;
            this.date.Text = "date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // day
            // 
            this.day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.day.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.ForeColor = System.Drawing.Color.Green;
            this.day.Location = new System.Drawing.Point(430, 233);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(310, 86);
            this.day.TabIndex = 3;
            this.day.Text = "day";
            this.day.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(758, 345);
            this.Controls.Add(this.day);
            this.Controls.Add(this.date);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.hhmm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hhmm;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Timer timer;
    }
}

