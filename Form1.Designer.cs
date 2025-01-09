using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        private Button circleButton;
        private Button squareButton;
        private Button rhombButton;
        private Button moveButton;

        private void InitializeComponent()
        {
            this.circleButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.rhombButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(96, 12);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(75, 23);
            this.circleButton.TabIndex = 0;
            this.circleButton.Text = "Коло";
            this.circleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(96, 41);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(75, 23);
            this.squareButton.TabIndex = 1;
            this.squareButton.Text = "Квадрат";
            this.squareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // rhombButton
            // 
            this.rhombButton.Location = new System.Drawing.Point(96, 70);
            this.rhombButton.Name = "rhombButton";
            this.rhombButton.Size = new System.Drawing.Size(75, 23);
            this.rhombButton.TabIndex = 2;
            this.rhombButton.Text = "Ромб";
            this.rhombButton.Click += new System.EventHandler(this.RhombButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(84, 99);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(100, 23);
            this.moveButton.TabIndex = 3;
            this.moveButton.Text = "Вправо";
            this.moveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.rhombButton);
            this.Controls.Add(this.moveButton);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}

