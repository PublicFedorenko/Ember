﻿    using System;
using System.Windows.Forms;

namespace Screenshot.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            checkBoxEnableSoundEffect.Checked = Settings.Default.EnableSoundEffect;
            hotkeyTextBoxRegion.Hotkey = Settings.Default.RegionHotkey;
            checkBoxUploadAfterCapture.Checked= Settings.Default.UploadAfterCapture;
            radioButtonCopyLinkToClipboard.Checked = Settings.Default.OnUploadCopyLinkToClipboard;
            radioButtonOpenImageInBrowser.Checked = Settings.Default.OnUploadOpenImageInBrowser;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.EnableSoundEffect = checkBoxEnableSoundEffect.Checked;
            Settings.Default.RegionHotkey = hotkeyTextBoxRegion.Hotkey;
            Settings.Default.UploadAfterCapture = checkBoxUploadAfterCapture.Checked;
            Settings.Default.OnUploadCopyLinkToClipboard = radioButtonCopyLinkToClipboard.Checked;
            Settings.Default.OnUploadOpenImageInBrowser = radioButtonOpenImageInBrowser.Checked;

            Settings.Default.Save();
        }
    }
}
