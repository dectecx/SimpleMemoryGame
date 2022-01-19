using MemoryGame.Models.Enum;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame.Forms
{
    public partial class GameForm : Form
    {
        /// <summary>
        /// 此難度需要的牌數量
        /// </summary>
        private int CardPairCount;

        /// <summary>
        /// 未完成組數
        /// </summary>
        private int Undone;

        /// <summary>
        /// 剩餘記憶時間
        /// </summary>
        private int RemainingMemoryTime;

        /// <summary>
        /// 剩餘遊戲時間
        /// </summary>
        private int RemainingGameTime;

        /// <summary>
        /// 第一次點擊
        /// </summary>
        private PictureBox FirstClick;

        /// <summary>
        /// 第二次點擊
        /// </summary>
        private PictureBox SecondClick;

        public GameForm()
        {
            InitializeComponent();
            BaseInit();
            // 初始化所有圖片物件的Click事件(只做一次)
            for (int i = 1; i < 17; i++)
            {
                PictureBox pictureBox = (PictureBox)GamePanel.Controls.Find("pictureBox" + i.ToString(), true)[0];
                pictureBox.Click += new EventHandler(PictureBox_Click);
                pictureBox.Enabled = false;
            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void BaseInit()
        {
            // 基本設定
            CardPairCount = 8;
            Undone = CardPairCount;
            RemainingMemoryTime = 5;
            RemainingGameTime = 60;
            FirstClick = null;
            SecondClick = null;

            // 元件啟動、關閉
            ScoreLabel.Text = "得分：0";
            LastTimeLabel.Text = "";
            MemoryTimer.Enabled = false;
            GamingTimer.Enabled = false;
        }

        /// <summary>
        /// 初始化、重設卡牌
        /// </summary>
        private void Reset()
        {
            BaseInit();
            MemoryTimer.Enabled = true;
            StartBtn.Visible = false;
            RestartBtn.Visible = true;

            // 取得卡池
            Random rnd = new Random();
            Bitmap[] cardPool = CardEnum.GetCards
                                        .OrderBy(x => rnd.Next())
                                        .Take(CardPairCount)
                                        .ToArray();
            // 複製一份
            cardPool = cardPool.Concat(cardPool)
                               .OrderBy(x => rnd.Next())
                               .Take(CardPairCount * 2)
                               .ToArray();

            // 初始化所有圖片物件的圖片(除了Click事件)
            for (int i = 1; i < 17; i++)
            {
                PictureBox pictureBox = (PictureBox)GamePanel.Controls.Find("pictureBox" + i.ToString(), true)[0];
                pictureBox.Image = cardPool[i - 1];
                pictureBox.Tag = cardPool[i - 1];
                pictureBox.Visible = true;
                pictureBox.Enabled = false;
                pictureBox.BorderStyle = BorderStyle.None;
            }
        }

        /// <summary>
        /// 圖片Click事件
        /// </summary>
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Enabled = false;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = (Image)pictureBox.Tag;
            if (FirstClick == null)
            {
                // 記錄第一次點擊
                FirstClick = pictureBox;
                return;
            }
            else
            {
                // 記錄第二次點擊
                SecondClick = pictureBox;
            }

            // 比對是否一樣
            if (FirstClick.Image == SecondClick.Image)
            {
                // 短暫顯示後再隱藏
                MatchTimer.Enabled = true;
            }
            else
            {
                // 短暫顯示後再遮罩
                MaskTimer.Enabled = true;
            }
            // 先暫時鎖定所有圖片，等預覽的圖消失後再繼續遊戲
            LockPictureBox();
        }

        /// <summary>
        /// 短暫顯示圖片後再遮罩
        /// </summary>
        private void MaskTimer_Tick(object sender, EventArgs e)
        {
            MaskTimer.Enabled = false;
            FirstClick.Image = CardEnum.卡牌背面;
            SecondClick.Image = CardEnum.卡牌背面;
            // 解除鎖定
            UnlockPictureBox();
        }

        /// <summary>
        /// 短暫顯示圖片後再隱藏
        /// </summary>
        private void MatchTimer_Tick(object sender, EventArgs e)
        {
            MatchTimer.Enabled = false;
            FirstClick.Visible = false;
            SecondClick.Visible = false;
            Undone--;
            // 解除鎖定
            UnlockPictureBox();
        }

        /// <summary>
        /// 開始
        /// </summary>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// 重新開始
        /// </summary>
        private void RestartBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// 記憶時間結束，遊戲正式開始
        /// </summary>
        private void MemoryTimer_Tick(object sender, EventArgs e)
        {
            RemainingMemoryTime--;
            LastTimeLabel.Text = RemainingMemoryTime.ToString();
            if (RemainingMemoryTime <= 0)
            {
                MemoryTimer.Enabled = false;
                GamingTimer.Enabled = true;
                EnablePictureBox();
                MaskPictureBox();
            }
        }

        /// <summary>
        /// 遊戲中
        /// </summary>
        private void GamingTimer_Tick(object sender, EventArgs e)
        {
            RemainingGameTime--;
            LastTimeLabel.Text = RemainingGameTime.ToString();

            // 當前總分=完成組數*10
            ScoreLabel.Text = "得分：" + ((CardPairCount - Undone) * 10).ToString();

            // 時間到
            if (RemainingGameTime <= 0)
            {
                GameOver();
            }
        }

        /// <summary>
        /// 遊戲結束
        /// </summary>
        private void GameOver()
        {
            GamingTimer.Enabled = false;

            DisablePictureBox();
            CalculateGrades();
        }

        /// <summary>
        /// 計算分數
        /// </summary>
        private void CalculateGrades()
        {
            // 完成組數*10分+(60秒-花費時間)*1=總分
            ScoreLabel.Text = "得分：" + ((CardPairCount - Undone) * 10 + RemainingGameTime).ToString();

            // 挑戰失敗
            if (Undone > 0)
            {
                LastTimeLabel.Text = "挑戰失敗";
            }
            // 挑戰成功
            else
            {
                LastTimeLabel.Text = "挑戰成功";
            }

            string resultText = LastTimeLabel.Text + "\n" + ScoreLabel.Text;
            resultText += "\n" +
                "請問是否重新開始遊戲？\n" +
                "點擊「是」重新開始，「否」關閉遊戲。\n";
            DialogResult dialogResult = MessageBox.Show(resultText, "遊戲結束", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Reset();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// 鎖定圖片物件
        /// </summary>
        private void LockPictureBox()
        {
            foreach (Control ctl in GamePanel.Controls)
            {
                if (ctl is PictureBox pictureBox && pictureBox.Visible)
                {
                    pictureBox.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 解除鎖定圖片物件
        /// </summary>
        private void UnlockPictureBox()
        {
            foreach (Control ctl in GamePanel.Controls)
            {
                if (ctl is PictureBox pictureBox && pictureBox.Visible)
                {
                    pictureBox.Enabled = true;
                    pictureBox.BorderStyle = BorderStyle.None;
                }
            }
            FirstClick = null;
            SecondClick = null;

            // 全數按完
            if (Undone == 0)
            {
                GameOver();
            }
        }

        /// <summary>
        /// 啟用圖片
        /// </summary>
        private void EnablePictureBox()
        {
            foreach (Control ctl in GamePanel.Controls)
            {
                if (ctl is PictureBox pictureBox)
                {
                    pictureBox.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 關閉圖片
        /// </summary>
        private void DisablePictureBox()
        {
            foreach (Control ctl in GamePanel.Controls)
            {
                if (ctl is PictureBox pictureBox)
                {
                    pictureBox.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 遮罩圖片
        /// </summary>
        private void MaskPictureBox()
        {
            foreach (Control ctl in GamePanel.Controls)
            {
                if (ctl is PictureBox pictureBox)
                {
                    pictureBox.Image = CardEnum.卡牌背面;
                }
            }
        }
    }
}
