namespace Coins
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("", 5);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("", 6);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("", 7);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moneylist1 = new System.Windows.Forms.ListView();
            this.moneylist2 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.moneyimagelist = new System.Windows.Forms.ImageList(this.components);
            this.totalmoneyamount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moneylist1
            // 
            this.moneylist1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.moneylist1.HideSelection = false;
            this.moneylist1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.moneylist1.LargeImageList = this.moneyimagelist;
            this.moneylist1.Location = new System.Drawing.Point(54, 81);
            this.moneylist1.MultiSelect = false;
            this.moneylist1.Name = "moneylist1";
            this.moneylist1.Size = new System.Drawing.Size(336, 295);
            this.moneylist1.TabIndex = 0;
            this.moneylist1.TileSize = new System.Drawing.Size(200, 30);
            this.moneylist1.UseCompatibleStateImageBehavior = false;
            this.moneylist1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.moneylist1_ItemDrag);
            // 
            // moneylist2
            // 
            this.moneylist2.AllowDrop = true;
            this.moneylist2.HideSelection = false;
            this.moneylist2.LargeImageList = this.moneyimagelist;
            this.moneylist2.Location = new System.Drawing.Point(459, 81);
            this.moneylist2.MultiSelect = false;
            this.moneylist2.Name = "moneylist2";
            this.moneylist2.Size = new System.Drawing.Size(329, 295);
            this.moneylist2.TabIndex = 1;
            this.moneylist2.UseCompatibleStateImageBehavior = false;
            this.moneylist2.DragDrop += new System.Windows.Forms.DragEventHandler(this.moneylist2_DragDrop);
            this.moneylist2.DragEnter += new System.Windows.Forms.DragEventHandler(this.moneylist2_DragEnter);
            this.moneylist2.DragLeave += new System.EventHandler(this.moneylist2_DragLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moneyimagelist
            // 
            this.moneyimagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moneyimagelist.ImageStream")));
            this.moneyimagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.moneyimagelist.Images.SetKeyName(0, @".\.\1f.jpg");
            this.moneyimagelist.Images.SetKeyName(1, @".\.\2f.jpg");
            this.moneyimagelist.Images.SetKeyName(2, @".\.\5f.jpg");
            this.moneyimagelist.Images.SetKeyName(3, @".\.\5p.jpg");
            this.moneyimagelist.Images.SetKeyName(4, @".\.\10f.jpg");
            this.moneyimagelist.Images.SetKeyName(5, @".\.\10p.jpg");
            this.moneyimagelist.Images.SetKeyName(6, @".\.\20p.jpg");
            this.moneyimagelist.Images.SetKeyName(7, @".\.\50p.jpg");
            // 
            // totalmoneyamount
            // 
            this.totalmoneyamount.AutoSize = true;
            this.totalmoneyamount.Location = new System.Drawing.Point(400, 22);
            this.totalmoneyamount.Name = "totalmoneyamount";
            this.totalmoneyamount.Size = new System.Drawing.Size(0, 13);
            this.totalmoneyamount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(576, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Перетаскивайте сюда";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalmoneyamount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moneylist2);
            this.Controls.Add(this.moneylist1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView moneylist1;
        private System.Windows.Forms.ImageList moneyimagelist;
        private System.Windows.Forms.ListView moneylist2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totalmoneyamount;
        private System.Windows.Forms.Label label1;
    }
}

