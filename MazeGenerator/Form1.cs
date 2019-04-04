using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGenerator
{
    public partial class MazeGeneratorForm : Form
    {
        Maze maze;
        int buttonWidth, buttonHeight;

        public MazeGeneratorForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int mazeWidth = int.Parse(widthText.Text);
            int mazeHeight = int.Parse(heightText.Text);

            buttonWidth = mazePanel.Width / mazeWidth;
            buttonHeight = mazePanel.Height / mazeHeight;

            maze = new Maze(mazeWidth, mazeHeight);

            for (int i = 0; i < mazeWidth; i++)
            {
                for (int j = 0; j < mazeHeight; j++)
                {
                    Button mazeButton = new Button();
                    mazeButton.Width = buttonWidth;
                    mazeButton.Height = buttonHeight;

                    mazeButton.Location = new Point(i * buttonWidth, j * buttonHeight);
                    mazeButton.Text = "0";
                    mazeButton.BackColor = Color.White;

                    // 핸들러 장착
                    mazeButton.MouseDown += new MouseEventHandler(button_MouseDown);

                    //This will work and add button to your Form.
                    mazePanel.Controls.Add(mazeButton);

                    maze.maze[i, j] = 0;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            maze.SaveToFile();
            MessageBox.Show("저장이 완료되었습니다.");
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            // identify which button was clicked and perform necessary actions
            Button button = sender as Button;

            int mazeX = button.Location.X / buttonWidth;
            int mazeY = button.Location.Y / buttonHeight;

            // 왼쪽 버튼 클릭
            if (e.Button == MouseButtons.Left)
            {
                if (button.Text == "0")
                {
                    button.BackColor = Color.Black;
                    maze.maze[mazeX, mazeY] = 1;
                }
                else if (button.Text == "1")
                {
                    button.BackColor = Color.Red;
                    maze.maze[mazeX, mazeY] = 2;
                }
                else
                {
                    button.BackColor = Color.White;
                    maze.maze[mazeX, mazeY] = 0;
                }
                button.Text = maze.maze[mazeX, mazeY].ToString();
            }
            // 오른쪽 버튼 클릭
            else
            {
                button.BackColor = Color.OrangeRed;
                maze.maze[mazeX, mazeY] = -2;
                button.Text = maze.maze[mazeX, mazeY].ToString();
            }
        }
    }
}
