namespace PokerMain
{
  partial class Form1
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
      this.txt_Decks = new System.Windows.Forms.TextBox();
      this.lbl_Players = new System.Windows.Forms.Label();
      this.txt_Players = new System.Windows.Forms.TextBox();
      this.btn_Shuffle = new System.Windows.Forms.Button();
      this.pnl_Player1 = new System.Windows.Forms.Panel();
      this.txt_AmountBet_Player1 = new System.Windows.Forms.TextBox();
      this.txt_Amount_Player1 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.lbl_Raise_Amt = new System.Windows.Forms.Label();
      this.chk_Player1 = new System.Windows.Forms.CheckedListBox();
      this.btn_Discard = new System.Windows.Forms.Button();
      this.btn_Call = new System.Windows.Forms.Button();
      this.btn_Fold = new System.Windows.Forms.Button();
      this.btn_Check = new System.Windows.Forms.Button();
      this.btn_Raise = new System.Windows.Forms.Button();
      this.pnl_Player2 = new System.Windows.Forms.Panel();
      this.txt_AmountBet_Player2 = new System.Windows.Forms.TextBox();
      this.txt_Amount_Player2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.chk_Player2 = new System.Windows.Forms.CheckedListBox();
      this.pnl_Player3 = new System.Windows.Forms.Panel();
      this.txt_AmountBet_Player3 = new System.Windows.Forms.TextBox();
      this.txt_Amount_Player3 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.chk_Player3 = new System.Windows.Forms.CheckedListBox();
      this.btn_StartGame = new System.Windows.Forms.Button();
      this.pnl_Player1.SuspendLayout();
      this.pnl_Player2.SuspendLayout();
      this.pnl_Player3.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(27, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "No of Decks";
      // 
      // txt_Decks
      // 
      this.txt_Decks.Location = new System.Drawing.Point(135, 22);
      this.txt_Decks.Name = "txt_Decks";
      this.txt_Decks.Size = new System.Drawing.Size(100, 20);
      this.txt_Decks.TabIndex = 1;
      // 
      // lbl_Players
      // 
      this.lbl_Players.AutoSize = true;
      this.lbl_Players.Location = new System.Drawing.Point(30, 53);
      this.lbl_Players.Name = "lbl_Players";
      this.lbl_Players.Size = new System.Drawing.Size(70, 13);
      this.lbl_Players.TabIndex = 2;
      this.lbl_Players.Text = "No of Players";
      // 
      // txt_Players
      // 
      this.txt_Players.Location = new System.Drawing.Point(135, 53);
      this.txt_Players.Name = "txt_Players";
      this.txt_Players.ReadOnly = true;
      this.txt_Players.Size = new System.Drawing.Size(100, 20);
      this.txt_Players.TabIndex = 3;
      this.txt_Players.Text = "3";
      // 
      // btn_Shuffle
      // 
      this.btn_Shuffle.Location = new System.Drawing.Point(250, 53);
      this.btn_Shuffle.Name = "btn_Shuffle";
      this.btn_Shuffle.Size = new System.Drawing.Size(95, 23);
      this.btn_Shuffle.TabIndex = 4;
      this.btn_Shuffle.Text = "Shuffle and Deal";
      this.btn_Shuffle.UseVisualStyleBackColor = true;
      this.btn_Shuffle.Click += new System.EventHandler(this.btn_Shuffle_Click);
      // 
      // pnl_Player1
      // 
      this.pnl_Player1.Controls.Add(this.txt_AmountBet_Player1);
      this.pnl_Player1.Controls.Add(this.txt_Amount_Player1);
      this.pnl_Player1.Controls.Add(this.label3);
      this.pnl_Player1.Controls.Add(this.lbl_Raise_Amt);
      this.pnl_Player1.Controls.Add(this.chk_Player1);
      this.pnl_Player1.Location = new System.Drawing.Point(33, 91);
      this.pnl_Player1.Name = "pnl_Player1";
      this.pnl_Player1.Size = new System.Drawing.Size(202, 190);
      this.pnl_Player1.TabIndex = 7;
      // 
      // txt_AmountBet_Player1
      // 
      this.txt_AmountBet_Player1.Location = new System.Drawing.Point(85, 153);
      this.txt_AmountBet_Player1.Name = "txt_AmountBet_Player1";
      this.txt_AmountBet_Player1.Size = new System.Drawing.Size(100, 20);
      this.txt_AmountBet_Player1.TabIndex = 8;
      // 
      // txt_Amount_Player1
      // 
      this.txt_Amount_Player1.Location = new System.Drawing.Point(85, 122);
      this.txt_Amount_Player1.Name = "txt_Amount_Player1";
      this.txt_Amount_Player1.ReadOnly = true;
      this.txt_Amount_Player1.Size = new System.Drawing.Size(100, 20);
      this.txt_Amount_Player1.TabIndex = 7;
      this.txt_Amount_Player1.Text = "100";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 125);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(43, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Amount";
      // 
      // lbl_Raise_Amt
      // 
      this.lbl_Raise_Amt.AutoSize = true;
      this.lbl_Raise_Amt.Location = new System.Drawing.Point(13, 156);
      this.lbl_Raise_Amt.Name = "lbl_Raise_Amt";
      this.lbl_Raise_Amt.Size = new System.Drawing.Size(73, 13);
      this.lbl_Raise_Amt.TabIndex = 5;
      this.lbl_Raise_Amt.Text = "Raise Amount";
      // 
      // chk_Player1
      // 
      this.chk_Player1.FormattingEnabled = true;
      this.chk_Player1.Location = new System.Drawing.Point(15, 3);
      this.chk_Player1.Name = "chk_Player1";
      this.chk_Player1.Size = new System.Drawing.Size(117, 94);
      this.chk_Player1.TabIndex = 0;
      // 
      // btn_Discard
      // 
      this.btn_Discard.Enabled = false;
      this.btn_Discard.Location = new System.Drawing.Point(753, 110);
      this.btn_Discard.Name = "btn_Discard";
      this.btn_Discard.Size = new System.Drawing.Size(75, 23);
      this.btn_Discard.TabIndex = 1;
      this.btn_Discard.Text = "Discard";
      this.btn_Discard.UseVisualStyleBackColor = true;
      // 
      // btn_Call
      // 
      this.btn_Call.Enabled = false;
      this.btn_Call.Location = new System.Drawing.Point(753, 139);
      this.btn_Call.Name = "btn_Call";
      this.btn_Call.Size = new System.Drawing.Size(75, 23);
      this.btn_Call.TabIndex = 2;
      this.btn_Call.Text = "Call";
      this.btn_Call.UseVisualStyleBackColor = true;
      // 
      // btn_Fold
      // 
      this.btn_Fold.Enabled = false;
      this.btn_Fold.Location = new System.Drawing.Point(753, 168);
      this.btn_Fold.Name = "btn_Fold";
      this.btn_Fold.Size = new System.Drawing.Size(75, 23);
      this.btn_Fold.TabIndex = 3;
      this.btn_Fold.Text = "Fold";
      this.btn_Fold.UseVisualStyleBackColor = true;
      // 
      // btn_Check
      // 
      this.btn_Check.Enabled = false;
      this.btn_Check.Location = new System.Drawing.Point(753, 197);
      this.btn_Check.Name = "btn_Check";
      this.btn_Check.Size = new System.Drawing.Size(75, 23);
      this.btn_Check.TabIndex = 4;
      this.btn_Check.Text = "Check";
      this.btn_Check.UseVisualStyleBackColor = true;
      // 
      // btn_Raise
      // 
      this.btn_Raise.Enabled = false;
      this.btn_Raise.Location = new System.Drawing.Point(753, 226);
      this.btn_Raise.Name = "btn_Raise";
      this.btn_Raise.Size = new System.Drawing.Size(75, 23);
      this.btn_Raise.TabIndex = 9;
      this.btn_Raise.Text = "Raise";
      this.btn_Raise.UseVisualStyleBackColor = true;
      // 
      // pnl_Player2
      // 
      this.pnl_Player2.Controls.Add(this.txt_AmountBet_Player2);
      this.pnl_Player2.Controls.Add(this.txt_Amount_Player2);
      this.pnl_Player2.Controls.Add(this.label2);
      this.pnl_Player2.Controls.Add(this.label4);
      this.pnl_Player2.Controls.Add(this.chk_Player2);
      this.pnl_Player2.Location = new System.Drawing.Point(260, 91);
      this.pnl_Player2.Name = "pnl_Player2";
      this.pnl_Player2.Size = new System.Drawing.Size(202, 190);
      this.pnl_Player2.TabIndex = 8;
      // 
      // txt_AmountBet_Player2
      // 
      this.txt_AmountBet_Player2.Location = new System.Drawing.Point(84, 153);
      this.txt_AmountBet_Player2.Name = "txt_AmountBet_Player2";
      this.txt_AmountBet_Player2.Size = new System.Drawing.Size(100, 20);
      this.txt_AmountBet_Player2.TabIndex = 8;
      // 
      // txt_Amount_Player2
      // 
      this.txt_Amount_Player2.Location = new System.Drawing.Point(84, 122);
      this.txt_Amount_Player2.Name = "txt_Amount_Player2";
      this.txt_Amount_Player2.ReadOnly = true;
      this.txt_Amount_Player2.Size = new System.Drawing.Size(100, 20);
      this.txt_Amount_Player2.TabIndex = 7;
      this.txt_Amount_Player2.Text = "100";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 125);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Amount";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 156);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(73, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Raise Amount";
      // 
      // chk_Player2
      // 
      this.chk_Player2.FormattingEnabled = true;
      this.chk_Player2.Location = new System.Drawing.Point(15, 3);
      this.chk_Player2.Name = "chk_Player2";
      this.chk_Player2.Size = new System.Drawing.Size(117, 94);
      this.chk_Player2.TabIndex = 0;
      // 
      // pnl_Player3
      // 
      this.pnl_Player3.Controls.Add(this.txt_AmountBet_Player3);
      this.pnl_Player3.Controls.Add(this.txt_Amount_Player3);
      this.pnl_Player3.Controls.Add(this.label5);
      this.pnl_Player3.Controls.Add(this.label6);
      this.pnl_Player3.Controls.Add(this.chk_Player3);
      this.pnl_Player3.Location = new System.Drawing.Point(478, 91);
      this.pnl_Player3.Name = "pnl_Player3";
      this.pnl_Player3.Size = new System.Drawing.Size(202, 190);
      this.pnl_Player3.TabIndex = 10;
      // 
      // txt_AmountBet_Player3
      // 
      this.txt_AmountBet_Player3.Location = new System.Drawing.Point(88, 156);
      this.txt_AmountBet_Player3.Name = "txt_AmountBet_Player3";
      this.txt_AmountBet_Player3.Size = new System.Drawing.Size(100, 20);
      this.txt_AmountBet_Player3.TabIndex = 8;
      // 
      // txt_Amount_Player3
      // 
      this.txt_Amount_Player3.Location = new System.Drawing.Point(88, 125);
      this.txt_Amount_Player3.Name = "txt_Amount_Player3";
      this.txt_Amount_Player3.ReadOnly = true;
      this.txt_Amount_Player3.Size = new System.Drawing.Size(100, 20);
      this.txt_Amount_Player3.TabIndex = 7;
      this.txt_Amount_Player3.Text = "100";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(16, 128);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(43, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Amount";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(16, 159);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(73, 13);
      this.label6.TabIndex = 5;
      this.label6.Text = "Raise Amount";
      // 
      // chk_Player3
      // 
      this.chk_Player3.FormattingEnabled = true;
      this.chk_Player3.Location = new System.Drawing.Point(15, 3);
      this.chk_Player3.Name = "chk_Player3";
      this.chk_Player3.Size = new System.Drawing.Size(117, 94);
      this.chk_Player3.TabIndex = 0;
      // 
      // btn_StartGame
      // 
      this.btn_StartGame.Location = new System.Drawing.Point(369, 53);
      this.btn_StartGame.Name = "btn_StartGame";
      this.btn_StartGame.Size = new System.Drawing.Size(75, 23);
      this.btn_StartGame.TabIndex = 11;
      this.btn_StartGame.Text = "Start Game";
      this.btn_StartGame.UseVisualStyleBackColor = true;
      this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(858, 325);
      this.Controls.Add(this.btn_StartGame);
      this.Controls.Add(this.btn_Raise);
      this.Controls.Add(this.pnl_Player3);
      this.Controls.Add(this.pnl_Player2);
      this.Controls.Add(this.pnl_Player1);
      this.Controls.Add(this.btn_Shuffle);
      this.Controls.Add(this.btn_Check);
      this.Controls.Add(this.txt_Players);
      this.Controls.Add(this.btn_Fold);
      this.Controls.Add(this.lbl_Players);
      this.Controls.Add(this.btn_Call);
      this.Controls.Add(this.txt_Decks);
      this.Controls.Add(this.btn_Discard);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.pnl_Player1.ResumeLayout(false);
      this.pnl_Player1.PerformLayout();
      this.pnl_Player2.ResumeLayout(false);
      this.pnl_Player2.PerformLayout();
      this.pnl_Player3.ResumeLayout(false);
      this.pnl_Player3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txt_Decks;
    private System.Windows.Forms.Label lbl_Players;
    private System.Windows.Forms.TextBox txt_Players;
    private System.Windows.Forms.Button btn_Shuffle;
    private System.Windows.Forms.Panel pnl_Player1;
    private System.Windows.Forms.Button btn_Raise;
    private System.Windows.Forms.TextBox txt_AmountBet_Player1;
    private System.Windows.Forms.TextBox txt_Amount_Player1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lbl_Raise_Amt;
    private System.Windows.Forms.Button btn_Check;
    private System.Windows.Forms.Button btn_Fold;
    private System.Windows.Forms.Button btn_Call;
    private System.Windows.Forms.Button btn_Discard;
    private System.Windows.Forms.CheckedListBox chk_Player1;
    private System.Windows.Forms.Panel pnl_Player2;
    private System.Windows.Forms.TextBox txt_AmountBet_Player2;
    private System.Windows.Forms.TextBox txt_Amount_Player2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckedListBox chk_Player2;
    private System.Windows.Forms.Panel pnl_Player3;
    private System.Windows.Forms.TextBox txt_AmountBet_Player3;
    private System.Windows.Forms.TextBox txt_Amount_Player3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.CheckedListBox chk_Player3;
    private System.Windows.Forms.Button btn_StartGame;
  }
}

