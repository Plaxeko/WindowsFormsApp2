namespace WindowsFormsApp2
{
    partial class Robot
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
            this.pnlRobot = new System.Windows.Forms.Panel();
            this.lblRobot = new System.Windows.Forms.Label();
            this.btnMoveOne = new System.Windows.Forms.Button();
            this.btnGoWest = new System.Windows.Forms.Button();
            this.btnGoNorth = new System.Windows.Forms.Button();
            this.btnGoSouth = new System.Windows.Forms.Button();
            this.btnGoEast = new System.Windows.Forms.Button();
            this.btnMoveTen = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pnlRobot.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRobot
            // 
            this.pnlRobot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRobot.Controls.Add(this.lblRobot);
            this.pnlRobot.Location = new System.Drawing.Point(14, 18);
            this.pnlRobot.Name = "pnlRobot";
            this.pnlRobot.Size = new System.Drawing.Size(390, 400);
            this.pnlRobot.TabIndex = 0;
            this.pnlRobot.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRobot_Paint);
            // 
            // lblRobot
            // 
            this.lblRobot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRobot.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblRobot.Location = new System.Drawing.Point(-5, 0);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(13, 12);
            this.lblRobot.TabIndex = 0;
            this.lblRobot.Text = "X";
            // 
            // btnMoveOne
            // 
            this.btnMoveOne.Location = new System.Drawing.Point(304, 432);
            this.btnMoveOne.Name = "btnMoveOne";
            this.btnMoveOne.Size = new System.Drawing.Size(52, 23);
            this.btnMoveOne.TabIndex = 1;
            this.btnMoveOne.Text = "Go 1";
            this.btnMoveOne.UseVisualStyleBackColor = true;
            this.btnMoveOne.Click += new System.EventHandler(this.btnMoveOne_Click);
            // 
            // btnGoWest
            // 
            this.btnGoWest.Location = new System.Drawing.Point(74, 456);
            this.btnGoWest.Name = "btnGoWest";
            this.btnGoWest.Size = new System.Drawing.Size(24, 23);
            this.btnGoWest.TabIndex = 2;
            this.btnGoWest.Text = "W";
            this.btnGoWest.UseVisualStyleBackColor = true;
            this.btnGoWest.Click += new System.EventHandler(this.btnGoWest_Click);
            // 
            // btnGoNorth
            // 
            this.btnGoNorth.Location = new System.Drawing.Point(95, 432);
            this.btnGoNorth.Name = "btnGoNorth";
            this.btnGoNorth.Size = new System.Drawing.Size(24, 23);
            this.btnGoNorth.TabIndex = 3;
            this.btnGoNorth.Text = "N";
            this.btnGoNorth.UseVisualStyleBackColor = true;
            this.btnGoNorth.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGoSouth
            // 
            this.btnGoSouth.Location = new System.Drawing.Point(95, 479);
            this.btnGoSouth.Name = "btnGoSouth";
            this.btnGoSouth.Size = new System.Drawing.Size(24, 23);
            this.btnGoSouth.TabIndex = 4;
            this.btnGoSouth.Text = "S";
            this.btnGoSouth.UseVisualStyleBackColor = true;
            this.btnGoSouth.Click += new System.EventHandler(this.btnGoSouth_Click);
            // 
            // btnGoEast
            // 
            this.btnGoEast.Location = new System.Drawing.Point(115, 456);
            this.btnGoEast.Name = "btnGoEast";
            this.btnGoEast.Size = new System.Drawing.Size(24, 23);
            this.btnGoEast.TabIndex = 5;
            this.btnGoEast.Text = "E";
            this.btnGoEast.UseVisualStyleBackColor = true;
            this.btnGoEast.Click += new System.EventHandler(this.btnGoEast_Click);
            // 
            // btnMoveTen
            // 
            this.btnMoveTen.Location = new System.Drawing.Point(304, 470);
            this.btnMoveTen.Name = "btnMoveTen";
            this.btnMoveTen.Size = new System.Drawing.Size(60, 23);
            this.btnMoveTen.TabIndex = 6;
            this.btnMoveTen.Text = "Go 10";
            this.btnMoveTen.UseVisualStyleBackColor = true;
            this.btnMoveTen.Click += new System.EventHandler(this.btnMoveTen_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(13, 2);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(35, 13);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "label1";
            // 
            // Robot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 514);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnMoveTen);
            this.Controls.Add(this.btnGoEast);
            this.Controls.Add(this.btnGoSouth);
            this.Controls.Add(this.btnGoNorth);
            this.Controls.Add(this.btnGoWest);
            this.Controls.Add(this.btnMoveOne);
            this.Controls.Add(this.pnlRobot);
            this.Name = "Robot";
            this.Text = "Robot";
            this.Load += new System.EventHandler(this.Robot_Load);
            this.pnlRobot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRobot;
        private System.Windows.Forms.Button btnMoveOne;
        private System.Windows.Forms.Button btnGoWest;
        private System.Windows.Forms.Button btnGoNorth;
        private System.Windows.Forms.Button btnGoSouth;
        private System.Windows.Forms.Button btnGoEast;
        private System.Windows.Forms.Button btnMoveTen;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblRobot;
    }
}

