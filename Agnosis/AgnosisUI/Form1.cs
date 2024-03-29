﻿using Agnosis.Util;
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
using FileAccess = Agnosis.Util.FileAccess;

namespace AgnosisUI
{
    public partial class AgnosisUI : Form
    {
        public AgnosisUI()
        {
            InitializeComponent();
            this.MaskSelector.SelectedIndex = 1;
            this.StatusText.Text = "";
            FolderBrowser.SelectedPath = Environment.CurrentDirectory;
            this.MaskColumnCheckbox.Checked = true;
            this.HideColumnCheckbox.Checked = false;
            this.SpreadsheetFileNameSelector.Visible = false;
            this.SpreadsheetNameLabel.Visible = false;
        }

        private void RunMaskButton_Click(object sender, EventArgs e)
        {
            WriteStatusLog("Getting file paths...");
            List<string> filePaths = new List<string>();
            List<string> originalFilePaths = new List<string>();
            //verify mask folder path is valid.
            if (!MaskFolderPathIsValid(out filePaths))
            {
                ShowAlert("Mask folder path invalid. Please select a valid folder");
                ClearStatusLog();
                return;
            }

            //verify copy folder path is valid.
            if (!CopyFolderPathIsValid())
            {
                ShowAlert("Output folder is invalid. Please select a valid folder to copy to");
                ClearStatusLog();
                return;
            }
            //verify filename is populated, if checkbox is checked
            if (RenameSpreadsheetCheckbox.Checked && this.SpreadsheetFileNameIsValid())
            {
                ShowAlert("Spreadsheet file name is invalid. Please select a different name");
                ClearStatusLog();
                return;
            }

            try
            {
                if (MaskSelector.SelectedIndex == 0)
                {
                    ResultDirSelector.Text = MaskDirSelector.Text;
                    originalFilePaths = filePaths;
                }
                WriteStatusLog("Masking and copying files...");
                var fileMasks = FileAccess.CopyFilesAndMask(filePaths, MaskDirSelector.Text, ResultDirSelector.Text);
                if (MaskSelector.SelectedIndex == 0)
                {
                    FileAccess.RemoveFiles(originalFilePaths);
                }
                WriteStatusLog("Creating Excel spreadsheet...");
                var spreadsheetName = RenameSpreadsheetCheckbox.Checked ? SpreadsheetFileNameSelector.Text : "Spreadsheet";
                ExcelInteropAccess.CreateAndPopulateSpreadsheet(fileMasks, $"{ResultDirSelector.Text}\\{spreadsheetName}.xlsx", HideColumnCheckbox.Checked, MaskColumnCheckbox.Checked);
                WriteStatusLog("DONE!");
            }
            catch (Exception er)
            {
                ShowAlert("An error occurred while processing files.\n\n" +
                          "Files may not have been processed or included in the spreadsheet. " +
                          "Please send Brandon the log file created in the same directory as this program.", true);
                FileAccess.WriteLogFile(new List<string>{er.Message, er.StackTrace});
                WriteStatusLog("AN ERROR OCCURRED! please Send Brandon the log file");
            }
            
        }

        private void MaskSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaskSelector.SelectedIndex == 0)
            {
                ResultDirSelector.Enabled = false;
                CopyPathButton.Enabled = false;
                WarningLabel.Visible = true;
            }
            else
            {
                ResultDirSelector.Enabled = true;
                CopyPathButton.Enabled = true;
                WarningLabel.Visible = false;
            }
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            var selectedResult = FolderBrowser.ShowDialog(this);
            if (selectedResult == DialogResult.OK)
            {
                MaskDirSelector.Text = FolderBrowser.SelectedPath;
                //FolderBrowser.SelectedPath = Environment.CurrentDirectory;
            }
        }
        private void CopyPathButton_Click(object sender, EventArgs e)
        {
            var selectedResult = FolderBrowser.ShowDialog(this);
            if (selectedResult == DialogResult.OK)
            {
                ResultDirSelector.Text = FolderBrowser.SelectedPath;
                //FolderBrowser.SelectedPath = Environment.CurrentDirectory;
            }
        }

        private void MaskDirSelector_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(MaskDirSelector,MaskDirSelector.Text);
        }

        private void ResultDirSelector_MouseHover(object sender, EventArgs e)
        {
            if (ResultDirSelector.Enabled)
            {
                toolTip1.SetToolTip(ResultDirSelector, ResultDirSelector.Text);
            }
        }
        private void RenameSpreadsheetCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (RenameSpreadsheetCheckbox.Checked)
            {
                SpreadsheetFileNameSelector.Visible = true;
                SpreadsheetNameLabel.Visible = true;
            }
            else
            {
                SpreadsheetFileNameSelector.Visible = false;
                SpreadsheetNameLabel.Visible = false;
            }
        }

        private void WriteStatusLog(string status)
        {
            StatusText.Text = status;
        }

        private void ClearStatusLog()
        {
            StatusText.Text = "";
        }

        private void ShowAlert(string message, bool error = false)
        {
            var messageBoxIcon = error ? MessageBoxIcon.Error : MessageBoxIcon.Warning;
            var messageBoxCaption = error ? "Error" : "Warning";
            MessageBox.Show(message, messageBoxCaption,
                MessageBoxButtons.OK, messageBoxIcon);
        }

        private bool MaskFolderPathIsValid(out List<string> folderPaths)
        {
            try
            {
                folderPaths = FileAccess.GetFilePathsInDirectory(MaskDirSelector.Text);
                if (folderPaths.Count == 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                folderPaths = new List<string>();
                return false;
            }
        }

        private bool CopyFolderPathIsValid()
        {
            try
            {
                if (MaskSelector.SelectedIndex == 0)
                {
                    return true;
                }
                if(ResultDirSelector.Text == String.Empty)
                {
                    return false;
                }
                Directory.CreateDirectory(ResultDirSelector.Text);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool SpreadsheetFileNameIsValid()
        {
            return SpreadsheetFileNameSelector.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0;
        }
    }
}
