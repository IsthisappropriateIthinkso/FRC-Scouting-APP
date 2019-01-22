namespace FRC_Scout
{
    partial class frmFilm
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Game1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("FRC_CHAMPIONSHIPS", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("2019 SEASON", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.FilmTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // FilmTreeView
            // 
            this.FilmTreeView.Location = new System.Drawing.Point(108, 41);
            this.FilmTreeView.Name = "FilmTreeView";
            treeNode4.Name = "Game1Node";
            treeNode4.Text = "Game1";
            treeNode5.Name = "NameOfTournamentNode";
            treeNode5.Text = "FRC_CHAMPIONSHIPS";
            treeNode6.Name = "FRC_SEASON_NODE";
            treeNode6.Text = "2019 SEASON";
            this.FilmTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.FilmTreeView.Size = new System.Drawing.Size(279, 272);
            this.FilmTreeView.TabIndex = 0;
            // 
            // frmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilmTreeView);
            this.Name = "frmFilm";
            this.Text = "frmFilm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView FilmTreeView;
    }
}