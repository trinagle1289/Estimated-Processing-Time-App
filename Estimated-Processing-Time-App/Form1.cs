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

        private int speedRate = 0;

        #region 按鈕功能

        private void buttonRead_Click(object sender, EventArgs e) {
            ClearMessage();
            AddMessage("讀取G-CODE中...");
            AddMessage("讀取完畢");
        }

        /// <summary>
        /// 按下預估時間按鈕行為
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPredict_Click(object sender, EventArgs e) {
            if (speedRate <= 0) {
                AddMessage("尚未選取加工時間");
            }
            else {
                AddMessage("開始計算加工時間...");
                AddMessage("...");
                AddMessage("...");
                AddMessage("...");
                AddMessage("加工時間為" + (1000000 / speedRate) + "分鐘");
            }

        }

        #endregion

        #region Speed Rate 選取行為

        /// <summary>
        /// 切換SpeedRate500行為
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_SR500_MouseClick(object sender, MouseEventArgs e) {
            AddMessage("切換 Speed Rate 為 500");
            speedRate = 500;
        }

        /// <summary>
        /// 切換SpeedRate1000行為
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_SR1000_Click(object sender, EventArgs e) {
            AddMessage("切換 Speed Rate 為 1000");
            speedRate = 1000;
        }

        /// <summary>
        /// 切換SpeedRate2000行為
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_SR2000_Click(object sender, EventArgs e) {
            AddMessage("切換 Speed Rate 為 2000");
            speedRate = 2000;
        }

        /// <summary>
        /// 切換SpeedRate4000行為
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_SR4000_Click(object sender, EventArgs e) {
            AddMessage("切換 Speed Rate 為 4000");
            speedRate = 4000;
        }

        #endregion

        #region 自定義功能

        private void ClearMessage() {
            textBoxMessage.Clear();
        }

        private void AddMessage(string message) {
            textBoxMessage.AppendText(message + "\r\n");
        }

        #endregion

    }
}
