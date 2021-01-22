
namespace Crypto_Analyzer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnSymbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPriceUsd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPercentChange24H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPercentChange7d = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMarketCapUSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVolume24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPBtc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSymbol,
            this.columnName,
            this.columnRank,
            this.columnPriceUsd,
            this.columnPercentChange24H,
            this.columnPercentChange7d,
            this.columnMarketCapUSD,
            this.columnVolume24,
            this.columnCS,
            this.columnPBtc,
            this.columnTS,
            this.columnMS});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(882, 386);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnSymbol
            // 
            this.columnSymbol.Text = "Symbol";
            this.columnSymbol.Width = 150;
            // 
            // columnName
            // 
            this.columnName.Text = "Currency Name";
            this.columnName.Width = 150;
            // 
            // columnRank
            // 
            this.columnRank.Text = "Rank";
            this.columnRank.Width = 150;
            // 
            // columnPriceUsd
            // 
            this.columnPriceUsd.Text = "Price USD";
            this.columnPriceUsd.Width = 150;
            // 
            // columnPercentChange24H
            // 
            this.columnPercentChange24H.Text = "Change % 24H";
            this.columnPercentChange24H.Width = 150;
            // 
            // columnPercentChange7d
            // 
            this.columnPercentChange7d.Text = "Change % 7d";
            this.columnPercentChange7d.Width = 150;
            // 
            // columnMarketCapUSD
            // 
            this.columnMarketCapUSD.Text = "Market Cap USD";
            this.columnMarketCapUSD.Width = 150;
            // 
            // columnVolume24
            // 
            this.columnVolume24.Text = "Volume 24H USD";
            this.columnVolume24.Width = 150;
            // 
            // columnCS
            // 
            this.columnCS.Text = "Coin Supply";
            this.columnCS.Width = 150;
            // 
            // columnPBtc
            // 
            this.columnPBtc.Text = "Price Bitcoin";
            this.columnPBtc.Width = 150;
            // 
            // columnTS
            // 
            this.columnTS.Text = "Total Supply";
            this.columnTS.Width = 150;
            // 
            // columnMS
            // 
            this.columnMS.Text = "Max Supply";
            this.columnMS.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 386);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Crypto Market Analyzer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnSymbol;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnRank;
        private System.Windows.Forms.ColumnHeader columnPriceUsd;
        private System.Windows.Forms.ColumnHeader columnPercentChange24H;
        private System.Windows.Forms.ColumnHeader columnPercentChange7d;
        private System.Windows.Forms.ColumnHeader columnMarketCapUSD;
        private System.Windows.Forms.ColumnHeader columnVolume24;
        private System.Windows.Forms.ColumnHeader columnCS;
        private System.Windows.Forms.ColumnHeader columnPBtc;
        private System.Windows.Forms.ColumnHeader columnTS;
        private System.Windows.Forms.ColumnHeader columnMS;
    }
}