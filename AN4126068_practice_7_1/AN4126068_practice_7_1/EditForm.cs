using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;


namespace AN4126068_practice_6_1
{
    public partial class EditForm : Form
    {
        bool isMyTXT = false;
        public EditForm(string content, bool isMyTXT)
        {
            InitializeComponent();
            this.isMyTXT = isMyTXT;
            if (isMyTXT) {
                var textData = JsonConvert.DeserializeObject<dynamic>(content);
                textBox.Text = textData.Content;
                textBox.Font = new Font((string)textData.FontName, (float)textData.FontSize, (FontStyle)(int)textData.FontStyle);
                textBox.ForeColor = Color.FromArgb((int)textData.ForeColor);
                textBox.ForeColor = Color.FromArgb((int)textData.ForeColor);
            }
            else
            {
                textBox.Text = content;
            }
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text != "Form2"){
                using (StreamWriter writer = new StreamWriter(this.Text))
                {
                    // 將你要儲存的內容寫入文件中
                    writer.Write(textBox.Text);
                }
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|Custom Text Files (*.mytxt)|*.mytxt",
                DefaultExt = "txt",
                Title = "儲存檔案"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                {
                    // 只保存文字內容
                    File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                }
                else if (Path.GetExtension(saveFileDialog.FileName) == ".mytxt")
                {
                    // 保存文字內容和樣式資訊
                    var textData = new
                    {
                        Content = textBox.Text,
                        FontName = textBox.Font.Name,
                        FontSize = textBox.Font.Size,
                        FontStyle = textBox.Font.Style,
                        ForeColor = textBox.ForeColor.ToArgb() // 轉換顏色為 ARGB 值
                    };

                    string json = JsonConvert.SerializeObject(textData, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(saveFileDialog.FileName, json);
                }
                this.Text = saveFileDialog.FileName;
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|Custom Text Files (*.mytxt)|*.mytxt",
                DefaultExt = "txt",
                Title = "儲存檔案"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                {
                    // 只保存文字內容
                    File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                }
                else if (Path.GetExtension(saveFileDialog.FileName) == ".mytxt")
                {
                    // 保存文字內容和樣式資訊
                    var textData = new
                    {
                        Content = textBox.Text,
                        FontName = textBox.Font.Name,
                        FontSize = textBox.Font.Size,
                        FontStyle = textBox.Font.Style,
                        ForeColor = textBox.ForeColor.ToArgb() // 轉換顏色為 ARGB 值
                    };

                    string json = JsonConvert.SerializeObject(textData, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(saveFileDialog.FileName, json);
                }
                this.Text = saveFileDialog.FileName;
            }
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0) {
                Clipboard.SetText(textBox.SelectedText); 
                textBox.SelectedText = "";
            }
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0)
            {
                Clipboard.SetText(textBox.SelectedText);
            }
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBox.SelectedText = Clipboard.GetText();
            }
        }

        private void 字形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Font = fontDialog.Font; 
                }
            }
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using( ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.ForeColor = colorDialog.Color;
                }
            }
        }
    }
}
