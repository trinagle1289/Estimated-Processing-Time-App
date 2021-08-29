using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimated_Processing_Time_App
{
    public partial class Form1 :Form
    {
        public Form1() {
            InitializeComponent();
        }

        private int feedRate = 0;

        #region 按鈕功能

        /// <summary>
        /// 按下預估時間按鈕行為
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPredict_Click(object sender, EventArgs e) {
            ClearMessage();
            AddMessage("讀取G-code中...");
            AddMessage("讀取完畢");
            if (feedRate <= 0) {
                AddMessage("尚未選取加工時間");
            }
            else {
                AddMessage("開始計算加工時間...");
                AddMessage("...");
                AddMessage("...");
                AddMessage("...");
                AddMessage("加工時間為" + (1000000 / feedRate) + "分鐘");
            }

        }

        #endregion

        #region Feed Rate 選取行為

        private void radioButton_FR500_Click(object sender, EventArgs e) {
            AddFeedRateMessage(500);
        }

        private void radioButton_FR1000_Click(object sender, EventArgs e) {
            AddFeedRateMessage(1000);
        }

        private void radioButton_FR2000_Click(object sender, EventArgs e) {
            AddFeedRateMessage(2000);
        }

        private void radioButton_FR3000_Click(object sender, EventArgs e) {
            AddFeedRateMessage(3000);
        }

        private void radioButton_FR4000_Click(object sender, EventArgs e) {
            AddFeedRateMessage(4000);
        }

        private void radioButton_FR5000_Click(object sender, EventArgs e) {
            AddFeedRateMessage(5000);
        }

        private void radioButton_FR6000_Click(object sender, EventArgs e) {
            AddFeedRateMessage(6000);
        }

        #endregion

        #region 自定義功能

        private void ClearMessage() {
            textBoxMessage.Clear();
        }

        private void AddMessage(string message) {
            textBoxMessage.AppendText(message + "\r\n");
        }

        private void AddFeedRateMessage(int feedRate) {
            AddMessage("選擇 Feedrate 為 " + feedRate + " mm/min");
            this.feedRate = feedRate;
        }

        private void RunMatlabCode() {
            
        }

        #endregion

    }
}
