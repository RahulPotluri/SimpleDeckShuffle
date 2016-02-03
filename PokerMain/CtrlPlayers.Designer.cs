namespace PokerMain
{
  partial class CtrlPlayers
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lbl_card_1 = new System.Windows.Forms.Label();
      this.lbl_card_2 = new System.Windows.Forms.Label();
      this.lbl_card_3 = new System.Windows.Forms.Label();
      this.lbl_card_4 = new System.Windows.Forms.Label();
      this.lbl_card_5 = new System.Windows.Forms.Label();
      this.lbl_Amount = new System.Windows.Forms.Label();
      this.lbl_Amount_Value = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.lbl_Name = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lbl_card_1
      // 
      this.lbl_card_1.AutoSize = true;
      this.lbl_card_1.Location = new System.Drawing.Point(3, 12);
      this.lbl_card_1.Name = "lbl_card_1";
      this.lbl_card_1.Size = new System.Drawing.Size(35, 13);
      this.lbl_card_1.TabIndex = 0;
      this.lbl_card_1.Text = "label1";
      // 
      // lbl_card_2
      // 
      this.lbl_card_2.AutoSize = true;
      this.lbl_card_2.Location = new System.Drawing.Point(44, 12);
      this.lbl_card_2.Name = "lbl_card_2";
      this.lbl_card_2.Size = new System.Drawing.Size(35, 13);
      this.lbl_card_2.TabIndex = 1;
      this.lbl_card_2.Text = "label2";
      this.lbl_card_2.Click += new System.EventHandler(this.label2_Click);
      // 
      // lbl_card_3
      // 
      this.lbl_card_3.AutoSize = true;
      this.lbl_card_3.Location = new System.Drawing.Point(85, 12);
      this.lbl_card_3.Name = "lbl_card_3";
      this.lbl_card_3.Size = new System.Drawing.Size(35, 13);
      this.lbl_card_3.TabIndex = 2;
      this.lbl_card_3.Text = "label3";
      // 
      // lbl_card_4
      // 
      this.lbl_card_4.AutoSize = true;
      this.lbl_card_4.Location = new System.Drawing.Point(126, 12);
      this.lbl_card_4.Name = "lbl_card_4";
      this.lbl_card_4.Size = new System.Drawing.Size(35, 13);
      this.lbl_card_4.TabIndex = 3;
      this.lbl_card_4.Text = "label4";
      // 
      // lbl_card_5
      // 
      this.lbl_card_5.AutoSize = true;
      this.lbl_card_5.Location = new System.Drawing.Point(167, 12);
      this.lbl_card_5.Name = "lbl_card_5";
      this.lbl_card_5.Size = new System.Drawing.Size(35, 13);
      this.lbl_card_5.TabIndex = 4;
      this.lbl_card_5.Text = "label5";
      // 
      // lbl_Amount
      // 
      this.lbl_Amount.AutoSize = true;
      this.lbl_Amount.Location = new System.Drawing.Point(3, 43);
      this.lbl_Amount.Name = "lbl_Amount";
      this.lbl_Amount.Size = new System.Drawing.Size(43, 13);
      this.lbl_Amount.TabIndex = 5;
      this.lbl_Amount.Text = "Amount";
      // 
      // lbl_Amount_Value
      // 
      this.lbl_Amount_Value.AutoSize = true;
      this.lbl_Amount_Value.Location = new System.Drawing.Point(69, 43);
      this.lbl_Amount_Value.Name = "lbl_Amount_Value";
      this.lbl_Amount_Value.Size = new System.Drawing.Size(22, 13);
      this.lbl_Amount_Value.TabIndex = 6;
      this.lbl_Amount_Value.Text = "0.0";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 60);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(35, 13);
      this.label6.TabIndex = 7;
      this.label6.Text = "Name";
      // 
      // lbl_Name
      // 
      this.lbl_Name.AutoSize = true;
      this.lbl_Name.Location = new System.Drawing.Point(69, 60);
      this.lbl_Name.Name = "lbl_Name";
      this.lbl_Name.Size = new System.Drawing.Size(35, 13);
      this.lbl_Name.TabIndex = 8;
      this.lbl_Name.Text = "label7";
      // 
      // CtrlPlayers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lbl_Name);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.lbl_Amount_Value);
      this.Controls.Add(this.lbl_Amount);
      this.Controls.Add(this.lbl_card_5);
      this.Controls.Add(this.lbl_card_4);
      this.Controls.Add(this.lbl_card_3);
      this.Controls.Add(this.lbl_card_2);
      this.Controls.Add(this.lbl_card_1);
      this.Name = "CtrlPlayers";
      this.Size = new System.Drawing.Size(213, 97);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_card_1;
    private System.Windows.Forms.Label lbl_card_2;
    private System.Windows.Forms.Label lbl_card_3;
    private System.Windows.Forms.Label lbl_card_4;
    private System.Windows.Forms.Label lbl_card_5;
    private System.Windows.Forms.Label lbl_Amount;
    private System.Windows.Forms.Label lbl_Amount_Value;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lbl_Name;
  }
}
