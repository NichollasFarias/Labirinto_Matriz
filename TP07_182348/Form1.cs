using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP07_182348
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        #region Variavel Global

        static string[,] Lab = new string[24, 36]
            {
            {   "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    },
            {   "1",    "1",    "1",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "1",    },
            {   "1",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    },
            {   "1",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "0",    "0",    "0",    "0",    "0",    "1",    "0",    "1",    "1",    "0",    "0",    "0",    "1",    "0",    "1",    "1",    "0",    "0",    "0",    "0",    "0",    "1",    "0",    "1",    "1",    },
            {   "1",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "0",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "0",    "1",    "1",    "1",    "0",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "0",    "1",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "0",    "1",    "0",    "0",    "0",    "0",    "0",    "1",    "1",    "0",    "0",    "0",    "0",    "0",    "1",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    },
            {   "1",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    },
            {   "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    "0",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    },
            {   "0",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "0",    "1",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "1",    "0",    "1",    "0",    "0",    "0",    "0",    "0",    "1",    "1",    },
            {   "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "0",    "1",    "1",    },
            {   "1",    "1",    "0",    "0",    "0",    "1",    "0",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    },
            {   "1",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    },
            {   "1",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "0",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "0",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "0",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "1",    "1",    "0",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "0",    "0",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "1",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "0",    "1",    "0",    "1",    "0",    "1",    "1",    "1",    "1",    },
            {   "1",    "1",    "0",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "1",    "0",    "1",    "1",    "1",    "1",    },

            };
        int posLinha = 0, posColuna = 35;
        string controle;

        #endregion

        #region movimentação
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pb_player.Location.X;
            int y = pb_player.Location.Y;

            if ((x == 798) && (y == 483))
            {
                timer1.Stop();
                MessageBox.Show("Você Ganhou", "Fim de Jogo");
                //Reiniciar();
            }
            else if (controle == "A")
            {
                pb_player.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Esquerda.png");
                pb_player.Size = new Size(37, 48);

                if (posColuna == 0)
                {
                    return;
                }
                if (Lab[posLinha, posColuna - 1] == "1")
                {
                    pb_player.Location = new Point(x - 20, y);
                    posColuna--;
                }
            }
            else if (controle == "D")
            {
                pb_player.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Direita.png");
                pb_player.Size = new Size(37, 48);

                if (posColuna == 35)
                {
                    return;
                }
                if (Lab[posLinha, posColuna + 1] == "1")
                {
                    pb_player.Location = new Point(x + 20, y);
                    posColuna++;
                }
            }
            else if (controle == "S")
            {
                pb_player.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Frente.png");
                pb_player.Size = new Size(37, 48);

                if (posLinha == 23)
                {
                    return;
                }
                if (Lab[posLinha + 1, posColuna] == "1")
                {
                    pb_player.Location = new Point(x, y + 20);
                    posLinha++;
                }
            }
            else if (controle == "W")
            {
                pb_player.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Frente.png");
                pb_player.Size = new Size(37, 48);

                if (posLinha == 0)
                {
                    return;
                }
                if (Lab[posLinha - 1, posColuna] == "1")
                {
                    pb_player.Location = new Point(x, y - 20);
                    posLinha--;
                }
            }
            timer1.Stop();
        }
        #endregion

        #region Teclas
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().ToUpper() == "W" || e.KeyChar.ToString().ToUpper() == "S" || e.KeyChar.ToString().ToUpper() == "A" || e.KeyChar.ToString().ToUpper() == "D")
            {
                controle = e.KeyChar.ToString().ToUpper();
                timer1.Start();
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }


        #endregion

        //#region Reniciar
        //public void Reiniciar()
        //{
        //    if (MessageBox.Show("Você gostaria de jogar novamente?", "Reiniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        //    {
              
        //    }

        //}
        //#endregion

        #region Sair
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você gostaria de fechar?", "Deseja Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Tempo
        private void Tempo_Tick(object sender, EventArgs e)
        {
            int segundos = 10;
            LblTempo.Text = segundos.ToString();
            segundos--;
        }
        #endregion
    }
}





