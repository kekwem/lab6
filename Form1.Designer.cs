
namespace lab6
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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doublesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.int1Double1StringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doublesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.int1Double1StringToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.osobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.integersAndDoublesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integersAndDoublesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.osobyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(40, 41);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(576, 22);
            this.pathTextBox.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(40, 96);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(576, 281);
            this.textBox.TabIndex = 1;
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(663, 39);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(75, 23);
            this.pathButton.TabIndex = 2;
            this.pathButton.Text = "Path";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToolStripMenuItem,
            this.readToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integersToolStripMenuItem,
            this.doublesToolStripMenuItem,
            this.int1Double1StringToolStripMenuItem,
            this.osobaToolStripMenuItem,
            this.integersAndDoublesToolStripMenuItem,
            this.osobyToolStripMenuItem});
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.writeToolStripMenuItem.Text = "Write";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integersToolStripMenuItem1,
            this.doublesToolStripMenuItem1,
            this.int1Double1StringToolStripMenuItem1,
            this.osobaToolStripMenuItem1,
            this.integersAndDoublesToolStripMenuItem1,
            this.osobyToolStripMenuItem1});
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // integersToolStripMenuItem
            // 
            this.integersToolStripMenuItem.Name = "integersToolStripMenuItem";
            this.integersToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.integersToolStripMenuItem.Text = "Integers";
            this.integersToolStripMenuItem.Click += new System.EventHandler(this.integersToolStripMenuItem_Click);
            // 
            // doublesToolStripMenuItem
            // 
            this.doublesToolStripMenuItem.Name = "doublesToolStripMenuItem";
            this.doublesToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.doublesToolStripMenuItem.Text = "Doubles";
            this.doublesToolStripMenuItem.Click += new System.EventHandler(this.doublesToolStripMenuItem_Click);
            // 
            // int1Double1StringToolStripMenuItem
            // 
            this.int1Double1StringToolStripMenuItem.Name = "int1Double1StringToolStripMenuItem";
            this.int1Double1StringToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.int1Double1StringToolStripMenuItem.Text = "1 Int, 1 Double, 1 String";
            this.int1Double1StringToolStripMenuItem.Click += new System.EventHandler(this.int1Double1StringToolStripMenuItem_Click);
            // 
            // integersToolStripMenuItem1
            // 
            this.integersToolStripMenuItem1.Name = "integersToolStripMenuItem1";
            this.integersToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.integersToolStripMenuItem1.Text = "Integers";
            this.integersToolStripMenuItem1.Click += new System.EventHandler(this.integersToolStripMenuItem1_Click);
            // 
            // doublesToolStripMenuItem1
            // 
            this.doublesToolStripMenuItem1.Name = "doublesToolStripMenuItem1";
            this.doublesToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.doublesToolStripMenuItem1.Text = "Doubles";
            this.doublesToolStripMenuItem1.Click += new System.EventHandler(this.doublesToolStripMenuItem1_Click);
            // 
            // int1Double1StringToolStripMenuItem1
            // 
            this.int1Double1StringToolStripMenuItem1.Name = "int1Double1StringToolStripMenuItem1";
            this.int1Double1StringToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.int1Double1StringToolStripMenuItem1.Text = "1 Int, 1 Double, 1 String";
            this.int1Double1StringToolStripMenuItem1.Click += new System.EventHandler(this.int1Double1StringToolStripMenuItem1_Click);
            // 
            // osobaToolStripMenuItem
            // 
            this.osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            this.osobaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.osobaToolStripMenuItem.Text = "Osoba";
            this.osobaToolStripMenuItem.Click += new System.EventHandler(this.osobaToolStripMenuItem_Click);
            // 
            // osobaToolStripMenuItem1
            // 
            this.osobaToolStripMenuItem1.Name = "osobaToolStripMenuItem1";
            this.osobaToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.osobaToolStripMenuItem1.Text = "Osoba";
            this.osobaToolStripMenuItem1.Click += new System.EventHandler(this.osobaToolStripMenuItem1_Click);
            // 
            // integersAndDoublesToolStripMenuItem
            // 
            this.integersAndDoublesToolStripMenuItem.Name = "integersAndDoublesToolStripMenuItem";
            this.integersAndDoublesToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.integersAndDoublesToolStripMenuItem.Text = "Integers and Doubles";
            this.integersAndDoublesToolStripMenuItem.Click += new System.EventHandler(this.integersAndDoublesToolStripMenuItem_Click);
            // 
            // integersAndDoublesToolStripMenuItem1
            // 
            this.integersAndDoublesToolStripMenuItem1.Name = "integersAndDoublesToolStripMenuItem1";
            this.integersAndDoublesToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.integersAndDoublesToolStripMenuItem1.Text = "Integers and Doubles";
            this.integersAndDoublesToolStripMenuItem1.Click += new System.EventHandler(this.integersAndDoublesToolStripMenuItem1_Click);
            // 
            // osobyToolStripMenuItem
            // 
            this.osobyToolStripMenuItem.Name = "osobyToolStripMenuItem";
            this.osobyToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.osobyToolStripMenuItem.Text = "Osoby";
            this.osobyToolStripMenuItem.Click += new System.EventHandler(this.osobyToolStripMenuItem_Click);
            // 
            // osobyToolStripMenuItem1
            // 
            this.osobyToolStripMenuItem1.Name = "osobyToolStripMenuItem1";
            this.osobyToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.osobyToolStripMenuItem1.Text = "Osoby";
            this.osobyToolStripMenuItem1.Click += new System.EventHandler(this.osobyToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notatnik binarny";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doublesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem int1Double1StringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doublesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem int1Double1StringToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem integersAndDoublesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integersAndDoublesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem osobyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobyToolStripMenuItem1;
    }
}

