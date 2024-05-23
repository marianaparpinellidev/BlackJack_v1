using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BlackJack_v1
{
    public partial class Form1 : Form
    {
        private List<Image> cardImages;
        private Random rng;
        private int playerPoints;
        private int dealerPoints;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            StyleComponents();
        }

        private void InitializeGame()
        {
            cardImages = new List<Image>
            {
            //Espadas que vão de 01 - 10    11=valete 12=dama 13=rei

                Properties.Resources._01,
                Properties.Resources._02,
                Properties.Resources._03,
                Properties.Resources._04,
                Properties.Resources._05,
                Properties.Resources._06,
                Properties.Resources._07,
                Properties.Resources._08,
                Properties.Resources._09,
                Properties.Resources._10,
                Properties.Resources._11,
                Properties.Resources._12,
                Properties.Resources._13,


            //Copas que vão de 14 - 23    24=valete 25=dama 26=rei

                Properties.Resources._14,
                Properties.Resources._15,
                Properties.Resources._16,
                Properties.Resources._17,
                Properties.Resources._18,
                Properties.Resources._19,
                Properties.Resources._20,
                Properties.Resources._21,
                Properties.Resources._22,
                Properties.Resources._23,
                Properties.Resources._24,
                Properties.Resources._25,
                Properties.Resources._26,

            //Paus que vão de 27 - 36    37=valete 38=dama 39=rei

                Properties.Resources._27,
                Properties.Resources._28,
                Properties.Resources._29,
                Properties.Resources._30,
                Properties.Resources._31,
                Properties.Resources._32,
                Properties.Resources._33,
                Properties.Resources._34,
                Properties.Resources._35,
                Properties.Resources._36,
                Properties.Resources._37,
                Properties.Resources._38,
                Properties.Resources._39,

            //Ouros que vão de 40 - 49    50=valete 51=dama 52=rei

                Properties.Resources._40,
                Properties.Resources._41,
                Properties.Resources._42,
                Properties.Resources._43,
                Properties.Resources._44,
                Properties.Resources._45,
                Properties.Resources._46,
                Properties.Resources._47,
                Properties.Resources._48,
                Properties.Resources._49,
                Properties.Resources._50,
                Properties.Resources._51,
                Properties.Resources._52,
            };

            // Definir Tags para cada imagem
            string[] cardNames = new string[]
            {
                "_01", "_02", "_03", "_04", "_05", "_06", "_07", "_08", "_09", "_10", "_11", "_12", "_13",
                "_14", "_15", "_16", "_17", "_18", "_19", "_20", "_21", "_22", "_23", "_24", "_25", "_26",
                "_27", "_28", "_29", "_30", "_31", "_32", "_33", "_34", "_35", "_36", "_37", "_38", "_39",
                "_40", "_41", "_42", "_43", "_44", "_45", "_46", "_47", "_48", "_49", "_50", "_51", "_52"
            };

            for (int i = 0; i < cardImages.Count; i++)
            {
                cardImages[i].Tag = cardNames[i];
            }

            // Aleatorizando
            rng = new Random();
            playerPoints = dealerPoints = 0;
        }

        private void StyleComponents()
        {
            pontos_dealer.Enabled = false;
            pontos_jogador.Enabled = false;
        }

        private void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        //Atualizar os pontos
        private void UpdatePlayerPoints(int playerPoints, TextBox playerPointsBox)
        {
            playerPointsBox.Text = playerPoints.ToString();
        }

        private void UpdateDealerPoints(int dealerPoints, TextBox dealerPointsBox)
        {
            dealerPointsBox.Text = dealerPoints.ToString();
        }

        //Jogador pegar as cartas
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        //Dealer pegar as cartas
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        //trocar as cartas
        private void TrocarCartaJogador(PictureBox pictureBox, ref int player_points, TextBox playerPointsBox)
        {
            Shuffle(cardImages);
            if (cardImages.Count > 0)
            {
                pictureBox.Image = cardImages[0];
                if (CardValueCalculator.CalculateCardPoints(cardImages[0]) == 1 && playerPoints <= 10)
                {
                    playerPoints += 11;
                }
                else
                {
                    playerPoints += CardValueCalculator.CalculateCardPoints(cardImages[0]);
                }
                UpdatePlayerPoints(playerPoints, playerPointsBox);
            }
        }
        
        private void TrocarCartaDealer(PictureBox pictureBox, ref int dealer_points, TextBox dealerPointsBox)
        {
            Shuffle(cardImages);
            if (cardImages.Count <= 0) return;
            pictureBox.Image = cardImages[0];
            if(CardValueCalculator.CalculateCardPoints(cardImages[0]) == 1 && dealerPoints <= 10)
            {
                dealerPoints += 11;
            }
            else
            {
                dealerPoints += CardValueCalculator.CalculateCardPoints(cardImages[0]);
            }
            UpdateDealerPoints(dealerPoints, dealerPointsBox);
        }
        private void novo_jogo_Click(object sender, EventArgs e)
        {
            playerPoints = dealerPoints = 0;
            pontos_jogador.Text = "0";
            pontos_dealer.Text = "0";
            mao_jogador.Image = null;
            mao_dealer.Image = null;
        }

        private void parar_Click_1(object sender, EventArgs e)
        {
            if(playerPoints > dealerPoints)
            {
                MessageBox.Show("Você ganhou!");
                novo_jogo_Click(sender, e);
            }
            else if(playerPoints < dealerPoints)
            {
                MessageBox.Show("Você perdeu!");
                novo_jogo_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Empate!");
                novo_jogo_Click(sender, e);
            }
            novo_jogo_Click(sender, e);
        }

        private void pedir_carta_Click(object sender, EventArgs e)
        {
            TrocarCartaJogador(mao_jogador, ref playerPoints, pontos_jogador);
            TrocarCartaDealer(mao_dealer, ref dealerPoints, pontos_dealer);

            if (playerPoints > 21)
            {
                MessageBox.Show("Você perdeu!");
                novo_jogo_Click(sender, e);
            }
            else if (playerPoints == 21)
            {
                MessageBox.Show("BlackJack! Você ganhou!");
                novo_jogo_Click(sender, e);
            }

            if(dealerPoints > 21)
            {
                MessageBox.Show("Você ganhou o dealer estourou!");
                novo_jogo_Click(sender, e);
            }
            else if (dealerPoints == 21)
            {
                MessageBox.Show("BlackJack! Você perdeu!");
                novo_jogo_Click(sender, e);
            }
            else if(dealerPoints > playerPoints && playerPoints < 21)
            {
                MessageBox.Show("Você perdeu!");
                novo_jogo_Click(sender, e);
            }
            
        }
    }
    //Calculo-Biblioteca de imagens para valores
    public static class CardValueCalculator
    {
        private static readonly Dictionary<string, int> cardValues = new Dictionary<string, int>
        {
            // Espadas
         
               {"_01", 1  },
               {"_02", 2 },
               {"_03", 3 },
               {"_04", 4 },
               {"_05", 5 },
               {"_06", 6 },
               {"_07", 7 },
               {"_08", 8 },
               {"_09", 9 },
               {"_10", 10 },
               {"_11", 10 },
               {"_12", 10 },
               {"_13", 10 },

            // Copas
   
               {"_14", 1 },
               {"_15", 2 },
               {"_16", 3 },
               {"_17", 4 },
               {"_18", 5 },
               {"_19", 6 },
               {"_20", 7 },
               {"_21", 8 },
               {"_22", 9 },
               {"_23", 10 },
               {"_24", 10 },
               {"_25", 10 },
               {"_26", 10 },

            // Paus
   
               {"_27", 1 },
               {"_28", 2 },
               {"_29", 3 },
               {"_30", 4 },
               {"_31", 5 },
               {"_32", 6 },
               {"_33", 7 },
               {"_34", 8 },
               {"_35", 9 },
               {"_36", 10 },
               {"_37", 10 },
               {"_38", 10 },
               {"_39", 10 },

            // Ouros

               {"_40", 1 },
               {"_41", 2 },
               {"_42", 3 },
               {"_43", 4 },
               {"_44", 5 },
               {"_45", 6 },
               {"_46", 7 },
               {"_47", 8 },
               {"_48", 9 },
               {"_49", 10 },
               {"_50", 10 },
               {"_51", 10 },
               {"_52", 10 }


        };
        //Calculo de pontos
        public static int CalculateCardPoints(Image card)
        {
            string cardName = GetCardName(card);
            return cardValues.ContainsKey(cardName) ? cardValues[cardName] : 0;
        }
        //Pegar os valores das cartas usando os nomes
        private static string GetCardName(Image card)
        {
            var propInfo = card.GetType().GetProperty("Tag");
            return propInfo?.GetValue(card, null)?.ToString()?.Replace("Properties.Resources.", "") ?? "";
        }
    }
}
