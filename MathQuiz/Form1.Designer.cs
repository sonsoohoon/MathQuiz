namespace MathQuiz
{
    partial class MathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlusLeftLabel = new System.Windows.Forms.Label();
            this.Plus = new System.Windows.Forms.Label();
            this.PlusRightLabel = new System.Windows.Forms.Label();
            this.PlusEquel = new System.Windows.Forms.Label();
            this.PlusResult = new System.Windows.Forms.NumericUpDown();
            this.MinusResult = new System.Windows.Forms.NumericUpDown();
            this.MinusEquel = new System.Windows.Forms.Label();
            this.MinusRightLabel = new System.Windows.Forms.Label();
            this.Minus = new System.Windows.Forms.Label();
            this.MinusLeftLabel = new System.Windows.Forms.Label();
            this.ProductResult = new System.Windows.Forms.NumericUpDown();
            this.ProductEquel = new System.Windows.Forms.Label();
            this.ProductRightLabel = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.Label();
            this.ProductLeftLabel = new System.Windows.Forms.Label();
            this.DivideResult = new System.Windows.Forms.NumericUpDown();
            this.DivideEquel = new System.Windows.Forms.Label();
            this.DivideRightLabel = new System.Windows.Forms.Label();
            this.Divide = new System.Windows.Forms.Label();
            this.DivideLeftLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlusResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivideResult)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Gulim", 15.75F);
            this.timeLabel.Location = new System.Drawing.Point(150, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "남은 시간";
            // 
            // PlusLeftLabel
            // 
            this.PlusLeftLabel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlusLeftLabel.Location = new System.Drawing.Point(4, 56);
            this.PlusLeftLabel.Name = "PlusLeftLabel";
            this.PlusLeftLabel.Size = new System.Drawing.Size(50, 30);
            this.PlusLeftLabel.TabIndex = 2;
            this.PlusLeftLabel.Text = "?";
            this.PlusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Plus.Location = new System.Drawing.Point(61, 56);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(50, 30);
            this.Plus.TabIndex = 3;
            this.Plus.Text = "+";
            this.Plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlusRightLabel
            // 
            this.PlusRightLabel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlusRightLabel.Location = new System.Drawing.Point(135, 56);
            this.PlusRightLabel.Name = "PlusRightLabel";
            this.PlusRightLabel.Size = new System.Drawing.Size(50, 30);
            this.PlusRightLabel.TabIndex = 4;
            this.PlusRightLabel.Text = "?";
            this.PlusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlusEquel
            // 
            this.PlusEquel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlusEquel.Location = new System.Drawing.Point(194, 56);
            this.PlusEquel.Name = "PlusEquel";
            this.PlusEquel.Size = new System.Drawing.Size(50, 30);
            this.PlusEquel.TabIndex = 5;
            this.PlusEquel.Text = "=";
            this.PlusEquel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlusResult
            // 
            this.PlusResult.Location = new System.Drawing.Point(260, 61);
            this.PlusResult.Name = "PlusResult";
            this.PlusResult.Size = new System.Drawing.Size(120, 25);
            this.PlusResult.TabIndex = 1;
            this.PlusResult.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // MinusResult
            // 
            this.MinusResult.Location = new System.Drawing.Point(260, 108);
            this.MinusResult.Name = "MinusResult";
            this.MinusResult.Size = new System.Drawing.Size(120, 25);
            this.MinusResult.TabIndex = 2;
            this.MinusResult.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // MinusEquel
            // 
            this.MinusEquel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinusEquel.Location = new System.Drawing.Point(194, 105);
            this.MinusEquel.Name = "MinusEquel";
            this.MinusEquel.Size = new System.Drawing.Size(50, 30);
            this.MinusEquel.TabIndex = 10;
            this.MinusEquel.Text = "=";
            this.MinusEquel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinusRightLabel
            // 
            this.MinusRightLabel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinusRightLabel.Location = new System.Drawing.Point(135, 105);
            this.MinusRightLabel.Name = "MinusRightLabel";
            this.MinusRightLabel.Size = new System.Drawing.Size(50, 30);
            this.MinusRightLabel.TabIndex = 9;
            this.MinusRightLabel.Text = "?";
            this.MinusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minus.Location = new System.Drawing.Point(61, 105);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(50, 30);
            this.Minus.TabIndex = 8;
            this.Minus.Text = "-";
            this.Minus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinusLeftLabel
            // 
            this.MinusLeftLabel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinusLeftLabel.Location = new System.Drawing.Point(4, 105);
            this.MinusLeftLabel.Name = "MinusLeftLabel";
            this.MinusLeftLabel.Size = new System.Drawing.Size(50, 30);
            this.MinusLeftLabel.TabIndex = 7;
            this.MinusLeftLabel.Text = "?";
            this.MinusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductResult
            // 
            this.ProductResult.Location = new System.Drawing.Point(260, 150);
            this.ProductResult.Name = "ProductResult";
            this.ProductResult.Size = new System.Drawing.Size(120, 25);
            this.ProductResult.TabIndex = 3;
            this.ProductResult.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // ProductEquel
            // 
            this.ProductEquel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductEquel.Location = new System.Drawing.Point(194, 143);
            this.ProductEquel.Name = "ProductEquel";
            this.ProductEquel.Size = new System.Drawing.Size(50, 30);
            this.ProductEquel.TabIndex = 15;
            this.ProductEquel.Text = "=";
            this.ProductEquel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductRightLabel
            // 
            this.ProductRightLabel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductRightLabel.Location = new System.Drawing.Point(135, 143);
            this.ProductRightLabel.Name = "ProductRightLabel";
            this.ProductRightLabel.Size = new System.Drawing.Size(50, 30);
            this.ProductRightLabel.TabIndex = 14;
            this.ProductRightLabel.Text = "?";
            this.ProductRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Product.Location = new System.Drawing.Point(61, 143);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(50, 30);
            this.Product.TabIndex = 13;
            this.Product.Text = "×";
            this.Product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductLeftLabel
            // 
            this.ProductLeftLabel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductLeftLabel.Location = new System.Drawing.Point(4, 143);
            this.ProductLeftLabel.Name = "ProductLeftLabel";
            this.ProductLeftLabel.Size = new System.Drawing.Size(50, 30);
            this.ProductLeftLabel.TabIndex = 12;
            this.ProductLeftLabel.Text = "?";
            this.ProductLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivideResult
            // 
            this.DivideResult.Location = new System.Drawing.Point(260, 189);
            this.DivideResult.Name = "DivideResult";
            this.DivideResult.Size = new System.Drawing.Size(120, 25);
            this.DivideResult.TabIndex = 4;
            // 
            // DivideEquel
            // 
            this.DivideEquel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DivideEquel.Location = new System.Drawing.Point(194, 189);
            this.DivideEquel.Name = "DivideEquel";
            this.DivideEquel.Size = new System.Drawing.Size(50, 30);
            this.DivideEquel.TabIndex = 20;
            this.DivideEquel.Text = "=";
            this.DivideEquel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivideRightLabel
            // 
            this.DivideRightLabel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DivideRightLabel.Location = new System.Drawing.Point(135, 189);
            this.DivideRightLabel.Name = "DivideRightLabel";
            this.DivideRightLabel.Size = new System.Drawing.Size(50, 30);
            this.DivideRightLabel.TabIndex = 19;
            this.DivideRightLabel.Text = "?";
            this.DivideRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Divide.Location = new System.Drawing.Point(61, 189);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 30);
            this.Divide.TabIndex = 18;
            this.Divide.Text = "+";
            this.Divide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivideLeftLabel
            // 
            this.DivideLeftLabel.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DivideLeftLabel.Location = new System.Drawing.Point(4, 189);
            this.DivideLeftLabel.Name = "DivideLeftLabel";
            this.DivideLeftLabel.Size = new System.Drawing.Size(50, 30);
            this.DivideLeftLabel.TabIndex = 17;
            this.DivideLeftLabel.Text = "?";
            this.DivideLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.Font = new System.Drawing.Font("Gulim", 14F);
            this.StartButton.Location = new System.Drawing.Point(95, 236);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(183, 29);
            this.StartButton.TabIndex = 22;
            this.StartButton.Text = "퀴즈를 시작하세요!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 346);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DivideResult);
            this.Controls.Add(this.DivideEquel);
            this.Controls.Add(this.DivideRightLabel);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.DivideLeftLabel);
            this.Controls.Add(this.ProductResult);
            this.Controls.Add(this.ProductEquel);
            this.Controls.Add(this.ProductRightLabel);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.ProductLeftLabel);
            this.Controls.Add(this.MinusResult);
            this.Controls.Add(this.MinusEquel);
            this.Controls.Add(this.MinusRightLabel);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.MinusLeftLabel);
            this.Controls.Add(this.PlusResult);
            this.Controls.Add(this.PlusEquel);
            this.Controls.Add(this.PlusRightLabel);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.PlusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MathQuiz";
            this.Text = "MathQuiz";
            ((System.ComponentModel.ISupportInitialize)(this.PlusResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivideResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlusLeftLabel;
        private System.Windows.Forms.Label Plus;
        private System.Windows.Forms.Label PlusRightLabel;
        private System.Windows.Forms.Label PlusEquel;
        private System.Windows.Forms.NumericUpDown PlusResult;
        private System.Windows.Forms.NumericUpDown MinusResult;
        private System.Windows.Forms.Label MinusEquel;
        private System.Windows.Forms.Label MinusRightLabel;
        private System.Windows.Forms.Label Minus;
        private System.Windows.Forms.Label MinusLeftLabel;
        private System.Windows.Forms.NumericUpDown ProductResult;
        private System.Windows.Forms.Label ProductEquel;
        private System.Windows.Forms.Label ProductRightLabel;
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Label ProductLeftLabel;
        private System.Windows.Forms.NumericUpDown DivideResult;
        private System.Windows.Forms.Label DivideEquel;
        private System.Windows.Forms.Label DivideRightLabel;
        private System.Windows.Forms.Label Divide;
        private System.Windows.Forms.Label DivideLeftLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer timer1;
    }
}

